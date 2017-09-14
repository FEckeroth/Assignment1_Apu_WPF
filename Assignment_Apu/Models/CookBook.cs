using Assignment_Apu.ViewModels;
using System.Collections.ObjectModel;

namespace Assignment_Apu.Models
{
    class CookBook
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
    }
}
