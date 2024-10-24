using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static CivicSystem.Data.DataConstants;

namespace CivicSystem.Data
{
    public class Attachment
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [Comment(FilePathComment)]
        public string FilePath { get; set; } = string.Empty;
        
        [Required]
        [Comment(AttachmentUploadedOnComment)]
        public DateTime UploadedOn { get; set; }
        
        [Required]
        public Guid SuggestionId { get; set; }
        [ForeignKey(nameof(SuggestionId))]
        public Suggestion Suggestion { get; set; } = null!;
    }
}
