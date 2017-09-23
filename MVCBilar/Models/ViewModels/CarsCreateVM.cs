using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCBilar.Models
{
    public class CarsCreateVM
    {
        [Required(ErrorMessage = "Invalid input")]
        [Display(Name = "Make")]
        public string Brand { get; set; }

        [Required(ErrorMessage = "Please select a number in the dropdown menu")]
        [Display(Name = "Doors")]
        public int Doors { get; set; }

        public SelectListItem[] DoorItems { get; set; }
        public string SelectedDoors { get; set; }

        [Required(ErrorMessage = "Please fill in a number up to 300")]
        [Display(Name = "Top speed (< 300)")]
        public int TopSpeed { get; set; }

    }
}
