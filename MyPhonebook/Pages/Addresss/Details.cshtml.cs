using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyPhonebook.Data;
using MyPhonebook.Models;

namespace MyPhonebook.Pages.Addresss
{
    public class DetailsModel : PageModel
    {
        private readonly MyPhonebook.Data.MyPhonebookContext _context;

        public DetailsModel(MyPhonebook.Data.MyPhonebookContext context)
        {
            _context = context;
        }

        public Address Address { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Address = await _context.Address
                .Include(a => a.Users).FirstOrDefaultAsync(m => m.AddrId == id);

            if (Address == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
