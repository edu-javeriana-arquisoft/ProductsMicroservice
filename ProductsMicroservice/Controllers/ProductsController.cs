using Arquisoft.Remote;
using Microsoft.AspNetCore.Mvc;
using ProductsMicroservice.Services;

namespace ProductsMicroservice.Controllers;

[ApiController, Route("[controller]")]
public class ProductsController : ControllerBase
{
	private readonly IDatabaseService _database;
	public ProductsController(IDatabaseService database)
	{
		_database = database;
	}

	[HttpGet("[action]")]
	public List<Product> GetAllProducts()
	{
		return _database.GetAllProducts();
	}

	[HttpGet("[action]/{category}")]
	public List<Product> GetProductsByCategory(string category)
	{
		return _database.GetProductsByCategory(category);
	}

	[HttpGet("[action]/{vendor}")]
	public List<Product> GetProductsByVendor(string vendor)
	{
		return _database.GetProductsByVendor(vendor);
	}

	[HttpPost("[action]/{supplier}/{id}")]
	public bool BuyProduct(string supplier, int id)
	{
		return _database.BuyProduct(Guid.Parse(supplier), id);
	}

}