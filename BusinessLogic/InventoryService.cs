using BusinessLogic.Interfaces;
using DataAccess.Interfaces;
using Model.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    public class InventoryService : IInventoryService
    {
        private IInventoryRepository _inventoryRepository;
        private IRoomRepository _roomRepository;

        public InventoryService(IInventoryRepository inventoryRepository, IRoomRepository roomRepository)
        {
            _inventoryRepository = inventoryRepository;
            _roomRepository = roomRepository;
        }

        public InventoryDTO AddInvenotry(InventoryDTO inventory)
        {
            throw new NotImplementedException();
        }

        public bool AssignInventory(AssignInventoryDTO assignInventoryDTO)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<InventoryDTO> FindByFilter(InventoryFilter filter)
        {
            throw new NotImplementedException();
        }

        public void RemoveInventory(InventoryDTO inventory)
        {
            throw new NotImplementedException();
        }

        public bool UnAssignInventory(AssignInventoryDTO assignInventoryDTO)
        {
            throw new NotImplementedException();
        }
    }
}
