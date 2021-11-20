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
    public class NaturalPersonsController : Controller
    {
        private readonly ILogger<NaturalPersonsController> _logger;

        public NaturalPersonsController(ILogger<NaturalPersonsController> logger)
        {
            _logger = logger;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(long id)
        {
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Create(NaturalPersonViewModel vm)
        {
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Update(NaturalPersonViewModel vm)
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
