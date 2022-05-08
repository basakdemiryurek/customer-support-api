using System.ComponentModel.DataAnnotations;

namespace CustomerSupportApi.Models
{
    public class CreateCustomerSupportFormRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [Phone]
        public string Phone { get; set; }
        public int CustomerNumber { get; set; }
        [Required]
        public int InquiryType { get; set; }
        [Required]
        public string Description { get; set; }
    }
}
