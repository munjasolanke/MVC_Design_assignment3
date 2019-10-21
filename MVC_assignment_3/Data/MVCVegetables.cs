using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVC_assignment_3.Models;
namespace MVC_assignment_3.Data
{
    public class MVCVegetables : DbContext
    {
        public MVCVegetables(DbContextOptions<MVCVegetables> options)
            : base(options)
        {
        }

        public DbSet<Vegetables> Vegetables { get; set; }
    }
}

