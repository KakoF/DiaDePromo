namespace Domain.Interfaces.Infrastructure
{
	public interface IStorage
	{
		public Task StoragePDFAsync(Stream file, string name);
	}
}
