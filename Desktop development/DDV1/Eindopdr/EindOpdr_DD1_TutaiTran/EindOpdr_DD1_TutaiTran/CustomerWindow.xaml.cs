using EindOpdr_DD1_TutaiTran.models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace EindOpdr_DD1_TutaiTran
{
    /// <summary>
    /// Interaction logic for CustomerWindow.xaml
    /// </summary>
    public partial class CustomerWindow : Window, INotifyPropertyChanged
    {

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string? name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        #endregion

        #region fields
        //connection to class DbConnection  
        DBconnection _conn = new DBconnection();
        #endregion

        #region properties
        private Customers newCustomer = new();

        public Customers  NewCustomer
        {
            get { return newCustomer; }
            set { newCustomer = value; OnPropertyChanged(); }
        }

        private ObservableCollection<Customers> customer = new();

        public ObservableCollection<Customers> Customers
        {
            get { return customer; }
            set { customer = value; OnPropertyChanged(); }
        }
        #endregion
        public CustomerWindow()
        {
            InitializeComponent();
            PopulateCustomers();
            DataContext= this;
        }

        // Method zet alle customers uit de database op het scherm in de control lvCustomers
        // Trad er een fout op bij het inlezen, wordt hiervan een melding getoond.
        private void PopulateCustomers()
        {
            Customers.Clear();
            string dbResult = _conn.GetCustomers(customer);
            if (dbResult != DBconnection.OK)
            {
                MessageBox.Show(dbResult + "Er is een fout opgetreden");
            }
        }

        private void CreateCustomer_Click(object sender, RoutedEventArgs e)
        {
            if(string.IsNullOrEmpty(NewCustomer.CustomerName))
            {
                MessageBox.Show("Vul naam van customer in");
                return;
            }

            string dbResult = _conn.CreateCustomers(NewCustomer);
            if(dbResult == DBconnection.OK) 
            {
                NewCustomer = new();
                PopulateCustomers();
                MessageBox.Show("New customer created");
                this.Close();
                
            }
            else
            {
                MessageBox.Show(dbResult + "Er is een fout opgetreden");
            }
        }


        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            new MainWindow().Show();
        }

        
    }
}
