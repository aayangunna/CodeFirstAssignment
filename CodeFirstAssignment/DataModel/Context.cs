using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstAssignment.DataModel
{
    class Context : DbContext
    {
        public DbSet<Course> Courses { get; set; } 
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        {
            optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=BankAppDb;Integrated Security=True");
        }
    }
}
