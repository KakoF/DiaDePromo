namespace WebApi.Extensions.AppExtensions
{
	public static class UseSwaggerExtensions
	{
		public static void AddSwagger(this WebApplication app)
		{
			app.UseSwagger();
			app.UseSwaggerUI();
		}
	}
}
