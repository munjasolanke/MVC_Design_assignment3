using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MVC_assignment_3.Models
{
    public class Vegetables
    {
        public int Id { get; set; }

        public string VegetableName { get; set; }
        public string VegetableForm { get; set; }
        public int AvgRetailPrice { get; set; }
        public int PreparationYieldFactor { get; set; }
        public int Sizeofcupequivalent { get; set; }

        public int AvgPricepercupequivalent { get; set; }

    }
}
