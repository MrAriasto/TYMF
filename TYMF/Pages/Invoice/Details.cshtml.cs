﻿using System;
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
    public class DetailsModel : PageModel
    {
        private readonly TYMF.Data.TYMFContext _context;

        public DetailsModel(TYMF.Data.TYMFContext context)
        {
            _context = context;
        }

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
    }
}
