using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FullStack.Data.Entities
{
    public class InvoiceItem
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Rate { get; set; }
        public decimal Hours { get; set; }
      
    }
}
