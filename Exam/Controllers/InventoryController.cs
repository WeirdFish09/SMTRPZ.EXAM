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
    public class InventoryController : ControllerBase
    {
        private IInventoryService _inventoryService;

        public InventoryController(IInventoryService inventoryService)
        {
            _inventoryService = inventoryService;
        }
        [HttpGet("filtered")]
        public IEnumerable<InventoryDTO> FindByFilter([FromQuery]InventoryFilter filter)
        {
            return _inventoryService.FindByFilter(filter);
        }
        [HttpPost("add")]
        public InventoryDTO AddInvenotry([FromBody]InventoryDTO inventory)
        {
            return _inventoryService.AddInvenotry(inventory);
        }
        [HttpPost("remove")]
        public void RemoveInventory([FromBody]InventoryDTO inventory)
        {
            _inventoryService.RemoveInventory(inventory);
        }
        [HttpPost("assign")]
        public bool AssignInventory([FromBody]AssignInventoryDTO assignInventoryDTO)
        {
            return _inventoryService.AssignInventory(assignInventoryDTO);
        }
        [HttpPost("unassign")]
        public bool UnAssignInventory([FromBody]AssignInventoryDTO assignInventoryDTO)
        {
            return _inventoryService.UnAssignInventory(assignInventoryDTO);
        }
    }
}