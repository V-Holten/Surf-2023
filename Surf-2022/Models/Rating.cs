using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Surf_2022.Models
{
	public class Rating
	{
		public int RatingId { get; set; }
		[Required]
		public float Value { get; set; }

	}
}
