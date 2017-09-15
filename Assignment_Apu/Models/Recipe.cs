using Assignment_Apu.Enums;
using Assignment_Apu.ViewModels;
using Caliburn.Micro;
using System.Windows.Markup;

namespace Assignment_Apu.Models
{
    [ContentProperty(nameof(Ingredients))]
    public class Recipe
        : ViewModelBase
    {
        private string recipeName;
        public string RecipeName
        {
            get => recipeName;
            set
            {
                recipeName = value;
                NotifyOfPropertyChange(() => RecipeName);
            }
        }

        private Dish dish;
        public Dish Dish
        {
            get => dish;
            set
            {
                dish = value;
                NotifyOfPropertyChange(() => Dish);
            }
        }

        private Course course;
        public Course Course
        {
            get => course;
            set
            {
                course = value;
                NotifyOfPropertyChange(() => Course);
            }
        }

        private string description;
        public string Description
        {
            get => description;
            set
            {
                description = value;
                NotifyOfPropertyChange(() => Description);
            }
        }

        private BindableCollection<IngredientUse> ingredients;
        public BindableCollection<IngredientUse> Ingredients
        {
            get => ingredients;
            set
            {
                ingredients = value;
                NotifyOfPropertyChange(() => Ingredients);
            }
        }

        public Recipe()
        {
            Ingredients = new BindableCollection<IngredientUse>();
        }
    }
}