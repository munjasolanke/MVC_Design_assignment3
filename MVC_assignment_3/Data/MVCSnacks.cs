using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVC_assignment_3.Models;

namespace MVC_assignment_3.Data
{
    public class MVCSnacks : DbContext
    {
        public MVCSnacks(DbContextOptions<MVCSnacks> options)
            : base(options)
        {
        }

        public DbSet<Snacks> Snacks { get; set; }
    }
}
