namespace Assignment_Apu.ViewModels
{
    public class RootViewModel
        : ViewModelBase
    {
        private RecipeViewModel recipeView;

        public RecipeViewModel RecipeView
        {
            get => recipeView;
            set
            {
                recipeView = value;
                NotifyOfPropertyChange(() => RecipeView);
            }
        }

        public RootViewModel()
        {
            RecipeView = new RecipeViewModel();
        }
    }
}