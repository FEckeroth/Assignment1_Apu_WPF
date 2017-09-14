

using Assignment_Apu.Core;
using Assignment_Apu.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Assignment_Apu.ViewModels
{
    public class AddRecipeViewModel
        : ViewModelBase
    {
        private ObservableCollection<Recipe> recipes;

        public ObservableCollection<Recipe> Recipes
        {
            get { return recipes; }
            set
            {
                recipes = value;
                NotifyOfPropertyChange(() => Recipes);
            }
        }

        private Recipe recipe;

        public Recipe Recipe
        {
            get { return recipe; }
            set
            {
                recipe = value;
                NotifyOfPropertyChange(() => Recipe);
            }
        }

        public ICommand AddRecipeCommand => new FlexCommand(
            t => { Recipes.Add(Recipe); },
            t => Recipe != null);
    }
}
