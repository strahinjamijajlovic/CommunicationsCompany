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
    public class LegalEntitiesController : Controller
    {
        private readonly ILogger<LegalEntitiesController> _logger;

        public LegalEntitiesController(ILogger<LegalEntitiesController> logger)
        {
            _logger = logger;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(long id)
        {
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Create(LegalEntityViewModel vm)
        {
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Update(LegalEntityViewModel vm)
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
