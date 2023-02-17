using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ReposiratoryPattern.DAL.Entites;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ReposiratoryPattern.DAL.Database
{
    public class DBApplication:DbContext
    {
        public DBApplication(DbContextOptions<DBApplication>opt):base(opt)
        {

        }
       
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Book>().Property(e => e.CreatedTime).HasDefaultValueSql("GETDATE()");
            base.OnModelCreating(builder);
        }
        public DbSet<Book> Books { get; set; }

    }
}
