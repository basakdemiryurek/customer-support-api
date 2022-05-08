using CustomerSupportApi.Models;
using CustomerSupportApi.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;
using System.Threading.Tasks;

namespace CustomerSupportApi.Controllers
{
    [ApiController]
    [Route("v1/[controller]")]
    public class CustomerSupportController : ControllerBase
    {
        private readonly ICustomerSupportService _customerSupportService;
        public CustomerSupportController(ICustomerSupportService customerSupportService)
        {
            _customerSupportService = customerSupportService;
        }
        
        [SwaggerResponse((int)HttpStatusCode.Created, Type = typeof(CreateCustomerSupportFormResponse))]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Description = "Request not accepted.")]
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateCustomerSupportFormRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var response = await _customerSupportService.Create(request);

            if (!response.IsSucceed)
            {
                return BadRequest(response);
            }

            return Created("", response);
        }
    }
}
