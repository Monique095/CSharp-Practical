using System;

namespace FullStack.ViewModels
{
    public class InvoiceItemModel
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Rate { get; set; }
        public decimal Hours { get; set; }
        public decimal ItemTotalAmount { get; }
    }
}
