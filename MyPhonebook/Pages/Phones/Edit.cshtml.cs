using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyPhonebook.Data;
using MyPhonebook.Models;

namespace MyPhonebook.Pages.Phones
{
    public class EditModel : PageModel
    {
        private readonly MyPhonebook.Data.MyPhonebookContext _context;

        public EditModel(MyPhonebook.Data.MyPhonebookContext context)
        {
            _context = context;
        }

        [BindProperty]
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
           ViewData["UserId"] = new SelectList(_context.User, "UserId", "UserId");
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

            _context.Attach(Phone).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PhoneExists(Phone.PhoneId))
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

        private bool PhoneExists(int id)
        {
            return _context.Phone.Any(e => e.PhoneId == id);
        }
    }
}
