using Assignment_Apu.Enums;
using Assignment_Apu.ViewModels;
using System.Collections.ObjectModel;

namespace Assignment_Apu.Models
{
    public class Recipe
        : ViewModelBase
    {
        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                NotifyOfPropertyChange(() => Name);
            }
        }

        private int numOfIngredients;

        public int NumOfIngredients
        {
            get { return numOfIngredients; }
            set
            {
                numOfIngredients = value;
                NotifyOfPropertyChange(() => NumOfIngredients);
            }
        }

        private Dish dish;

        public Dish Dish
        {
            get { return dish; }
            set
            {
                dish = value;
                NotifyOfPropertyChange(() => Dish);
            }
        }

        private Course course;

        public Course Course
        {
            get { return course; }
            set
            {
                course = value;
                NotifyOfPropertyChange(() => Course);
            }
        }

        private string description;

        public string Description
        {
            get { return description; }
            set
            {
                description = value;
                NotifyOfPropertyChange(() => Description);
            }
        }

        private ObservableCollection<Ingredient> ingredient;

        public ObservableCollection<Ingredient> Ingredient
        {
            get { return ingredient; }
            set
            {
                ingredient = value;
                NotifyOfPropertyChange(() => Ingredient);
            }
        }
    }
}
