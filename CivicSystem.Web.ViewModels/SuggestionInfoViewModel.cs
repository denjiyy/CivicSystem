namespace CivicSystem.Web.ViewModels;

public class SuggestionInfoViewModel
{
    public SuggestionInfoViewModel(Guid id, string title, string description, string userId, string status, string createdOn)
    {
        Id = id;
        Title = title;
        UserId = userId;
        Description = description;
        Status = status;
        CreatedOn = createdOn;
    }

    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string UserId { get; set; }
    public string Status { get; set; }
    public string CreatedOn { get; set; }
}