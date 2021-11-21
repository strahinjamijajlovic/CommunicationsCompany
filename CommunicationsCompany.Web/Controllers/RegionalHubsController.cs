using AutoMapper;
using CommunicationsCompany.Domain.Entities;
using CommunicationsCompany.Domain.Repositories;
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
        private readonly IRegionalHubRepository _regionalHubRepo;
        private readonly IMapper _mapper;
        private readonly ILogger<RegionalHubsController> _logger;

        public RegionalHubsController(IRegionalHubRepository regionalHubRepo,
            IMapper mapper,
            ILogger<RegionalHubsController> logger)
        {
            _regionalHubRepo = regionalHubRepo;
            _mapper = mapper;
            _logger = logger;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(long id)
        {
            var entity = await _regionalHubRepo.Find(id);
            if (entity is null)
                NotFound();

            var vm = _mapper.Map<RegionalHubViewModel>(entity);

            return Ok(vm);
        }

        [HttpPost]
        public async Task<IActionResult> Create(RegionalHubViewModel vm)
        {
            if (ModelState.IsValid)
            {
                var entity = _mapper.Map<RegionalHub>(vm);

                await _regionalHubRepo.Add(entity);

                return Ok();
            }

            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Update(RegionalHubViewModel vm)
        {
            if (ModelState.IsValid)
            {
                var entity = await _regionalHubRepo.Find(vm.Id);
                if (entity is null)
                    return NotFound();

                _mapper.Map(vm, entity);

                await _regionalHubRepo.Update(entity);

                return Ok();
            }

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            await _regionalHubRepo.Remove(id);
            return Ok();
        }
    }
}
