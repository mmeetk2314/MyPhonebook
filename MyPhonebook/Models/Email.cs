using MyPhoneBook.Model;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyPhonebook.Models
{

    // creating separate entity for email
    public class Email
    {

        [Key]
        public int EmailID { get; set; }
        public string ElectonicMail { get; set; }
        public bool isActive { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        public User Users { get; set; }

    }
}