﻿using CSharpEgitimKampi501.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi501.Repositories
{
	public interface IProductRepository
	{
		Task<List<ResultProductDto>> GetAllProductsAsync();

		Task CreateProductAsync(CreateProductDto createProductDto);

		Task UpdateProductAsync(UpdateProductDto updateProductDto);

		Task DeleteProductAsync(int id);

		Task GetByProductIdAsync(int id);
	}
}
