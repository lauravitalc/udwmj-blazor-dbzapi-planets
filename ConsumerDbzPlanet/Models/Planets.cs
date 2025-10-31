using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsumerDbzPlanet.Models
{
    public class Planets
    {
        public List<Item> items { get; set; }
        public Meta meta { get; set; }
        public Links links { get; set; }
    }
}