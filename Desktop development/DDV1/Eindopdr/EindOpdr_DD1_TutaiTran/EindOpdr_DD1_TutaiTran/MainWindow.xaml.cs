using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using EindOpdr_DD1_TutaiTran.models;

namespace EindOpdr_DD1_TutaiTran
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        #region        INotifyPropertyChanged 
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        #endregion

        #region fields
        //connection to class DbConnection  
        DBconnection _conn = new DBconnection();
        #endregion

        #region properties
        //ObservableCollection list with all customers and countries
        private ObservableCollection<Customers> customer = new ObservableCollection<Customers>();
        private ObservableCollection<Countries> country = new ObservableCollection<Countries>();

        public ObservableCollection<Customers> Customers
        {
            get { return customer; }
            set { customer = value; OnPropertyChanged(); }
        }

        private Customers selectedCustomer;

        public Customers SelectedCustomer
        {
            get { return selectedCustomer; }
            set 
            { 
                selectedCustomer = value; 
                PopulateCustomers();
                OnPropertyChanged();
            
            }
        }


        public ObservableCollection<Countries> Countries
        {
            get { return country; }
            set { country = value; OnPropertyChanged(); }
        }

        private Countries selectedCountries;

        public Countries SelectedCountries
        {
            get { return selectedCountries; }
            set { selectedCountries = value; OnPropertyChanged(); }
        }

        //list wist favcountries from the costumers, costumers and countries.

        public List<FavCountries> favCountries = new List<FavCountries>();
        public List<Customers> lstCustomers = new List<Customers>();
        public List<Countries> lstCountries = new List<Countries>();
        #endregion

        public MainWindow()
        {
            InitializeComponent();
            PopulateCountries();
            PopulateCustomers();
            DataContext = this;
        }

        private void PopulateCustomers()
        {
            string result = _conn.GetCustomers(customer);
            if (result != DBconnection.OK)
            {
                MessageBox.Show(result);
                return;
            }
        }

        private void PopulateCountries()
        {
            string result = _conn.GetCountries(country);
            if (result != DBconnection.OK)
            {
                MessageBox.Show(result);
                return;
            }
        }


        private void BtnAddCustomer_Click(object sender, RoutedEventArgs e)
        {
            Window window = new CustomerWindow();
            window.Show();
            this.Close();
        }

        private void BtnCustomerDelete_Click(object sender, RoutedEventArgs e)
        {
            Button btnDel = (Button)sender;
             Customers customer = (Customers)btnDel.DataContext;

            string dbResult = _conn.DeleteCustomer(customer.CustomerId);
            if (dbResult == DBconnection.OK)
            {
                PopulateCustomers();
            }
            else
            {
                MessageBox.Show(dbResult + "Er is een fout opgetreden");
            }
        }
    }
}
