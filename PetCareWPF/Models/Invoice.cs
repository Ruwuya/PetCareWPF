using PetCareWPF.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCareWPF.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int AppointmentId { get; set; }
        public decimal TotalPrice { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
        public DateOnly IssueDate { get; set; }
        public DateOnly DueDate { get; set; }
    }
}
