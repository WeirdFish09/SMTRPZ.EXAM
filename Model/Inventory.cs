using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Inventory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Volume { get; set; }

        public Room Room { get; set; }
    }
}
