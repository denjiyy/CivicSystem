using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using static CivicSystem.Data.DataConstants;

namespace CivicSystem.Data;

public class Tag
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    [MinLength(TagNameMinLength)]
    [MaxLength(TagNameMaxLength)]
    [Comment(TagNameComment)]
    public string TagName { get; set; } = string.Empty;

    public ICollection<SuggestionTag> SuggestionsTags { get; set; } = new HashSet<SuggestionTag>();
}