namespace CivicSystem.Common
{
    public static class DataConstants
    {
        // constants for the suggestion model
        public const int TitleMinLength = 3;
        public const int TitleMaxLength = 30;
        public const string TitleComment = "The title of the suggestion.";
        public const int DescriptionMinLength = 10;
        public const int DescriptionMaxLength = 150;
        public const string DescriptionComment = "The description of the suggestion made by the user.";
        public const string SuggestionCreatedOnComment = "Shows when the post was made.";
        public const string StatusComment = "The status of the suggestion (e.g. 'open', 'in-progress', 'resolved')";
        public const string UserIdComment = "The foreign key to the applicationUser's Id.";
        
        // constants for the vote model
        public const string VoteTypeComment = "The vote type of the suggestion.";

        // constants for the category model
        public const int CategoryNameMinLength = 10;
        public const int CategoryNameMaxLength = 30;
        public const string CategoryNameComment = "The suggestion's category.";

        // constants for the comment model
        public const int CommentMinLength = 10;
        public const int CommentMaxLength = 150;
        public const string CommentDbComment = "Saved comments for the given suggestion.";
        public const string SuggestionIdComment = "Foreign key to the suggestions table.";
        public const string CommentCreatedOnComment = "Shows when the post was created by the user.";

        // constants for the attachment model
        public const string FilePathComment = "The file's path as a string.";
        public const string AttachmentUploadedOnComment = "Shows when the attachment (image) was uploaded by the user.";
        
        // constants for the tag model
        public const int TagNameMinLength = 3;
        public const int TagNameMaxLength = 30;
        public const string TagNameComment = "The tag name of the suggestion.";
    }
}
