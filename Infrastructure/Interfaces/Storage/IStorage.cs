namespace Infrastructure.Interfaces.Storage
{
	public interface IStorage
	{
		Task StoragePDFAsync(Stream? file, string name);
	}
}
