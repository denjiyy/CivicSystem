using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.General;

namespace CivicSystem.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : IdentityDbContext<IdentityUser>(options)
    {
        public DbSet<Attachment> Attachments { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<SuggestionCategory> SuggestionsCategories { get; set; } = null!;
        public DbSet<Comment> Comments { get; set; } = null!;
        public DbSet<Like> Likes { get; set; } = null!;
        public DbSet<Suggestion> Suggestions { get; set; } = null!;
        public DbSet<SuggestionTag> SuggestionTags { get; set; } = null!;
        public DbSet<Tag> Tags { get; set; } = null!;
        public DbSet<Vote> Votes { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Like>()
                .HasKey(l => new { l.UserId, l.SuggestionId });

            builder.Entity<Like>()
                .HasOne(l => l.Suggestion)
                .WithMany(s => s.Likes)
                .HasForeignKey(l => l.SuggestionId)
                .OnDelete(DeleteBehavior.Restrict);
            
            builder.Entity<Vote>()
                .HasOne(v => v.Comment)
                .WithMany(c => c.Votes)
                .HasForeignKey(v => v.CommentId)
                .OnDelete(DeleteBehavior.Restrict);
            
            builder.Entity<Category>().HasData(
                new Category { Id = Guid.NewGuid(), CategoryName = "RoadWork" },
                new Category { Id = Guid.NewGuid(), CategoryName = "PublicSafety" },
                new Category { Id = Guid.NewGuid(), CategoryName = "ParksAndRecreation" },
                new Category { Id = Guid.NewGuid(), CategoryName = "WasteManagement" },
                new Category { Id = Guid.NewGuid(), CategoryName = "PublicTransport" },
                new Category { Id = Guid.NewGuid(), CategoryName = "WaterSupply" },
                new Category { Id = Guid.NewGuid(), CategoryName = "Electricity" },
                new Category { Id = Guid.NewGuid(), CategoryName = "CommunityEvents" }
            );
        }
    }
}