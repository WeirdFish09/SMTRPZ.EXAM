using System;
using System.Collections.Generic;
using System.Text;

namespace Model.DTOs
{
    public class AssignPlantDTO
    {
        public PlantDTO Plant { get; set; }
        public RoomDTO Room { get; set; }
    }
}
