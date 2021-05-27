using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Attendance_System.ViewModels
{
    public class CreateEmployeeCredantialsVM
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [MaxLength(10)]
        public string RandomName { get; set; }

        [Required]
        [MaxLength(6)]
        public int randomPassword { get; set; }
    }
}
