using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommunicationsCompany.Domain.Repositories;
using CommunicationsCompany.Persistance.Mappings;
using CommunicationsCompany.Persistance.Repositories;
using FluentNHibernate.Cfg;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using AutoMapper;
using AutoMapper.EquivalencyExpression;
using CommunicationsCompany.Persistance.Seeder;

namespace CommunicationsCompany.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            services.AddSingleton<ISessionFactory>(factory =>
            {
                return Fluently
                            .Configure()
                            .Database(() =>
                            {

                                return FluentNHibernate.Cfg.Db.MsSqlConfiguration
                                        .MsSql2012
                                        .ShowSql()
                                        .ConnectionString(Configuration.GetConnectionString("DefaultConnection"));
                            })
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<AddressMap>())
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<CommNodeMap>())
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<DeviceMap>())
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<ExtraProgramMap>())
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<InternetServiceMap>())
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<LegalEntityMap>())
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<MainHubMap>())
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<NaturalPersonMap>())
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<PhoneNumberMap>())
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<RegionalHubMap>())
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<ServicesMap>())
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<StaticIpMap>())
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<UserMap>())
                .ExposeConfiguration(cfg => new SchemaUpdate(cfg).Execute(false, true))
                .BuildSessionFactory();
            });

            services.AddScoped<ISession>(factory =>
               factory
                    .GetServices<ISessionFactory>()
                    .First()
                    .OpenSession()
            );

            services.AddScoped<ICommNodeRepository, CommNodeRepository>();
            services.AddScoped<ILegalEntityRepository, LegalEntityRepository>();
            services.AddScoped<IMainHubRepository, MainHubRepository>();
            services.AddScoped<INaturalPersonRepository, NaturalPersonRepository>();
            services.AddScoped<IRegionalHubRepository, RegionalHubRepository>();
            services.AddScoped<IServicesRepository, ServicesRepository>();

            services.AddScoped<DatabaseSeeder>();

            services.AddSwaggerGen();
            services.AddAutoMapper(cfg =>
            {
                cfg.AddCollectionMappers();
            }, AppDomain.CurrentDomain.GetAssemblies());
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
