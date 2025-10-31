using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsumerDbzPlanet.Models
{
    public class Meta
    {
        public int totalItems { get; set; }
        public int itemCount { get; set; }
        public int itemsPerPage { get; set; }
        public int totalPages { get; set; }
        public int currentPage { get; set; }
    }
}