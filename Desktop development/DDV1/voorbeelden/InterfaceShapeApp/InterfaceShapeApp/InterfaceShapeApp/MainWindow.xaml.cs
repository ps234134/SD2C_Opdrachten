using InterfaceShapeApp.Models;
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

namespace InterfaceShapeApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Circle circle1 = new Circle();
            circle1.Radius = 10;
            MessageBox.Show("De oppervlakte is " + circle1.CalculateSurface());

            Circle circle2 = new Circle();
            circle2.Radius = 15;
            MessageBox.Show(circle2.CalculateSurface().ToString());

            Square square1 = new Square();
            square1.Width = 5;
            square1.Height = 8;
            MessageBox.Show(square1.CalculateSurface().ToString());
        }
    }
}
