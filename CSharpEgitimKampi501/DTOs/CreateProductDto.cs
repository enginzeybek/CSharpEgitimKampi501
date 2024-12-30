﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi501.DTOs
{
	public class CreateProductDto
	{
		public string ProductName { get; set; }

		public int ProductStock { get; set; }

		public decimal ProductPrice { get; set; }

		public string ProductCategory { get; set; }
	}
}
