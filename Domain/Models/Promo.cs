namespace Domain.Models
{
	public sealed class Promo
	{
		public Guid Id { get; private set; }
		public DateTime CratedAt { get; private set; }

		private Promo(Guid id, DateTime cratedAt)
		{
			Id = id;
			CratedAt = cratedAt;
		}

		public static Promo Create()
		{
			return new Promo(Guid.NewGuid(), DateTime.Now);
		}
	}
}
