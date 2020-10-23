using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Surf_2022.Models
{
    public class Surfspots
    {
		public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public decimal Lattitude { get; set; }
        [Required]
        public decimal Longtitude { get; set; }
    }
}