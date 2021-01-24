using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyPhonebook.Data;
using MyPhonebook.Models;

namespace MyPhonebook.Pages.Emails
{
    public class CreateModel : PageModel
    {
        private readonly MyPhonebook.Data.MyPhonebookContext _context;

        public CreateModel(MyPhonebook.Data.MyPhonebookContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["UserId"] = new SelectList(_context.User, "UserId", "UserId");
            return Page();
        }

        [BindProperty]
        public Email Email { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Email.Add(Email);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
