using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FullStack.Data.Entities
{
    public class Invoice
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string ReferenceNumber { get; set; }
        public DateTime DueDate { get; set; }
        public decimal TotalAmount { get; set; }
        public List<InvoiceItem> InvoiceItems { get; set; }
    }
 

}
