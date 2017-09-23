using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCBilar.Models
{
    public class CarsDetailsVM
    {
        //public int Id { get; internal set; }
        
        public string Brand { get; set; }

        public int TopSpeed { get; set; }
        public bool ShowAsFast { get; set; }

        public int Doors { get; set; }

        public string Owner { get; set; }

    }
}
