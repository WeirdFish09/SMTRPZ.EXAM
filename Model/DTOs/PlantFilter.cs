using System;
using System.Collections.Generic;
using System.Text;

namespace Model.DTOs
{
    public class PlantFilter
    {
        public string Name { get; set; }
        public int EnvironmentId { get; set; }
        public int RoomId { get; set; }
    }
}
