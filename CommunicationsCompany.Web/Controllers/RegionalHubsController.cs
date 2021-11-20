using CommunicationsCompany.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommunicationsCompany.Web.Controllers
{
    [Route("[controller]/[action]")]
    public class RegionalHubsController : Controller
    {
        private readonly ILogger<RegionalHubsController> _logger;

        public RegionalHubsController(ILogger<RegionalHubsController> logger)
        {
            _logger = logger;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(long id)
        {
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Create(RegionalHubViewModel vm)
        {
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Update(RegionalHubViewModel vm)
        {
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            return Ok();
        }
    }
}
