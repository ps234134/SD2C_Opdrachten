using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Lj2Dd1En2.Models;

namespace Lj2Dd1En2.Views
{
    /// <summary>
    /// Interaction logic for DisplayWindow.xaml
    /// </summary>
    public partial class DisplayWindow : Window, INotifyPropertyChanged

    {
        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string? name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        #endregion
        #region fields
        private readonly LosPollosHermanosDb db = new LosPollosHermanosDb();
        private readonly string serviceDeskBericht = "\n\nNeem contact op met de service desk";
        #endregion
        #region Properties
        private ObservableCollection<Meal> meals = new ObservableCollection<Meal>();
        public ObservableCollection<Meal> Meals
        {
            get { return meals; }
            set { meals = value; OnPropertyChanged(); }
        }
        private Meal? selectedMeal;
        public Meal? SelectedMeal
        {
            get { return selectedMeal; }
            set { selectedMeal = value; OnPropertyChanged(); }
        }
        #endregion
        public DisplayWindow()
        {
            InitializeComponent();
            PopulateMeals();
            DataContext = this;
        }
        // Method zet alle maaltijden uit de database op het scherm in de control lvMeals
        // Trad er een fout op bij het inlezen, wordt hiervan een melding getoond.
        private void PopulateMeals()
        {
            string dbResult = db.GetMeals(Meals);
            if (dbResult != LosPollosHermanosDb.OK)
            {
                MessageBox.Show(dbResult + serviceDeskBericht);
            }
        }
    }
}