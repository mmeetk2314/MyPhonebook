using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyPhoneBook.Model;
using MyPhonebook.Models;

namespace MyPhonebook.Data
{
    public class MyPhonebookContext : DbContext
    {
        public MyPhonebookContext (DbContextOptions<MyPhonebookContext> options)
            : base(options)
        {
        }

        public DbSet<MyPhoneBook.Model.User> User { get; set; }

        public DbSet<MyPhonebook.Models.Phone> Phone { get; set; }

        public DbSet<MyPhonebook.Models.Address> Address { get; set; }

        public DbSet<MyPhonebook.Models.Email> Email { get; set; }
    }
}
