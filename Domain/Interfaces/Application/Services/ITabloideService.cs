using Domain.Records.Requests.Tabloid;
using Domain.Records.Responses;

namespace Domain.Interfaces.Application.Services
{
    public interface ITabloideService
    {
		Task<TabloidCreateResponse> CreateAsync(TabloidFileRequest request);
		Task<TabloidCreateResponse> CreateAsync(TabloidJsonRequest request);
    }
}
