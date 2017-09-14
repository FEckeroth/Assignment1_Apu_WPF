using Assignment_Apu.Enums;
using Assignment_Apu.Models;
using System.Collections.ObjectModel;

namespace Assignment_Apu.ViewModels
{
    public class RecipeViewModel
        : ViewModelBase
    {
        private ObservableCollection<Recipe> _recipes;
        private ObservableCollection<Ingredient> _ingredients;

        public ObservableCollection<Recipe> Recipes
        {
            get { return _recipes; }
            set
            {
                _recipes = value;
                NotifyOfPropertyChange(() => Recipes);
            }
        }

        public RecipeViewModel()
        {
            LoadRecipes();
        }

        private void LoadRecipes()
        {
            _ingredients = new ObservableCollection<Ingredient>()
            {
                new Ingredient() {Name = "teaspoons of sugar", Amount = 3.5f},
                new Ingredient() {Name = "tablespoons of sugar", Amount = 3.5f},
                new Ingredient() {Name = "lbs of meat", Amount = 100},
            };

            Recipes = new ObservableCollection<Recipe>
            {
                new Recipe()
                {
                    Name = "TestRecipe1",
                    NumOfIngredients = 1,
                    Course = Course.Appetizer,
                    Dish = Dish.Meat,
                    Description = "Some description",
                    Ingredient = _ingredients
                },

                new Recipe()
                {
                    Name = "TestRecipe2",
                    NumOfIngredients = 1,
                    Course = Course.Appetizer,
                    Dish = Dish.Meat,
                    Description = "Some description",
                    Ingredient = _ingredients
                },

                new Recipe()
                {
                    Name = "TestRecipe3",
                    NumOfIngredients = 1,
                    Course = Course.Appetizer,
                    Dish = Dish.Meat,
                    Description = "Some description",
                    Ingredient = _ingredients
                },

            };
        }
    }
}
