using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCBilar.Models
{
    public class CarsFormVM
    {
        [Display(Name = "Car brand")]
        public string Brand { get; set; }

        public int Doors { get; set; }

        public bool ShowAsFast { get; set; }
        public int Id { get; internal set; }
    }
}
