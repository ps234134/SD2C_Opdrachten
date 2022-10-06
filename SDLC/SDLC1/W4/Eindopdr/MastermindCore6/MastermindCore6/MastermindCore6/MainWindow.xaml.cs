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
using MastermindCore6.Model;

namespace MastermindCore6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MM mm = new MM();

        public MainWindow()
        {
            InitializeComponent();
            this.btStart_Click(null, null);
        }

        private void btStart_Click(object sender, RoutedEventArgs e)
        {
            mm.NieuwSpel();
            tbTeRaden.Text = mm.TeRaden;
            lvRaster.Items.Clear();
            lvRaster.Items.Add("Beurt \t Poging \t\t Posities \t Aantal");
            tbPoging.Text = "";
            tbUitslag.Text = "";
            btOK.IsEnabled = true;
            tbPoging.Focus();
        }

        private void ToonResultaat()
        {
            lvRaster.Items.Add(new Uitslag(mm.Beurt, mm.Poging, mm.PositiesOK(), mm.AantalOK()));
            mm.NieuweBeurt();
            if (mm.PositiesOK() == 4)
            {
                tbUitslag.Text = "Geraden in " + mm.Beurt + " beurten";
                btOK.IsEnabled = false;
            }
            else if (mm.Beurt >= 10)
            {
                btOK.IsEnabled = false;
                tbUitslag.Text = "Niet geraden";
            }
        }

        private void btOK_Click(object sender, RoutedEventArgs e)
        {
            if (mm.Beurt < 10)
            {
                mm.NieuwePoging(tbPoging.Text);
                ToonResultaat();
                tbPoging.Text = "";
                tbPoging.Focus();
            }
        }

        private void cbOpenSpel_Click(object sender, RoutedEventArgs e)
        {
            tbTeRaden.Visibility = (cbOpenSpel.IsChecked == true) ? Visibility.Visible : Visibility.Collapsed;
            tbPoging.Focus();
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            tbPoging.Focus();
        }

        private void tbPoging_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tbPoging.Text.Length == 4) btOK.Focus();
        }
    }
}
