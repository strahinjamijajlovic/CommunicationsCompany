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
    public class LegalEntitiesController : Controller
    {
        private readonly ILegalEntityRepository _legalEntityRepo;
        private readonly IMapper _mapper;
        private readonly ILogger<LegalEntitiesController> _logger;

        public LegalEntitiesController(ILegalEntityRepository legalEntityRepo, IMapper mapper, ILogger<LegalEntitiesController> logger)
        {
            _legalEntityRepo = legalEntityRepo;
            _mapper = mapper;
            _logger = logger;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(long id)
        {
            var entity = await _legalEntityRepo.Find(id);
            if (entity is null)
                NotFound();

            var vm = _mapper.Map<LegalEntityViewModel>(entity);

            return Ok(vm);
        }

        [HttpPost]
        public async Task<IActionResult> Create(LegalEntityViewModel vm)
        {
            if (ModelState.IsValid)
            {
                var entity = _mapper.Map<LegalEntity>(vm);
                await _legalEntityRepo.Add(entity);

                return Ok();
            }

            return BadRequest();
        }

        [HttpPost]
        public async Task<IActionResult> Update(LegalEntityViewModel vm)
        {
            if (ModelState.IsValid)
            {
                var entity = await _legalEntityRepo.Find(vm.Id);
                if (entity is null)
                    return NotFound();

                _mapper.Map(vm, entity);

                await _legalEntityRepo.Update(entity);

                return Ok();
            }

            return BadRequest();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            await _legalEntityRepo.Remove(id);
            return Ok();
        }
    }
}
