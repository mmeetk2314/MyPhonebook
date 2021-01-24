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
    public class IndexModel : PageModel
    {
        private readonly MyPhonebook.Data.MyPhonebookContext _context;

        public IndexModel(MyPhonebook.Data.MyPhonebookContext context)
        {
            _context = context;
        }

        public IList<Address> Address { get;set; }

        public async Task OnGetAsync()
        {
            Address = await _context.Address
                .Include(a => a.Users).ToListAsync();
        }
    }
}
