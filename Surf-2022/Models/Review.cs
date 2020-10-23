using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Surf_2022.Models
{
	public class Review
	{
		public int ReviewId { get; set; }
		[Required]
		public string UserName { get; set; }
		[Required]
		public string Text { get; set; }
		[Required]
		public DateTime CreateDate { get; set; }
	}
}
