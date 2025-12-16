namespace RapidApiDemoNew.Models
{
    public class RecipeSuggestionModel
    {
        public string recipeName { get; set; }
        public string shortDescription { get; set; }
        public string prepTime { get; set; }
    }


    public class DashboardRecipeSuggestionViewModel
    {
        public RecipeSuggestionModel AiRecipe { get; set; }
    }
}
