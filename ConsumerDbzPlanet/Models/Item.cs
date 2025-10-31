using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsumerDbzPlanet.Models
{
    public class Item
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool isDestroyed { get; set; }
        public string description { get; set; }
        public string image { get; set; }
        public object deletedAt { get; set; }
    }
}