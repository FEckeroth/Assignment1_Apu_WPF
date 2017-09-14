using Assignment_Apu.Core;
using Assignment_Apu.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Assignment_Apu.ViewModels
{
    public class EditRecipeViewModel
        : ViewModelBase
    {
        // I already get the list from "RecipeListViewModel", dunno how to get it elsewhere.
        private ObservableCollection<Recipe> recipe;

        public ObservableCollection<Recipe> Recipe
        {
            get { return recipe; }
            set
            {
                recipe = value;
                NotifyOfPropertyChange(() => Recipe);
            }
        }
        private Recipe selectedRecipe;

        public Recipe SelectedRecipe
        {
            get { return selectedRecipe; }
            set
            {
                selectedRecipe = value;
                NotifyOfPropertyChange(() => SelectedRecipe);
            }
        }

        // Deleting recipe from cookbook
        public ICommand DeleteCommand => new FlexCommand(
            t => { Recipe.Remove(SelectedRecipe); },
            t => SelectedRecipe != null);
    }
}
