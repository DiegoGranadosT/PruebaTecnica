using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducaJunto.Profile.Infraestructure.Persistence
{
    public class DbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        //public DbSet<T> T { get; set; }

        public DbContext()
        {

        }

        public DbContext(DbContextOptions<DbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
        }
    }
}
