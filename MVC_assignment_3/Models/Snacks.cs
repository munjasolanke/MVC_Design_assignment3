using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MVC_assignment_3.Models
{
    public class Snacks
    {
        public int Id { get; set; }

        public string SnackName { get; set; }
        public int PortionSize { get; set; }
        public int PricePerPortion { get; set; }
        public int CaloriesPerPortion { get; set; }

    }
}
