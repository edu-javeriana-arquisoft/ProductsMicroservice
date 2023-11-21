using ProductsMicroservice.Remote;

namespace ProductsMicroservice.Services;

public class SuppliersService
{
	public readonly List<RemoteSupplierConnection> Suppliers;

	public SuppliersService(
		IConfiguration configuration,
		ILogger<SuppliersService> logger)
	{
		var suppliersUrl = configuration["SuppliersRemote"]!;
		logger.LogInformation($"Fetching for suppliers {suppliersUrl}");

		// Fetch content from remote suppliers
		Suppliers = suppliersUrl.Split(';').Select(e =>
		{
			logger.LogInformation($"Creating url for: {e}");
			return new RemoteSupplierConnection(e);
		}).ToList();
	}
}