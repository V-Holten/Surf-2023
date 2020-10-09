using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Surf_2022.Models
{
    public class Surfspots
    {
		public int Id { get; set; }
		public string Name { get; set; }
        public float Lattitude { get; set; }
        public float Longtitude { get; set; }
    }
}