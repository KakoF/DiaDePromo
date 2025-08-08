using Domain.Records.Requests;

namespace Domain.Interfaces.Services
{
    public interface ITabloideService
    {
		Task ConvertPDFAsync(TabloideRequest request);
    }
}
