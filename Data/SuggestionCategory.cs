using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CivicSystem.Data;

[PrimaryKey(nameof(SuggestionId), nameof(CategoryId))]
public class SuggestionCategory
{
    [Required]
    public Guid SuggestionId { get; set; }
    [ForeignKey(nameof(SuggestionId))]
    public Suggestion Suggestion { get; set; } = null!;
    
    [Required]
    public Guid CategoryId { get; set; }
    [ForeignKey(nameof(CategoryId))]
    public Category Category { get; set; } = null!;
}