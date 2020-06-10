using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Room
    {
        public int Id { get; set; }
        public int Capacity { get; set; }

        public Environment Environment { get; set; }
        public ICollection<Inventory> Inventories { get; set; }
    }
}
