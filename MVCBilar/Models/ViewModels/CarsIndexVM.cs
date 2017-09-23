using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCBilar.Models
{
    public class CarsIndexVM
    {
        public CarsFormVM[] ListViewModels { get; set; }
        public CarsCreateVM FormViewModel { get; set; }
    }
}
