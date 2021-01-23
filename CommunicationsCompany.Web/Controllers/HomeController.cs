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

namespace CommunicationsCompany.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IDeviceRepository _deviceRepository;

        public HomeController(ILogger<HomeController> logger, IDeviceRepository deviceRepository)
        {
            _logger = logger;
            _deviceRepository = deviceRepository;
        }

        public async Task<IActionResult> Index()
        {
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
