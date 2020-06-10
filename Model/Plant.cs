using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Plant
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Environment> Environments { get; set; }
    }
}
