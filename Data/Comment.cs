using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static CivicSystem.Data.DataConstants;

namespace CivicSystem.Data
{
    public class Comment
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MinLength(CommentMinLength)]
        [MaxLength(CommentMaxLength)]
        [Comment(CommentDbComment)]
        public string CommentText { get; set; } = string.Empty;
        
        [Required]
        [Comment(CommentCreatedOnComment)]
        public DateTime CreatedOn { get; set; }

        [Required]
        [Comment(SuggestionIdComment)]
        public Guid SuggestionId { get; set; }
        [ForeignKey(nameof(SuggestionId))]
        public Suggestion Suggestion { get; set; } = null!;
        
        public ICollection<Vote> Votes { get; set; } = new HashSet<Vote>();
    }
}
