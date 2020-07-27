using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TYMF.Data;
using TYMF.Models;

namespace TYMF.Pages.Invoice
{
    public class IndexModel : PageModel
    {
        private readonly TYMF.Data.TYMFContext _context;

        public IndexModel(TYMF.Data.TYMFContext context)
        {
            _context = context;
        }

        public IList<Invoioce> Invoioce { get;set; }

        public async Task OnGetAsync()
        {
            Invoioce = await _context.Invoioce.ToListAsync();
        }
    }
}
