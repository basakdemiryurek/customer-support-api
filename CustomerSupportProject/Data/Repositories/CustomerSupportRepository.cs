using CustomerSupportApi.Data.Entities;
using CustomerSupportApi.Data.Repositories.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerSupportApi.Data.Repositories
{
    public class CustomerSupportRepository : ICustomerSupportRepository
    {
        public List<CustomerSupportForm> customerSupportForms;
        public CustomerSupportRepository()
        {
            customerSupportForms = new List<CustomerSupportForm>();
        }

        public async Task<Guid> SaveForm(CustomerSupportForm customerSupportForm)
        {
            customerSupportForm.Id = Guid.NewGuid();

            customerSupportForms.Add(customerSupportForm);

            return customerSupportForm.Id;
        }
    }
}
