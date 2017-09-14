using Assignment_Apu.ViewModels;

namespace Assignment_Apu.Models
{
    public class Book
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
    }
}
