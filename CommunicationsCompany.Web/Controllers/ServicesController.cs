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
    public class ServicesController : Controller
    {
        private readonly IServicesRepository _servicesRepo;
        private readonly IMapper _mapper;
        private readonly ILogger<ServicesController> _logger;

        public ServicesController(IServicesRepository servicesRepo, IMapper mapper, ILogger<ServicesController> logger)
        {
            _servicesRepo = servicesRepo;
            _mapper = mapper;
            _logger = logger;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(long id)
        {
            var entity = await _servicesRepo.Find(id);
            if (entity is null)
                NotFound();

            var vm = _mapper.Map<ServicesViewModel>(entity);

            return Ok(vm);
        }

        [HttpPost]
        public async Task<IActionResult> Create(ServicesViewModel vm)
        {
            if (ModelState.IsValid)
            {
                var entity = _mapper.Map<Services>(vm);
                await _servicesRepo.Add(entity);

                return Ok();
            }

            return BadRequest();
        }

        [HttpPost]
        public async Task<IActionResult> Update(ServicesViewModel vm)
        {
            if (ModelState.IsValid)
            {
                var entity = await _servicesRepo.Find(vm.Id);
                if (entity is null)
                    return NotFound();

                _mapper.Map(vm, entity);

                await _servicesRepo.Update(entity);

                return Ok();
            }

            return BadRequest();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            await _servicesRepo.Remove(id);
            return Ok();
        }
    }
}
