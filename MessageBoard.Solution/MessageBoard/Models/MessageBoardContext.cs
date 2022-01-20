// using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MessageBoard.Models
{
    public class MessageBoardContext : DbContext
    {
        public MessageBoardContext(DbContextOptions<MessageBoardContext> options)
            : base(options)
        {
        }

        public DbSet<Group> Groups { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Group>()
            .HasData(
                new Group { GroupId = 1, GroupName = "Cooking", Description = "Cooking lessons" },
                new Group { GroupId = 2, GroupName = "Hiking", Description = "Weekly hiking group"},
                new Group { GroupId = 3, GroupName = "Camping", Description = "Best camping spots"},
                new Group { GroupId = 4, GroupName = "DIY", Description = "DIY classes"},
                new Group { GroupId = 5, GroupName = "Crafting", Description = "Crafting club"}
            );
        }
    }
}