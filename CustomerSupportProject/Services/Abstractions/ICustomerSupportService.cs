using CustomerSupportApi.Models;
using System.Threading.Tasks;

namespace CustomerSupportApi.Services.Abstractions
{
    public interface ICustomerSupportService
    {
        public Task<BaseResponse<CreateCustomerSupportFormResponse>> Create(CreateCustomerSupportFormRequest request);
    }
}
