namespace Domain.Entities
{
	public class City
	{
		public long Id { get; set; }
		public string Name { get; set; } = null!;
		public bool Active { get; set; }
	}
}
