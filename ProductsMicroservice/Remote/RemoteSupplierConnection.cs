using Grpc.Net.Client;

namespace ProductsMicroservice.Remote;

public class RemoteSupplierConnection : IDisposable
{
	public readonly string ConnectionString;
	private readonly GrpcChannel _channel;
	public readonly Arquisoft.Remote.ProductService.ProductServiceClient Client;

	public RemoteSupplierConnection(string connectionString)
	{
		ConnectionString = connectionString;
		_channel = GrpcChannel.ForAddress(connectionString);
		Client = new Arquisoft.Remote.ProductService.ProductServiceClient(_channel);
	}

	protected void Dispose(bool disposing)
	{
		if (disposing)
		{
			_channel.Dispose();
		}
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}
}