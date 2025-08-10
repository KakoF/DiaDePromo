using Domain.Enums;

namespace Domain.Records.Requests.Items
{
	public record ItemsRequest(string Name, string? Description, EItemType Type, decimal Price, DateTime? ExpirationDate);
}
