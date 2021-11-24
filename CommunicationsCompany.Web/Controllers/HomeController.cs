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

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
