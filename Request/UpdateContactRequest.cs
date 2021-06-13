using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Request
{
    public class UpdateContactRequest
    {
        [Required]
        public int Contactid { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Range(10, int.MaxValue, ErrorMessage = "Phone Number should be 10 always")]
        public int PhoneNumber { get; set; }
        [Required]
        public string PhoneStatus { get; set; }
    }
}
