using System;
using System.Collections.Generic;

namespace Sakila2.Models
{
    public partial class CustomerAuditLog
    {
        public int CustomerAuditId { get; set; }
        public int? CustomerId { get; set; }
        public int? StoreId { get; set; }
        public int? StoreIdOld { get; set; }
        public string FirstName { get; set; }
        public string FirstNameOld { get; set; }
        public string LastName { get; set; }
        public string LastNameOld { get; set; }
        public string Email { get; set; }
        public string EmailOld { get; set; }
        public string Active { get; set; }
        public string ActiveOld { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }
    }
}
