namespace RemoteSupplier.Services;

public class ProductService : Arquisoft.Remote.ProductService.ProductServiceBase
{
	private readonly ILogger<ProductService> _logger;
	public ProductService(ILogger<ProductService> logger)
	{
		_logger = logger;
	}
}
