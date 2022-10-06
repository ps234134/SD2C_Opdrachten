using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace unittestWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        Bankrekening rekening = new Bankrekening();
        public MainWindow()
        {
            InitializeComponent();
        }
        private double stringToDouble(string b)
        {
            double bedrag;
            Double.TryParse(b, out bedrag);
            return bedrag;
        }
        private void Opnemen_Clicked(object sender, RoutedEventArgs e)
        {
            rekening.Opnemen(stringToDouble(Bedrag.Text));
            Saldo.Content = rekening.Saldo.ToString("0.00");
        }
        private void Storten_Clicked(object sender, RoutedEventArgs e)
        {
            rekening.Storten(stringToDouble(Bedrag.Text));
            Saldo.Content = rekening.Saldo.ToString("0.00");
        }

        private void Bevroren_Click(object sender, RoutedEventArgs e)
        {
            rekening.Bevroren = (bool)Bevroren.IsChecked;
        }

    }
}
