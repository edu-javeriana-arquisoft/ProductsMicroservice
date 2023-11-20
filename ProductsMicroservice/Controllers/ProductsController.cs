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
}