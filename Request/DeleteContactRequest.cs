using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Request
{
    public class DeleteContactRequest
    {
        [Required]
        public int Contactid { get; set; }
        [Required]
        public string PhoneStatus { get; set; }
    }
}
