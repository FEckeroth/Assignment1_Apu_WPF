using Assignment_Apu.ViewModels;

namespace Assignment_Apu.Models
{
    public class Ingredient
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

        private float amount;

        public float Amount
        {
            get { return amount; }
            set
            {
                amount = value;
                NotifyOfPropertyChange(() => Amount);
            }
        }
    }
}
