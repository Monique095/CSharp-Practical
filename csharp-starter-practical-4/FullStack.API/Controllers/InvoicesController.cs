using FullStack.Data;
using FullStack.Data.Entities;
using FullStack.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FullStack.API.Controllers
{
    [Route("api/Invoices")]
    [ApiController]
    public class InvoicesController : ControllerBase
    {
        private readonly FullStackDbContext _context;

        public InvoicesController(FullStackDbContext context)
        {
            _context = context;
        }

        // GET: api/Invoices
        [HttpGet]
        public async Task <ActionResult<IEnumerable<InvoiceModel>>> GetInvoices()
        {
            
            IList<Invoice> invoice = null;
            invoice = await _context.Invoices.Include(c => c.InvoiceItems)
                .Select(c => new Invoice()
                {
                    Id = c.Id,
                    Date = c.Date,
                    DueDate = c.DueDate,
                    ReferenceNumber = c.ReferenceNumber,
                    TotalAmount = c.TotalAmount,
                    InvoiceItems = c.InvoiceItems,
                    

                }).ToListAsync<Invoice>();
                return Ok(invoice);
   
        }

        // GET: api/Invoices/5
        [HttpGet("{id}")]
        public async Task <ActionResult<InvoiceModel>> GetInvoice(int id)
        {

            Invoice invoice = await _context.Invoices.Include(e => e.InvoiceItems).FirstOrDefaultAsync(e => e.Id == id);

            if (invoice == null)
            {
                return NotFound();
            }

            return Ok(invoice);
        }


        // PUT: api/Invoices/5
        [HttpPut("{id}")]
        public async Task<ActionResult<InvoiceModel>> PutInvoice(int id, Invoice invoice)
        {
            if (id != invoice.Id)
            {
                return BadRequest();
            }
            _context.Invoices.Update(invoice);
            await _context.SaveChangesAsync();
            _context.Entry(invoice).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InvoiceExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return Ok(invoice);
        }

        // POST: api/Invoices
        [HttpPost]
        public async Task <ActionResult<InvoiceModel>> PostInvoice(Invoice invoice)
        {
      
            if (invoice == null)
            {
                return NotFound();
            }

            _context.Invoices.Add(invoice);
            await _context.SaveChangesAsync();
            return Ok(invoice);
        }

       // DELETE: api/Invoices/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<InvoiceModel>> DeleteInvoice(int id)
        {

            var invoice = await _context.Invoices.Include(c => c.InvoiceItems).SingleOrDefaultAsync(e => e.Id == id);
    

            if (invoice == null)
            {
                return Ok("No ID Found");
            }

            _context.Invoices.Remove(invoice);
            await _context.SaveChangesAsync();
            return Ok("Record has successfully been Deleted");

        }
 
        private bool InvoiceExists(int id)
        {
            return _context.Invoices.Include(e => e.InvoiceItems).Any(e => e.Id == id);
        }
    }
}
