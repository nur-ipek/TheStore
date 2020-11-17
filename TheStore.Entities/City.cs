using System;
using System.Collections.Generic;
using System.Text;

namespace TheStore.Entities
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Town Town { get; set; }
        public int TownId { get; set; }

        public Customer Customer { get; set; }
    }
}
