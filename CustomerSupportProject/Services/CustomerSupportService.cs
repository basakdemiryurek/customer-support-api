using AutoMapper;
using CustomerSupportApi.Data.Entities;
using CustomerSupportApi.Data.Repositories.Abstractions;
using CustomerSupportApi.Infrastructure.Constant;
using CustomerSupportApi.Models;
using CustomerSupportApi.Services.Abstractions;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace CustomerSupportApi.Services
{
    public class CustomerSupportService : ICustomerSupportService
    {
        private readonly ICustomerSupportRepository _customerSupportRepository;
        private readonly ILogger<CustomerSupportService> _logger;
        private readonly IMapper _mapper;
        public CustomerSupportService(
            ICustomerSupportRepository customerSupportRepository, 
            ILogger<CustomerSupportService> logger, 
            IMapper mapper)
        {
            _customerSupportRepository = customerSupportRepository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<BaseResponse<CreateCustomerSupportFormResponse>> Create(CreateCustomerSupportFormRequest request)
        {
            var response = new BaseResponse<CreateCustomerSupportFormResponse>();

            try
            {
                var form = _mapper.Map<CreateCustomerSupportFormRequest, CustomerSupportForm>(request);
                var formId = await _customerSupportRepository.SaveForm(form);

                if (formId != Guid.Empty)
                    response.Result.FormId = formId;
                else
                    response.SetError(ErrorMessages.SaveFormFailed);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, null);
                response.SetError(ErrorMessages.SaveFormFailed);
            }

            return response;
        }
    }
}
