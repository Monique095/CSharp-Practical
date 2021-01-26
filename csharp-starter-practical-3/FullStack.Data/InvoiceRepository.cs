using FullStack.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace FullStack.Data
{
    public interface IInvoiceRepository
    {
        Invoice GetInvoice(int Id);
        List<Invoice> GetInvoices();
        Invoice CreateInvoice(Invoice invoice);
        Invoice UpdateInvoice(Invoice invoice);
        void DeteleInvoice(int Id);
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
        public Invoice GetInvoice(int Id)
        {
            return _ctx.Invoices.Find(Id);
        }

        public Invoice CreateInvoice(Invoice invoice)
        {
            _ctx.Invoices.Add(invoice);
            _ctx.SaveChanges();
            return invoice;
        }

        public Invoice UpdateInvoice(Invoice invoice)
        {
            var existing = _ctx.Invoices.SingleOrDefault(em => em.Id == invoice.Id);
            if (existing == null) return null;

            _ctx.Entry(existing).State = EntityState.Detached;
            _ctx.Invoices.Attach(invoice);
            _ctx.Entry(invoice).State = EntityState.Modified;
            _ctx.SaveChanges();
            return invoice;
        }

        public void DeteleInvoice(int Id)
        {
            var entity = _ctx.Invoices.Find(Id);
            _ctx.Invoices.Remove(entity);
            _ctx.SaveChanges();
        }

        public List<InvoiceItem> GetInvoiceItems()
        {
            return _ctx.InvoiceItems.ToList();
        }

    }
}
