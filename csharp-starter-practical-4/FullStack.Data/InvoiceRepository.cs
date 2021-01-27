using FullStack.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace FullStack.Data
{
    public interface IInvoiceRepository
    {
        Invoice GetInvoice(string ReferenceNumber);
        List<Invoice> GetInvoices();
        Invoice CreateInvoice(Invoice invoice);
        Invoice UpdateInvoice(Invoice invoice);
        void DeteleInvoice(string ReferenceNumber);
        List<InvoiceItem> GetInvoiceItems();
    }

    public class InvoiceReposiory : IInvoiceRepository
    {
        private FullStackDbContext _ctx;
        public InvoiceReposiory(FullStackDbContext ctx)
        {
            _ctx = ctx;
        }

        public List<Invoice> GetInvoices()
        {
            return _ctx.Invoices.ToList();

        }
        public Invoice GetInvoice(string ReferenceNumber)
        {
            return _ctx.Invoices.Find(ReferenceNumber);
        }

        public Invoice CreateInvoice(Invoice invoice)
        {
            _ctx.Invoices.Add(invoice);
            _ctx.SaveChanges();
            return invoice;
        }

        public Invoice UpdateInvoice(Invoice invoice)
        {
            var existing = _ctx.Invoices.SingleOrDefault(em => em.ReferenceNumber == invoice.ReferenceNumber);
            if (existing == null) return null;

            _ctx.Entry(existing).State = EntityState.Detached;
            _ctx.Invoices.Attach(invoice);
            _ctx.Entry(invoice).State = EntityState.Modified;
            _ctx.SaveChanges();
            return invoice;
        }

        public void DeteleInvoice(string ReferenceNumber)
        {
            var entity = _ctx.Invoices.Find(ReferenceNumber);
            _ctx.Invoices.Remove(entity);
            _ctx.SaveChanges();
        }

        public List<InvoiceItem> GetInvoiceItems()
        {
            return _ctx.InvoiceItems.ToList();
        }

    }
}
