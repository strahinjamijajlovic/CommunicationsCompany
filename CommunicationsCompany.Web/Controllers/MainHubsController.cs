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
    public class MainHubsController : Controller
    {
        private readonly IMainHubRepository _mainHubRepo;
        private readonly IRegionalHubRepository _regionalHubRepo;
        private readonly IMapper _mapper;
        private readonly ILogger<MainHubsController> _logger;

        public MainHubsController(IMainHubRepository mainHubRepo,
            IRegionalHubRepository regionalHubRepo,
            IMapper mapper,
            ILogger<MainHubsController> logger)
        {
            _mainHubRepo = mainHubRepo;
            _regionalHubRepo = regionalHubRepo;
            _mapper = mapper;
            _logger = logger;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(long id)
        {
            var entity = await _mainHubRepo.Find(id);
            if (entity is null)
                NotFound();

            var vm = _mapper.Map<MainHubViewModel>(entity);

            return Ok(vm);
        }

        [HttpPost]
        public async Task<IActionResult> Create(MainHubViewModel vm)
        {
            if (ModelState.IsValid)
            {
                var entity = _mapper.Map<MainHub>(vm);

                //Same as for choosing the region as for choosing the Main Hub for the Comm Node
                if (entity.RegionalHub is null)
                    entity.RegionalHub = await _regionalHubRepo.Find(1);

                await _mainHubRepo.Add(entity);

                return Ok();
            }

            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Update(MainHubViewModel vm)
        {
            if (ModelState.IsValid)
            {
                var entity = await _mainHubRepo.Find(vm.Id);
                if (entity is null)
                    return NotFound();

                _mapper.Map(vm, entity);

                await _mainHubRepo.Update(entity);

                return Ok();
            }

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            await _mainHubRepo.Remove(id);
            return Ok();
        }
    }
}
