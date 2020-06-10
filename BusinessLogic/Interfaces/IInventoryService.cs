using Model.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Interfaces
{
    public interface IInventoryService
    {
        IEnumerable<InventoryDTO> FindByFilter(InventoryFilter filter);
        InventoryDTO AddInvenotry(InventoryDTO inventory);
        void RemoveInventory(InventoryDTO inventory);
        bool AssignInventory(AssignInventoryDTO assignInventoryDTO);
        bool UnAssignInventory(AssignInventoryDTO assignInventoryDTO);
    }
}
