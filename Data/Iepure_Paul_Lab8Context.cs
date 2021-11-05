using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Iepure_Paul_Lab8.Models;

namespace Iepure_Paul_Lab8.Data
{
    public class Iepure_Paul_Lab8Context : DbContext
    {
        public Iepure_Paul_Lab8Context (DbContextOptions<Iepure_Paul_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Iepure_Paul_Lab8.Models.Book> Book { get; set; }

        public DbSet<Iepure_Paul_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Iepure_Paul_Lab8.Models.Category> Category { get; set; }
    }
}
