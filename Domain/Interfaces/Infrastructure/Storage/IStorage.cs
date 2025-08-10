namespace Domain.Interfaces.Infrastructure
{
	public interface IStorage
	{
		Task StoragePDFAsync(Stream? file, string name);
	}
}
