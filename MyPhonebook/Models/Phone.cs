using MyPhoneBook.Model;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyPhonebook.Models
{
    public class Phone
    {

        // creating separte entity for phone
       
        
            [Key] // PK creating
            public int PhoneId { get; set; }
            // land line  number
            public string LandLineNumber { get; set; }
            // mobile no
            public string MobileNumber { get; set; }
            // whatsapp on mobile active or not
            public bool isUsingWhatsApp { get; set; }

            [ForeignKey("User")]
            public int UserId { get; set; }
            public User Users { get; set; }
        }
    }
