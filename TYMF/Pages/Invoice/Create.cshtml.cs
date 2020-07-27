using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using TYMF.Data;
using TYMF.Models;

namespace TYMF.Pages.Invoice
{
    public class CreateModel : PageModel
    {
        private readonly TYMF.Data.TYMFContext _context;

        public CreateModel(TYMF.Data.TYMFContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Invoioce Invoioce { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Invoioce.Add(Invoioce);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
