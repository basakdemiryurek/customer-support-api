using System;

namespace CustomerSupportApi.Data.Entities
{
    public class CustomerSupportForm
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int CustomerNumber { get; set; }
        public int InquiryType { get; set; }
        public string Description { get; set; }
    }
}
