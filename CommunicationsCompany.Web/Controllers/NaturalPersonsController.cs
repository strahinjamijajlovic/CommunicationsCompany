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
    public class NaturalPersonsController : Controller
    {
        private readonly INaturalPersonRepository _naturalPersonRepo;
        private readonly IMapper _mapper;
        private readonly ILogger<NaturalPersonsController> _logger;

        public NaturalPersonsController(INaturalPersonRepository naturalPersonRepo, IMapper mapper, ILogger<NaturalPersonsController> logger)
        {
            _naturalPersonRepo = naturalPersonRepo;
            _mapper = mapper;
            _logger = logger;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(long id)
        {
            var entity = await _naturalPersonRepo.Find(id);
            if (entity is null)
                NotFound();

            var vm = _mapper.Map<NaturalPersonViewModel>(entity);

            return Ok(vm);
        }

        [HttpPost]
        public async Task<IActionResult> Create(NaturalPersonViewModel vm)
        {
            if (ModelState.IsValid)
            {
                var entity = _mapper.Map<NaturalPerson>(vm);
                await _naturalPersonRepo.Add(entity);

                return Ok();
            }

            return BadRequest();
        }

        [HttpPost]
        public async Task<IActionResult> Update(NaturalPersonViewModel vm)
        {
            if (ModelState.IsValid)
            {
                var entity = await _naturalPersonRepo.Find(vm.Id);
                if (entity is null)
                    return NotFound();

                _mapper.Map(vm, entity);

                await _naturalPersonRepo.Update(entity);

                return Ok();
            }

            return BadRequest();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            await _naturalPersonRepo.Remove(id);
            return Ok();
        }
    }
}
