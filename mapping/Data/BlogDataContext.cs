using mapping.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace basic_operations.Data
{
    public class BlogDataContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }

        // public DbSet<UserRole> UserRoles { get; set; }
        // public DbSet<PostTag> PostTags { get; set; }
        // public DbSet<Role> Roles { get; set; }
        // public DbSet<Tag> Tags { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1433;Database=Blog;Encrypt=False;User ID=sa;Password=1q2w3e4r@#$");
            // optionsBuilder.LogTo(Console.WriteLine); // Log das queries do banco no console
        }
    }
}
