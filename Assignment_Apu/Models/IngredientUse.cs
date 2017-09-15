using Assignment_Apu.Enums;
using Assignment_Apu.ViewModels;

namespace Assignment_Apu.Models
{
    public class IngredientUse
        : ViewModelBase
    {
        private Ingredient _ingredient;
        public Ingredient Ingredient
        {
            get => _ingredient;
            set
            {
                _ingredient = value;
                NotifyOfPropertyChange(() => Ingredient);
            }
        }

        private double _amount;
        public double Amount
        {
            get => _amount;
            set
            {
                _amount = value;
                NotifyOfPropertyChange(() => Amount);
            }
        }

        private MeasurementUnit _unit;
        public MeasurementUnit Unit
        {
            get => _unit;
            set
            {
                _unit = value;
                NotifyOfPropertyChange(() => Unit);
            }
        }

    }
}