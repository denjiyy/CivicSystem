using CivicSystem.Data.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static CivicSystem.Data.DataConstants;

namespace CivicSystem.Data
{
    public sealed class Suggestion
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MinLength(TitleMinLength)]
        [MaxLength(TitleMaxLength)]
        [Comment(TitleComment)]
        public string Title { get; set; } = string.Empty;

        [Required]
        [MinLength(DescriptionMinLength)]
        [MaxLength(DescriptionMaxLength)]
        [Comment(DescriptionComment)]
        public string Description { get; set; } = string.Empty;

        [Required]
        [Comment(SuggestionCreatedOnComment)]
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;

        [Required]
        public Status Status { get; set; }

        [Required]
        [Comment(UserIdComment)]
        public string UserId { get; set; } = string.Empty;
        [ForeignKey(nameof(UserId))]
        public IdentityUser User { get; set; } = null!;

        public ICollection<SuggestionTag> SuggestionsTags { get; set; } = new HashSet<SuggestionTag>();
        public ICollection<Comment> Comments { get; set; } = new HashSet<Comment>();
        public ICollection<Like> Likes { get; set; } = new HashSet<Like>();
        public ICollection<Attachment> Attachments { get; set; } = new HashSet<Attachment>();
    }
}
