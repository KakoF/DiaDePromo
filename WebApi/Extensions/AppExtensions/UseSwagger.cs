namespace WebApi.Extensions.AppExtensions
{
	public static class UseSwagger
	{
		public static void AddSwagger(this WebApplication app)
		{
			app.UseSwagger();
			app.UseSwaggerUI();
		}
	}
}
