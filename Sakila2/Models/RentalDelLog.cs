using System;
using System.Collections.Generic;

namespace Sakila2.Models
{
    public partial class RentalDelLog
    {
        public int LogId { get; set; }
        public int? RentalId { get; set; }
        public DateTime? RentalDate { get; set; }
        public int? InventoryId { get; set; }
        public int? CustomerId { get; set; }
        public DateTime? ReturnDate { get; set; }
        public byte? StaffId { get; set; }
        public DateTime? DeletedOn { get; set; }
        public string DeletedBy { get; set; }
    }
}
