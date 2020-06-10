using System;
using System.Collections.Generic;
using System.Text;

namespace Model.DTOs
{
    public class AssignInventoryDTO
    {
        public InventoryDTO Inventory { get; set; }
        public RoomDTO Room { get; set; }
    }
}
