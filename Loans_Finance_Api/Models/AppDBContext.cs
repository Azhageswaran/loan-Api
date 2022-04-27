using Microsoft.EntityFrameworkCore;
using System;

namespace Loans_Finance_Api.Models
{   
        public class AppDBContext : DbContext
        {

            public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
            {

            }
            public DbSet<User> Users { get; set; }
            public DbSet<Admin> Admins { get; set; }
            public DbSet<Loan> Loans { get; set; }
        }
   
}
