using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyPhonebook.Data;
using MyPhonebook.Models;

namespace MyPhonebook.Pages.Phones
{
    public class DetailsModel : PageModel
    {
        private readonly MyPhonebook.Data.MyPhonebookContext _context;

        public DetailsModel(MyPhonebook.Data.MyPhonebookContext context)
        {
            _context = context;
        }

        public Phone Phone { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Phone = await _context.Phone
                .Include(p => p.Users).FirstOrDefaultAsync(m => m.PhoneId == id);

            if (Phone == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
