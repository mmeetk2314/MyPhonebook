using MyPhonebook.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyPhoneBook.Model
{
    // user entity
    public class User
    {
        // User key
        [Key]
        public int UserId { get; set; }
        // name prop
        public string Name { get; set; }

        // list of address, phones and emails
        public List<Address> Addresses { get; set; }
        public string Emails { get; set; }
        public string Phones { get; set; }

        // ctor for foregin relation
        public User()
        {
            Addresses = new List<Address>();
            
        }

    }
}
