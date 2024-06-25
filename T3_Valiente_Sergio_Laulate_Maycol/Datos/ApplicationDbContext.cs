using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using T3_Valiente_Sergio_Laulate_Maycol.Models;

namespace T3_Valiente_Sergio_Laulate_Maycol.Datos
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base (options) 
        {
            
        }
        public DbSet<Libro> libro { get; set; }
    }
}
