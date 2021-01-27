using FullStack.Data.Entities;
using System;
using System.Collections.Generic;

namespace FullStack.ViewModels
{
    public class InvoiceModel
    {
        public Invoice invoices { get; set; }
        public List<InvoiceItem> invoiceItem { get; set; }

    }
}
