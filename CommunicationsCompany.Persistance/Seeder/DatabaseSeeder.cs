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
            await SeedRegionalHubs();
            await SeedMainHubs();
            await SeedCommNodes();

            await SeedNaturalPersons();
            await SeedLegalEntities();
        }

        private async Task SeedRegionalHubs()
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

                transaction.Commit();
            }
        }

        private async Task SeedMainHubs()
        {
            using var transaction = _session.BeginTransaction();
            if (!_session.Query<RegionalHub>().Any())
            {
                for (int i = 0; i < 2; i++)
                {
                    var mainHub = new MainHub
                    {
                        RegionalHub = new RegionalHub
                        {
                            Id = 1
                        },
                        Device = new Device
                        {
                            InstallationDate = DateTime.Today.AddDays(-1),
                            LastServiceDate = DateTime.Today,
                            SerialNumber = "MainHubSNum" + i.ToString(),
                            LastServiceReason = "Service reason " + i.ToString(),
                            ManufacturerName = "Manufacturer"
                        },
                    };
                    await _session.SaveAsync(mainHub);
                }
                transaction.Commit();
            }
        }

        private async Task SeedCommNodes() 
        {
            using var transaction = _session.BeginTransaction();
            if (!_session.Query<RegionalHub>().Any())
            {
                for (int i = 0; i < 10; i++)
                {
                    var commNode = new CommNode
                    {
                        Address = new Address
                        {
                            ApartmentNumber = i,
                            City = "City " + i.ToString(),
                            Street = "Street " + i.ToString()
                        },
                        Description = "Comm Node " + i.ToString(),
                        Device = new Device
                        {
                            InstallationDate = DateTime.Today.AddDays(-1),
                            LastServiceDate = DateTime.Today,
                            SerialNumber = "SNum" + i.ToString(),
                            LastServiceReason = "Service reason " + i.ToString(),
                            ManufacturerName = "Manufacturer"
                        },
                        MainHub = new MainHub
                        {
                            Id = (i % 2) + 1
                        },
                    };
                    await _session.SaveAsync(commNode);
                }

                transaction.Commit();
            }
        }
        private async Task SeedNaturalPersons()
        {
            using var transaction = _session.BeginTransaction();
            if (!_session.Query<RegionalHub>().Any())
            {
                for (int i = 0; i < 25; i++)
                {
                    var naturalPerson = new NaturalPerson
                    {
                        JMBG = "0101999710011",
                        ContactNumber = "+3816401234567",
                        Address = new Address
                        {
                            ApartmentNumber = i,
                            City = "City " + i.ToString(),
                            Street = "Street " + i.ToString()
                        },
                        User = new User
                        {
                            CommNode = new CommNode
                            {
                                Id = (i % 5) + 1
                            },
                            FirstName = "Natural Person",
                            LastName = i.ToString()
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
                    await _session.SaveAsync(naturalPerson);
                }
                transaction.Commit();
            }
        }
        private async Task SeedLegalEntities()
        {
            using var transaction = _session.BeginTransaction();
            if (!_session.Query<RegionalHub>().Any())
            {
                for (int i = 0; i < 25; i++)
                {
                    var legalEntity = new LegalEntity
                    {
                        PIB = "12345678",
                        FaxNumber = "+3816401234567",
                        ContactPerson = new User
                        {
                            CommNode = new CommNode
                            {
                                Id = (i % 5) + 1 + 5
                            },
                            FirstName = "Natural Person",
                            LastName = i.ToString()
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
                transaction.Commit();
            }
        }
    }
}
