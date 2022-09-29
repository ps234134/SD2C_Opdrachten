using MySql.Data.MySqlClient;
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

using System.Data;
using Microsoft.Win32;
using System.IO;

namespace Lj2Dd1En2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MySqlConnection _carsDB = new("server=localhost;database=carsdb;uid=root;pwd=;");
        byte[]? newImg;
        byte[]? updateImg;

        public MainWindow()
        {
            InitializeComponent();
            fillLb();
        }


        private void fillLb()
        {
            DataTable cars = new();
            _carsDB.Open();
            MySqlCommand sql = _carsDB.CreateCommand();
            sql.CommandText = "select * from cars order by make;";
            cars.Load(sql.ExecuteReader());
            LbAutos.ItemsSource = cars.DefaultView;
            _carsDB.Close();
        }

        // Eventhandler zet de gegevens van de auto die in de ListBox is geselecteerd, in de controls 
        // die bedoeld zijn om te updateImgen. Is er geen auto geselecteerd, worden de controles leeggemaakt
        private void LbAutos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (LbAutos.SelectedItem == null)
            {
                return;
            }

            DataRowView dr = (DataRowView)LbAutos.SelectedItem;

            tbMerk1.Text = dr["make"].ToString();
            tbJaar1.Text = dr["yearOfIntroduction"].ToString();

            if (dr["picture"] == DBNull.Value)
            {
                updateImg = null;
                imgAfbeelding1.Source = null;
            }
            else
            {
                updateImg = (byte[])dr["picture"];
                imgAfbeelding1.Source = new ImageSourceConverter().ConvertFrom(updateImg) as ImageSource;
            }
        }


        // Eventhandeler voegt een newImge auto toe aan de database
        private void create_Click(object sender, RoutedEventArgs e)
        {
            _carsDB.Open();
            MySqlCommand sql = _carsDB.CreateCommand();
            sql.CommandText =
                $"INSERT INTO cars(carId,  make,  picture, yearOfIntroduction) " +
                $"         VALUES ( null, @make, @picture, {tbJaar2.Text});";
            sql.Parameters.AddRange(
                new[]   {
                    new MySqlParameter(){ ParameterName = "@make", Value = tbMerk2.Text},
                    new MySqlParameter(){ ParameterName = "@picture", Value = newImg, }
                    }
                );
            sql.ExecuteReader();
            _carsDB.Close();

            fillLb();
            tbJaar2.Text = " ";
            tbMerk2.Text = "";
            imgAfbeelding2.Source = null;
        }

        private void update_Click(object sender, RoutedEventArgs e)
        {
            if (LbAutos.SelectedItem == null)
            {
                MessageBox.Show("U heeft een auto geselecteerd");
                return;
            }
            if (string.IsNullOrEmpty(tbMerk1.Text))
            {
                MessageBox.Show("Vul het merk van de auto in.");
                return;
            }
            if (string.IsNullOrEmpty(tbJaar1.Text))
            {
                MessageBox.Show("Vul het introductiejaar van de auto in.");
                return;
            }

            if (!int.TryParse(tbJaar1.Text, out int jaar) || jaar < 1769)
            {
                MessageBox.Show("Het introductiejaar mag alleen uit cijfers bestaan en mag niet voor 1769 liggen.");
                return;
            }

            try
            {
                DataTable cars = new();
                _carsDB.Open();
                MySqlCommand sql = _carsDB.CreateCommand();
                sql.CommandText =
                    $"UPDATE cars SET make= '{tbMerk1.Text}',picture = @picture, yearOfIntroduction = {tbJaar1.Text} " +
                    $" WHERE carId = {LbAutos.SelectedValue};";
                sql.Parameters.AddWithValue("@picture", updateImg);
                cars.Load(sql.ExecuteReader());
                LbAutos.ItemsSource = cars.DefaultView;
                _carsDB.Close();
                tbJaar1.Text = " ";
                tbMerk1.Text = "";
                imgAfbeelding1.Source = null;
            }
            catch (Exception exception)
            {
                MessageBox.Show("Er is iets fout gegaan");
            }
            finally
            {
                new MainWindow().Show();
                Close();
            }
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            if (LbAutos.SelectedItem == null)
            {
                MessageBox.Show("Selecteer eerst de auto die u wilt verwijderen.");
                return;
            }

            try
            {
                _carsDB.Open();
                MySqlCommand sql = _carsDB.CreateCommand();
                sql.CommandText = $"DELETE FROM cars WHERE carId = " + LbAutos.SelectedValue;
                sql.ExecuteNonQuery();
                _carsDB.Close();
                fillLb();
                tbJaar1.Text = " ";
                tbMerk1.Text = "";
                imgAfbeelding1.Source = null;
            }
            catch (Exception)
            {
                throw;
            }

            System.Diagnostics.Process.Start(Application.ResourceAssembly.Location);
        }

        private void BtnAfbeelding1_Click(object sender, RoutedEventArgs e)
        {
            updateImg = GetLocalPicture();
            if (updateImg != null)
            {
                imgAfbeelding1.Source =
                    new ImageSourceConverter().ConvertFrom(updateImg) as ImageSource;
            }
            else
            {
                imgAfbeelding1.Source = null;
            }
        }

        private void BtnAfbeelding2_Click(object sender, RoutedEventArgs e)
        {
            newImg = GetLocalPicture();
            if (newImg != null)
            {
                imgAfbeelding2.Source =
                    new ImageSourceConverter().ConvertFrom(newImg) as ImageSource;
            }
            else
            {
                imgAfbeelding2.Source = null;
            }
        }

        #region GetLocalPicture
        // GetLocalPicture leest een afbeelding op je computer in een array van byte in.
        // GetLocalPicture heef de volgende waarden:
        // - null: geen afbeelding ingefillLb
        // - ongelijk null: de ingefillLb afbeelding
        private byte[]? GetLocalPicture()
        {
            // Create OpenFileDialog 
            OpenFileDialog dlg = new OpenFileDialog();

            // Set filter for file extension and default file extension 
            dlg.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";
            dlg.FilterIndex = 3;    // 3de blok, is jpg

            // Display OpenFileDialog by calling ShowDialog method 
            bool? result = dlg.ShowDialog();

            // Get the selected file name and display in a TextBox 
            if (result == true)
            {
                return File.ReadAllBytes(dlg.FileName);
            }
            else
            {
                return null;
            }
        }
        #endregion
    }
}
