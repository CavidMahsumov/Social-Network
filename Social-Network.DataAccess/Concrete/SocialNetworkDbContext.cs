using Microsoft.EntityFrameworkCore;
using Social_Network.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Social_Network.DataAccess.Concrete
{
    public class SocialNetworkDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var conn = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SocialMediaDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            optionsBuilder.UseSqlServer(conn);
           
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Chat> Chats { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Notfication> Notfications { get; set; }
        public DbSet<Story> Stories { get; set; }

    }
}
