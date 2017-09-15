using Assignment_Apu.Core;
using Assignment_Apu.Data.DatabaseSimulator;
using Assignment_Apu.Models;
using System.Windows.Input;

namespace Assignment_Apu.ViewModels
{
    public class EditRecipeViewModel
        : ViewModelBase
    {
        private Recipe _selectedRecipe;
        public Recipe SelectedRecipe
        {
            get => _selectedRecipe;
            set
            {
                _selectedRecipe = value;
                NotifyOfPropertyChange(() => SelectedRecipe);
            }
        }

        // Deleting recipe from cookbook
        public ICommand DeleteCommand => new FlexCommand(
            t => MockDatabase.I.Recipes.Remove(SelectedRecipe),
            t => SelectedRecipe != null);
    }
}