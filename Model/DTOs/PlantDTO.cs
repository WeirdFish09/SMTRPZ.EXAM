using System;
using System.Collections.Generic;
using System.Text;

namespace Model.DTOs
{
    public class PlantDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public IEnumerable<EnvironmentDTO> Environments { get; set; }
    }
}
