using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CivicSystem.Data.Enums;
using static CivicSystem.Data.DataConstants;
using Microsoft.AspNetCore.Identity;

namespace CivicSystem.Data
{
    [PrimaryKey(nameof(UserId), nameof(CommentId))]
    public class Vote
    {
        [Required]
        public string UserId { get; set; } = string.Empty;
        [ForeignKey(nameof(UserId))]
        public IdentityUser User { get; set; } = null!;

        [Required]
        public Guid CommentId { get; set; }
        [ForeignKey(nameof(CommentId))]
        public Comment Comment { get; set; } = null!;

        [Required]
        [Comment(VoteTypeComment)]
        public VoteType VoteType { get; set; }
    }
}
