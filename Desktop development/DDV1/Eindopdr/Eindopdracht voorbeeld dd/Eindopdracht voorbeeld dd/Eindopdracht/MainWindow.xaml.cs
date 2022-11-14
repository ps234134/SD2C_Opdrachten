using Eindopdracht.models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;

namespace Eindopdracht
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        DBconnection db = new DBconnection(); // connection naar de databese class.

        private ObservableCollection<Costumer> ObvLstCostumers = new ObservableCollection<Costumer>();// een ObservableCollectoin lijst met alle costumers.
        private ObservableCollection<Land> ObvlstCountry = new ObservableCollection<Land>();// een ObservableCollectoin lijst met alle landen.
        private ObservableCollection<Land> ObvlstFavCountry = new ObservableCollection<Land>();// een ObservableCollectoin lijst met alle landen.

        public List<CostumerFavCountry> lstFavCountry = new List<CostumerFavCountry>(); // een lijst met alle costumers favourite laneden 
        public List<Land> lstCountry = new List<Land>(); // een lijst met alle landen 
        public List<Costumer> lstCostumer = new List<Costumer>(); // een lijst met alle costumers.


        public ObservableCollection<Land> Landens
        {
            get { return ObvlstCountry; }
            set { ObvlstCountry = value; }
        }
        public ObservableCollection<Costumer> Costumers
        {
            get { return ObvLstCostumers; }
            set { ObvLstCostumers = value; }
        }
        public ObservableCollection<Land> LstFavLanden
        {
            get
            {

                if (SelectedCostumer == null) return null;
                var join = from c in lstFavCountry
                           join l in lstCountry
                           on c.CountryID equals l.Code
                           where c.CostumerId == selectedCostumer.ID
                           select l;
                ObvlstFavCountry = new ObservableCollection<Land>(join);
                return ObvlstFavCountry;
            }
            set { ObvlstFavCountry = value; OnPropertyChanged(); }
        }

        private Costumer selectedCostumer; // dit is één customer in het lijst dat is geselecteerde.
        private Land selectedLand; // één land die geselecteerd is in lijst landen.
        private Land selectedFavLand;

        public Costumer SelectedCostumer
        {
            get { return selectedCostumer; }
            set { selectedCostumer = value; OnPropertyChanged(); OnPropertyChanged("LstFavLanden"); }
        }
        public Land SelectedLand
        {
            get { return selectedLand; }
            set { selectedLand = value; }
        }
        public Land SelectedFavLand
        {
            get { return selectedFavLand; }
            set { selectedFavLand = value; }
        }


        public MainWindow()
        {
            InitializeComponent();
            LoadAllList();
            LoadAllFavCountrys();
            DataContext = this;
        }

        private void BtnCustomer_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            CostumerWin win = new CostumerWin();
            win.ShowDialog();
        }

        // het toevoegen van één favourite land van costumer.
        private void BtnFavourite_Click(object sender, RoutedEventArgs e)
        {
            if (SelectedCostumer == null || SelectedLand == null)
            {
                MessageBox.Show("Je hebt geen land of een costumer gekozen. je moet een costumer en land selecteerden in de lijsten als je een land wil toevoegen aan costumer. ");
            }
            else
            {
                if (lstvFavPlace.Items.Count >= 3) // checkt hoeveel itmes in de listview favaourite land zit. en als er hoger dan 3 itmes is, kan je niet meer toevoegen.
                {
                    MessageBox.Show("Je mag niet meer dan Drie landen toevoegen aan één costumer.");
                }
                else
                {
                    db.SaveFavCountry(SelectedCostumer, SelectedLand);
                    LoadAllFavCountrys();


                }
            }
        }

        private void ResetSettings()
        {
            lstvFavPlace.Items.Refresh();
            ObvlstFavCountry = new ObservableCollection<Land>();
            LstFavLanden = null;
        }

        public void LoadAllList()
        {

            foreach (Costumer c in db.GetAllCostumers())
            {
                if (c == null) MessageBox.Show("Er is iets mis met je database.De database is leeg. ");
                Costumers.Add(c);
            }
            foreach (Costumer c in db.GetAllCostumers())
            {
                lstCostumer.Add(c);
            }

            foreach (Land l in db.GetAllLanden())
            {
                if (l == null) MessageBox.Show("Er is iets mis met je database.De database is leeg. ");
                lstCountry.Add(l);
            }

            foreach (Land landen in db.GetAllLanden())
            {
                if (landen == null) MessageBox.Show("Er is iets mis met je database.De database is leeg. ");
                Landens.Add(landen);
            }

        }

        public void LoadAllFavCountrys()
        {
            lstFavCountry.Clear();
            foreach (CostumerFavCountry l in db.GetAllFavLanden())
            {
                if (l == null) MessageBox.Show("Er is iets mis met je database.De database is leeg. ");
                lstFavCountry.Add(l);
                OnPropertyChanged("LstFavLanden");
            }
        }


        private void BtnFavDelete_Click(object sender, RoutedEventArgs e)
        {
            if (SelectedFavLand != null)
            {
                db.DeleteFavCountry(SelectedFavLand);
                LoadAllFavCountrys();
            }
            else
            {
                MessageBox.Show("Je hebt geen Land gekozen om te verwijderen.");
            }
        }
    }
}
