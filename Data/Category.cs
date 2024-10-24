using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static CivicSystem.Data.DataConstants;

namespace CivicSystem.Data
{
    public class Category
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MinLength(CategoryNameMinLength)]
        [MaxLength(CategoryNameMaxLength)]
        [Comment(CategoryNameComment)]
        public string CategoryName { get; set; } = string.Empty;

        public ICollection<SuggestionCategory> SuggestionsCategories { get; set; } = new HashSet<SuggestionCategory>();
    }
}
