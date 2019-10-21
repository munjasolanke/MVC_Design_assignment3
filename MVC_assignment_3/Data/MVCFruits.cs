using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVC_assignment_3.Models;

namespace MVC_assignment_3.Data
{
    public class MVCFruits : DbContext
    {
        public MVCFruits(DbContextOptions<MVCFruits> options)
            : base(options)
        {
        }

        public DbSet<Fruits> Fruits { get; set; }
    }
}

