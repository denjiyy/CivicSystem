using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.Build.Framework;
using Microsoft.EntityFrameworkCore;

namespace CivicSystem.Data;

[PrimaryKey(nameof(SuggestionId), nameof(TagId))]
public class SuggestionTag
{
    [Required]
    public Guid SuggestionId { get; set; }
    [ForeignKey(nameof(SuggestionId))]
    public Suggestion Suggestion { get; set; } = null!;
    
    [Required]
    public Guid TagId { get; set; }
    [ForeignKey(nameof(TagId))]
    public Tag Tag { get; set; } = null!;
}