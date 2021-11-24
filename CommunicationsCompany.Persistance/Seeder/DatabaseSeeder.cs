using CommunicationsCompany.Domain.Entities;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationsCompany.Persistance.Seeder
{
    public class DatabaseSeeder
    {
        private readonly ISession _session;

        public DatabaseSeeder(ISession session)
        {
            _session = session;
        } 

        public async Task SeedDatabase()
        {
            using var transaction = _session.BeginTransaction();
            if (!_session.Query<RegionalHub>().Any())
            {
                var regionalHub = new RegionalHub
                {
                    Device = new Device
                    {
                        InstallationDate = DateTime.Today.AddDays(-1),
                        LastServiceDate = DateTime.Today,
                        SerialNumber = "RegionalHubSNum",
                        LastServiceReason = "Service reason ",
                        ManufacturerName = "Manufacturer"
                    },
                    RegionName = "Region Name"
                };
                await _session.SaveAsync(regionalHub);

                for (int i = 0; i < 2; i++)
                {
                    var mainHub = new MainHub
                    {
                        RegionalHub = regionalHub,
                        Device = new Device
                        {
                            InstallationDate = DateTime.Today.AddDays(-1),
                            LastServiceDate = DateTime.Today,
                            SerialNumber = "MainHubSNum" + i.ToString(),
                            LastServiceReason = "Service reason " + i.ToString(),
                            ManufacturerName = "Manufacturer"
                        },
                    };
                    for (int j = 0; j < 10; j++)
                    {
                        var commNode = new CommNode
                        {
                            Address = new Address
                            {
                                ApartmentNumber = j,
                                City = "City " + j.ToString(),
                                Street = "Street " + j.ToString()
                            },
                            Description = "Comm Node " + j.ToString(),
                            Device = new Device
                            {
                                InstallationDate = DateTime.Today.AddDays(-1),
                                LastServiceDate = DateTime.Today,
                                SerialNumber = "SNum" + j.ToString(),
                                LastServiceReason = "Service reason " + j.ToString(),
                                ManufacturerName = "Manufacturer"
                            },
                            MainHub = mainHub,
                        };

                        await _session.SaveAsync(commNode); 

                        for (int k = 0; k < 3; k++)
                        {
                            var naturalPerson = new NaturalPerson
                            {
                                JMBG = "0101999710011",
                                ContactNumber = "+3816401234567",
                                Address = new Address
                                {
                                    ApartmentNumber = k,
                                    City = "City " + k.ToString(),
                                    Street = "Street " + k.ToString()
                                },
                                User = new User
                                {
                                    CommNode = commNode,
                                    FirstName = "Natural Person",
                                    LastName = ((i + 1) * (j + 1) * (k + 1)).ToString()
                                },
                                Services = new Services
                                {
                                    InternetService = new InternetService
                                    {
                                        Prepaid = true,
                                        AccountBalance = 0,
                                        LastPaymentDate = DateTime.Today,
                                        FlatRate = true,
                                        StaticIPs = new HashSet<StaticIp>
                                        {
                                            new StaticIp
                                            {
                                                IpAddress = "192.168.1.1"
                                            },
                                            new StaticIp
                                            {
                                                IpAddress = "192.168.1.2"
                                            },
                                        }
                                    },
                                    ExtraTvPrograms = new HashSet<ExtraProgram>
                                    {
                                        new ExtraProgram
                                        {
                                            Name = "Program 1"
                                        },
                                        new ExtraProgram
                                        {
                                            Name = "Program 2"
                                        }
                                    },
                                    PhoneNumbers = new HashSet<PhoneNumber>
                                    {
                                        new PhoneNumber
                                        {
                                            Number = "+381641234567",
                                            MinutesCount = k
                                        },
                                        new PhoneNumber
                                        {
                                            Number = "+381647654321",
                                            MinutesCount = k * 2
                                        },
                                    }
                                }
                            };
                            await _session.SaveAsync(naturalPerson);

                            var legalEntity = new LegalEntity
                            {
                                PIB = "12345678",
                                FaxNumber = "+3816401234567",
                                ContactPerson = new User
                                {
                                    CommNode = commNode,
                                    FirstName = "Legal Entity",
                                    LastName = ((i + 1) * (j + 1) * (k + 1)).ToString()
                                },
                                Services = new Services
                                {
                                    InternetService = new InternetService
                                    {
                                        Prepaid = true,
                                        AccountBalance = 0,
                                        LastPaymentDate = DateTime.Today,
                                        FlatRate = true,
                                        StaticIPs = new HashSet<StaticIp>
                                        {
                                            new StaticIp
                                            {
                                                IpAddress = "192.168.1.1"
                                            },
                                            new StaticIp
                                            {
                                                IpAddress = "192.168.1.2"
                                            },
                                        }
                                    },
                                    ExtraTvPrograms = new HashSet<ExtraProgram>
                                    {
                                        new ExtraProgram
                                        {
                                            Name = "Program 1"
                                        },
                                        new ExtraProgram
                                        {
                                            Name = "Program 2"
                                        }
                                    },
                                    PhoneNumbers = new HashSet<PhoneNumber>
                                    {
                                        new PhoneNumber
                                        {
                                            Number = "+381641234567",
                                            MinutesCount = i
                                        },
                                        new PhoneNumber
                                        {
                                            Number = "+381647654321",
                                            MinutesCount = i * 2
                                        },
                                    }
                                }
                            };
                            await _session.SaveAsync(legalEntity);
                        }
                    }
                    await _session.SaveAsync(mainHub);
                }
                transaction.Commit();
            }
        }
    }
}
