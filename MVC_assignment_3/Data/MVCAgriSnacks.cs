using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVC_assignment_3.Models;

namespace MVC_assignment_3.Data
{
    public class MVCAgriSnacks : DbContext
    {
        public MVCAgriSnacks(DbContextOptions<MVCAgriSnacks> options)
            : base(options)
        {
        }

        public DbSet<AgriSnacks> AgriSnacks { get; set; }
    }
}