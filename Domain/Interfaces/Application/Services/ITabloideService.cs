using Domain.Records.Requests;
using Domain.Records.Responses;

namespace Domain.Interfaces.Application.Services
{
    public interface ITabloideService
    {
		Task<TabloidCreateResponse> CreateAsync(TabloideRequest request);
    }
}
