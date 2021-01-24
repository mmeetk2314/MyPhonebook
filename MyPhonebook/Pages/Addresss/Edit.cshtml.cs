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

namespace MyPhonebook.Pages.Addresss
{
    public class EditModel : PageModel
    {
        private readonly MyPhonebook.Data.MyPhonebookContext _context;

        public EditModel(MyPhonebook.Data.MyPhonebookContext context)
        {
            _context = context;
        }

        [BindProperty]
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

            _context.Attach(Address).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AddressExists(Address.AddrId))
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

        private bool AddressExists(int id)
        {
            return _context.Address.Any(e => e.AddrId == id);
        }
    }
}
