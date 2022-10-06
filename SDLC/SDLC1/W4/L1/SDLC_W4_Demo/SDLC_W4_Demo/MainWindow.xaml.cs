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

namespace SDLC_W4_Demo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void getal_TextChanged(object sender, TextChangedEventArgs e)

        {

            Rekenaar r = new Rekenaar();

            r.A = StringToInt(getal1.Text);

            r.B = StringToInt(getal2.Text);

            r.Operator = Operator.Plus;

            som.Text = r.Uitslag().ToString();

        }

        private int StringToInt(string s)

        {

            int i = 0;

            Int32.TryParse(s, out i);

            return i;

        }
    }
}
