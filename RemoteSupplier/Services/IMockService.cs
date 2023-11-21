namespace RemoteSupplier.Services;

public interface IMockService<T>
{
	T NewMock();
}