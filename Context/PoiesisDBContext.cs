using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using poiesis_mvc.Models;

namespace poiesis_mvc.Context
{
    public class PoiesisDBContext : DbContext
    {

        public PoiesisDBContext(DbContextOptions<PoiesisDBContext> options) : base(options)
        {
        }
        public DbSet<Texto> Textos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
