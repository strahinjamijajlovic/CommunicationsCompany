using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CommunicationsCompany.Web.Models;
using NHibernate;
using CommunicationsCompany.Domain.Repositories;
using CommunicationsCompany.Domain.Entities;
using System.Collections.ObjectModel;

namespace CommunicationsCompany.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMainHubRepository _mainHubRepository;

        public HomeController(ILogger<HomeController> logger, IMainHubRepository mainHubRepository)
        {
            _logger = logger;
            _mainHubRepository = mainHubRepository;
        }

        public async Task<IActionResult> Index()
        {
            var mainHub = new MainHub
            {
                Device = new Device
                {
                    SerialNumber = "serialNumber",
                    InstallationDate = DateTime.Today,
                    LastServiceDate = DateTime.Today,
                    LastServiceReason = "Service reason",
                    ManufacturerName = "Cisco"
                },
                RegionalHub = new RegionalHub
                {
                    Device = new Device
                    {
                        SerialNumber = "serialNumber2",
                        InstallationDate = DateTime.Today,
                        LastServiceDate = DateTime.Today,
                        LastServiceReason = "Service reason",
                        ManufacturerName = "Cisco"
                    },
                    RegionName = "test region"
                },
            };
            mainHub.CommNodes = new HashSet<CommNode>
                {
                    new CommNode
                    {
                        Address = new Address
                        {
                            ApartmentNumber= 1,
                            City = "City",
                            Street = "Street"
                        },
                        Description = "Description",
                        Device = new Device
                        {
                            SerialNumber = "serialNumber3",
                            InstallationDate = DateTime.Today,
                            LastServiceDate = DateTime.Today,
                            LastServiceReason = "Service reason",
                            ManufacturerName = "Cisco"
                        },
                        MainHub = mainHub
                    }
                };
            await _mainHubRepository.Add(mainHub);
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
