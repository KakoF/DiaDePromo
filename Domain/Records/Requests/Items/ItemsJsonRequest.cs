using Domain.Enums;

namespace Domain.Records.Requests.Items
{
	public record ItemsJsonRequest(string Name, string? Description, EItemType Type, decimal Price, DateTime? ExpirationDate);
}
