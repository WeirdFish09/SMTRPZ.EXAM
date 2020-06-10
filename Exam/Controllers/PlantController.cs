using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLogic.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model.DTOs;

namespace Exam.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlantController : ControllerBase
    {
        private IPlantService _plantService;

        public PlantController(IPlantService plantService)
        {
            _plantService = plantService;
        }

        [HttpGet("filtered")]
        public IEnumerable<PlantDTO> FindByFilter([FromQuery]PlantFilter filter)
        {
            return _plantService.FindByFilter(filter);
        }
        [HttpPost("add")]
        public PlantDTO AddPlant([FromBody]PlantDTO plant)
        {
            return _plantService.AddPlant(plant);
        }
        [HttpPost("remove")]
        public void RemovePlant([FromBody]PlantDTO plant)
        {
            _plantService.RemovePlant(plant);
        }
        [HttpPost("assign")]
        public bool AssignPlant([FromBody]AssignPlantDTO assignPlantDTO)
        {
            return _plantService.AssignPlant(assignPlantDTO);
        }
        [HttpPost("unassign")]
        public bool UnAssignPlant([FromBody]AssignPlantDTO assignPlantDTO)
        {
            return _plantService.UnAssignPlant(assignPlantDTO);
        }
    }
}