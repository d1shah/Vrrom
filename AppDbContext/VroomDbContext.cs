//using Microsoft.AspNetCore.Identity;
//using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vroom.Models;
//using Vroom.Models;

namespace vroom.AppDbContext
{
    public class VroomDbContext : DbContext
    {
        public VroomDbContext(DbContextOptions<VroomDbContext> options) :
            base(options)
        {

        }
        public DbSet<Make> Makes { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Features> Features { get; set; }
        public DbSet<Model> ApplicationUsers { get; set; }
    }
}
