using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TYMF.Data;
using TYMF.Models;

namespace TYMF.Pages.Invoice
{
    public class EditModel : PageModel
    {
        private readonly TYMF.Data.TYMFContext _context;

        public EditModel(TYMF.Data.TYMFContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Invoioce Invoioce { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Invoioce = await _context.Invoioce.FirstOrDefaultAsync(m => m.ID == id);

            if (Invoioce == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Invoioce).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InvoioceExists(Invoioce.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool InvoioceExists(int id)
        {
            return _context.Invoioce.Any(e => e.ID == id);
        }
    }
}
