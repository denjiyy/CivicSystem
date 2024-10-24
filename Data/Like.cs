using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CivicSystem.Data
{
    [PrimaryKey(nameof(UserId), nameof(SuggestionId))]
    public class Like
    {
        [Required]
        public string UserId { get; set; } = string.Empty;
        [ForeignKey(nameof(UserId))]
        public IdentityUser User { get; set; } = null!;

        [Required]
        public Guid SuggestionId { get; set; }
        [ForeignKey(nameof(SuggestionId))]
        public Suggestion Suggestion { get; set; } = null!;
    }
}
