using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyPhoneBook.Model;
using MyPhonebook.Data;

namespace MyPhonebook.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly MyPhonebook.Data.MyPhonebookContext _context;

        public IndexModel(MyPhonebook.Data.MyPhonebookContext context)
        {
            _context = context;
        }

        public IList<User> User { get;set; }

        public async Task OnGetAsync()
        {
            User = await _context.User.ToListAsync();
        }
    }
}
