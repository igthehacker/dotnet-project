﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using dotnet_project.Models.Domain;

namespace dotnet_project.Models.Domain
{
    public class DatabaseContext : IdentityDbContext<ApplicationUser>
    {
        public DatabaseContext  (DbContextOptions<DatabaseContext> options) : base(options)
            {

            }
        public DbSet<Genre> Genre { get; set; }
        public DbSet<BookGenre> BookGenre { get; set; }
        public DbSet<Book> Book { get; set; }
    }
}
