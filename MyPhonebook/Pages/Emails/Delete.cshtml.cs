using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyPhonebook.Data;
using MyPhonebook.Models;

namespace MyPhonebook.Pages.Emails
{
    public class DeleteModel : PageModel
    {
        private readonly MyPhonebook.Data.MyPhonebookContext _context;

        public DeleteModel(MyPhonebook.Data.MyPhonebookContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Email Email { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Email = await _context.Email
                .Include(e => e.Users).FirstOrDefaultAsync(m => m.EmailID == id);

            if (Email == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Email = await _context.Email.FindAsync(id);

            if (Email != null)
            {
                _context.Email.Remove(Email);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
