using Assignment_Apu.ViewModels;

namespace Assignment_Apu.Models
{
    public class Ingredient
        : ViewModelBase
    {
        private string _ingredientName;
        public string IngredientName
        {
            get => _ingredientName;
            set
            {
                _ingredientName = value;
                NotifyOfPropertyChange(() => IngredientName);
            }
        }
    }
}
