using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MVC_assignment_3.Models
{
    public class Fruits
    {
        public int Id{ get; set; }

        public string FruitName{get;set;}
        public string FruitForm { get; set; }
        public int AvgRetailPrice { get; set; }
        public int PreparationYieldFactor { get; set; }
        public int Sizeofcupequivalent { get; set; }

        public int AvgPricepercupequivalent { get; set; }

    }
}
