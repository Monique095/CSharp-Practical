using System;
using System.Collections.Generic;

namespace FullStack.ViewModels
{
    public class InvoiceModel
    {
        public int Id { get; set; }
        public string ReferenceNumber { get; set; }
        public DateTime Date { get; set; }
        public DateTime DueDate { get; set; }
        public decimal TotalAmount { get; set; }
        public List<InvoiceItemModel> InvoiceItems { get; set; }
    }
}
