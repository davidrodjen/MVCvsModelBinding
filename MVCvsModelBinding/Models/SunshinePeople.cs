using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCvsModelBinding.Models
{
    public class SunshinePeople
    {

        public int SunshineNum { get; set; }

        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Full Name is required")]
        public string FullName { get; set; }

        [Display(Name = "DOB")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Display(Name = "Appointment Date")]
        [Required]
        public DateTime AppointmentDate { get; set; }

    }
}
