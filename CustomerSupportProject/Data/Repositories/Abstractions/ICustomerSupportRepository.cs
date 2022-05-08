using CustomerSupportApi.Data.Entities;
using System;
using System.Threading.Tasks;

namespace CustomerSupportApi.Data.Repositories.Abstractions
{
    public interface ICustomerSupportRepository
    {
        Task<Guid> SaveForm(CustomerSupportForm customerSupportForm);
    }
}
