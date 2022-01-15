using CommunicationsCompany.Domain.Repositories;
using CommunicationsCompany.FormsApp.Forms.CommNodes;
using CommunicationsCompany.FormsApp.Forms.MainHubs;
using CommunicationsCompany.FormsApp.Forms.RegionalHubs;
using CommunicationsCompany.FormsApp.Forms.Users.LegalEntities;
using CommunicationsCompany.FormsApp.Forms.Users.NaturalPeople;
using CommunicationsCompany.Persistance.Mappings;
using CommunicationsCompany.Persistance.Repositories;
using CommunicationsCompany.Persistance.Seeder;
using FluentNHibernate.Cfg;
using Microsoft.Extensions.DependencyInjection;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommunicationsCompany.FormsApp
{
    static class Program
    {
        private static IServiceProvider ServiceProvider { get; set; }
        static void ConfigureServices()
        {
            var services = new ServiceCollection();

            services.AddSingleton<ISessionFactory>(factory =>
            {
                return Fluently
                            .Configure()
                            .Database(() =>
                            {

                                return FluentNHibernate.Cfg.Db.MsSqlConfiguration
                                        .MsSql2012
                                        .ShowSql()
                                        .ConnectionString("data source=DESKTOP-F4ARHIM;Initial Catalog=CommunicationsCompany;Integrated Security=True;");
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
            services.AddSingleton<MainForm>();
            services.AddSingleton<AddCommNode>();
            services.AddSingleton<UpdateCommNode>();
            services.AddSingleton<IndexCommNodes>();
            services.AddSingleton<IndexMainHubs>();
            services.AddSingleton<AddMainHub>();
            services.AddSingleton<UpdateMainHub>();
            services.AddSingleton<IndexRegionalHubs>();
            services.AddSingleton<AddRegionalHub>();
            services.AddSingleton<UpdateRegionalHub>();
            services.AddSingleton<IndexLegalEntities>();
            services.AddSingleton<AddLegalEntity>();
            services.AddSingleton<UpdateLegalEntity>();
            services.AddSingleton<IndexNaturalPeople>();
            services.AddSingleton<AddNaturalPerson>();
            services.AddSingleton<UpdateNaturalPerson>();
            ServiceProvider = services.BuildServiceProvider();
        }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ConfigureServices();
            Application.Run((Form)ServiceProvider.GetService(typeof(MainForm)));
        }
    }
}