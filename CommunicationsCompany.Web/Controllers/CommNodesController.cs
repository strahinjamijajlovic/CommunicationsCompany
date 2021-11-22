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
    public class CommNodesController : Controller
    {
        private readonly ICommNodeRepository _commNodeRepo;
        private readonly IMainHubRepository _mainHubRepo;
        private readonly IMapper _mapper;
        private readonly ILogger<CommNodesController> _logger;

        public CommNodesController(ICommNodeRepository commNodeRepo, 
            IMainHubRepository mainHubRepo, 
            IMapper mapper,
            ILogger<CommNodesController> logger)
        {
            _commNodeRepo = commNodeRepo;
            _mainHubRepo = mainHubRepo;
            _mapper = mapper;
            _logger = logger;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(long id)
        {
            var entity = await _commNodeRepo.Find(id);
            if (entity is null)
                NotFound();

            var vm = _mapper.Map<CommNodeViewModel>(entity);

            return Ok(vm);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CommNodeViewModel vm)
        {
            if (ModelState.IsValid)
            {
                var entity = _mapper.Map<CommNode>(vm);

                //logic for chosing a Main Hub for this Comm Node goes here
                //you can allow the user to chose the main hub from the frontend or through the API and submit the id in the ViewModel
                //or create logic for choosing one here, or do either
                //maybe make separate calls for that, depends what you want, but definitely wouldn't leave it like this
                if (entity.MainHub is null)               
                    entity.MainHub = await _mainHubRepo.Find(1);

                //this is also not perfect, in case this fails we still return Ok which means either this method should return the id(or null if failed) and than handle it here 
                //or we can do the error handling here and not in the repo. Also if we do it in the repo, logging would be nice, but that's all besides the point
                await _commNodeRepo.Add(entity); 

                return Ok();
            }

            return BadRequest();
        }

        [HttpPost]
        public async Task<IActionResult> Update(CommNodeViewModel vm)
        {
            if (ModelState.IsValid)
            {
                var entity = await _commNodeRepo.Find(vm.Id);
                if (entity is null)
                    return NotFound();

                _mapper.Map(vm, entity);

                await _commNodeRepo.Update(entity);

                return Ok();
            }

            return BadRequest();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            await _commNodeRepo.Remove(id);
            return Ok();
        }
    }
}
