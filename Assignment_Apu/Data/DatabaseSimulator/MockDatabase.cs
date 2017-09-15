using Assignment_Apu.Extensions;
using Assignment_Apu.Models;
using Assignment_Apu.ViewModels;
using Caliburn.Micro;
using System;
using System.Linq;
using System.Windows;

namespace Assignment_Apu.Data.DatabaseSimulator
{
    /// <summary>
    /// Database mockup in order to simulate a real life project.
    /// Using the Singleton pattern.
    /// </summary>
    public class MockDatabase
        : ViewModelBase
    {
        #region
        /// <summary>
        /// Simply creating an instance of the MockDatabase. Check if there is a database in place, if not
        /// Instanciate a new one.
        /// </summary>
        protected static MockDatabase Instance;

        public static MockDatabase I
            => Instance
               ?? (Instance = new MockDatabase());

        private MockDatabase()
        {
            OnInstanceCreated();
        }

        /// <summary>
        /// Parses the given .xaml seed file for data to the mockdatabase.
        /// Currently filled with hardcoded data for testing
        /// </summary>
        private void OnInstanceCreated()
        {
            var uriToSeed = new Uri("/Assignment_Apu;component/Data/Seed/Seed.Recipes.xaml", UriKind.Relative);
            var seed = (ResourceDictionary)Application.LoadComponent(uriToSeed);

            Recipes = seed.Values.OfType<Recipe>().AsBindable();
            Ingredients = seed.Values.OfType<Ingredient>().AsBindable();
        }

        #endregion

        /// <summary>
        /// Using BindableCollections (part of Caliburn.Micro framework)
        /// BindableCollections handle UI thread marshelling automatically.
        /// Makes transfering objects between threads easier.
        /// </summary>
        private BindableCollection<Recipe> _recipes;
        public BindableCollection<Recipe> Recipes
        {
            get => _recipes;
            set
            {
                _recipes = value;
                NotifyOfPropertyChange(() => Recipes);
            }
        }

        private BindableCollection<Ingredient> _ingredients;
        public BindableCollection<Ingredient> Ingredients
        {
            get => _ingredients;
            set
            {
                _ingredients = value;
                NotifyOfPropertyChange(() => Ingredients);
            }
        }
    }
}