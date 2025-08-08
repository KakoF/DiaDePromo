namespace WebApi.Extensions.BuilderExtensions
{
	public static class SwaggerExtensions
	{
		public static void AddSwagger(this IServiceCollection services)
		{
			services.AddEndpointsApiExplorer();
			services.AddSwaggerGen();

		}
	}
}
