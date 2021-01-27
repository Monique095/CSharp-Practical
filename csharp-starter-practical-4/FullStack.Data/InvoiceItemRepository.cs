using FullStack.Data.Entities;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace FullStack.Data
{
    public interface IInvInvoiceItemRepository
    {
        InvoiceItem GetInvoiceItem(int Id);
        List<InvoiceItem> GetInvoiceItems();
        InvoiceItem CreateInvoiceItem(InvoiceItem invoiceItem);
        InvoiceItem UpdateInvoice(InvoiceItem invoiceItem);
        void DeteleInvoice(string Id);
    }

    public class InvoiceItemRepository : IInvInvoiceItemRepository
    {
        private FullStackDbContext _ctx;
        public InvoiceItemRepository(FullStackDbContext ctx)
        {
            _ctx = ctx;
        }

        public List<InvoiceItem> GetInvoiceItems()
        {
            return _ctx.InvoiceItems.ToList();
        }

        public InvoiceItem GetInvoiceItem(int Id)
        {
            return _ctx.InvoiceItems.Find(Id);
        }

        public InvoiceItem CreateInvoiceItem(InvoiceItem invoiceItem)
        {
            _ctx.InvoiceItems.Add(invoiceItem);
            _ctx.SaveChanges();
            return invoiceItem;
        }

        public InvoiceItem UpdateInvoice(InvoiceItem invoiceItem)
        {
            var existing = _ctx.InvoiceItems.SingleOrDefault(em => em.Id == invoiceItem.Id);
            if (existing == null) return null;

            _ctx.Entry(existing).State = EntityState.Detached;
            _ctx.InvoiceItems.Attach(invoiceItem);
            _ctx.Entry(invoiceItem).State = EntityState.Modified;
            _ctx.SaveChanges();
            return invoiceItem;
        }

        public void DeteleInvoice(string Id)
        {
            var entity = _ctx.InvoiceItems.Find(Id);
            _ctx.InvoiceItems.Remove(entity);
            _ctx.SaveChanges();
        }


    }
}
