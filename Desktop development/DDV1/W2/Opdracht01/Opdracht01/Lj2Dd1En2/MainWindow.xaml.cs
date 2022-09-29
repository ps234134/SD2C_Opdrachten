﻿using System;
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

using Microsoft.Win32;
using System.IO;
using Lj2Dd1En2.classes;
using System.Data;
using MySqlConnector;




namespace Lj2Dd1En2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        carsDB _carsDB = new carsDB();
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=carsdb;Uid=root;Pwd=;");

        byte[]? nieuw;
        byte[]? wijzig;
        public MainWindow()
        {
            InitializeComponent();
            fillLb();
       
        }


        void fillLb()
        {


            DataTable cars = _carsDB.SelectCarsInfo();
            if (cars != null)
            {
                LbAutos.ItemsSource = cars.DefaultView;
                LbAutos.DisplayMemberPath = "make";
            }
        }



        private void LbAutos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
  

            ListBox dg = sender as ListBox;
            DataRowView dr = dg.SelectedItem as DataRowView;

            string table = dr["picture"].ToString();

  

            if (dr != null)
            {
                TbMerk1.Text = dr["make"].ToString();
                TbJaar1.Text = dr["yearOfIntroduction"].ToString();
              

            }

            if (dr["picture"] == DBNull.Value)
            {
                wijzig = null;
                imgAfbeelding1.Source = null;
            }
            else
            {
                wijzig = (byte[])dr["picture"];
                imgAfbeelding1.Source = new ImageSourceConverter().ConvertFrom(wijzig) as ImageSource;
            }


        }

        private void BtnUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (LbAutos.SelectedItem == null)
            {
                MessageBox.Show("U heeft een auto geselecteerd");
                return;
            }
            if (string.IsNullOrEmpty(TbMerk1.Text))
            {
                MessageBox.Show("Vul het merk van de auto in.");
                return;
            }
            if (string.IsNullOrEmpty(TbJaar1.Text))
            {
                MessageBox.Show("Vul het introductiejaar van de auto in.");
                return;
            }

            if (!int.TryParse(TbJaar1.Text, out int jaar) || jaar < 1769)
            {
                MessageBox.Show("Het introductiejaar mag alleen uit cijfers bestaan en mag niet voor 1769 liggen.");
                return;
            }

            try
            {
                DataTable t = new();
                con.Open();
                MySqlCommand hulp = con.CreateCommand();
                hulp.CommandText =
                    $"UPDATE cars SET make= '{TbMerk1.Text}',picture = @picture, yearOfIntroduction = {TbJaar1.Text} " +
                    $" WHERE carId = {LbAutos.SelectedValue};";
                hulp.Parameters.AddWithValue("@picture", wijzig);
                t.Load(hulp.ExecuteReader());
                LbAutos.ItemsSource = t.DefaultView;
                con.Close();
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

        private void BtnCreate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                con.Open();
                MySqlCommand sql = con.CreateCommand();
                sql.CommandText =
                    $"INSERT INTO cars(carId,  make,  picture, yearOfIntroduction) " +
                    $"         VALUES ( null, @make, @picture, {TbJaar1.Text});";
                sql.Parameters.AddRange(
                    new[]   {
                    new MySqlParameter(){ ParameterName = "@make", Value = TbMerk2.Text},
                    new MySqlParameter(){ ParameterName = "@picture", Value = nieuw, }
                        }
                    );
                sql.ExecuteReader();
                con.Close();
                fillLb();

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "DELETE FROM cars WHERE cars.make = '" + TbMerk1.Text + "'";

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record has been deleted", "Deleted", MessageBoxButton.OK, MessageBoxImage.Information);
                con.Close();
                TbMerk1.Text = null;
                //imgAfbeelding1 = "";
                TbJaar1.Text = null;
                fillLb();
            }
            catch (MySqlException ex)
            {

                MessageBox.Show("Not deleted" + ex.Message);
            }
            System.Diagnostics.Process.Start(Application.ResourceAssembly.Location);
        }

        private void BtnAfbeelding1_Click(object sender, RoutedEventArgs e)
        {
            byte[]? afbeelding = GetLocalPicture();
            if (afbeelding != null)
            {
                imgAfbeelding1.Source =
                    new ImageSourceConverter().ConvertFrom(afbeelding) as ImageSource;
            }
        }

        private void BtnAfbeelding2_Click(object sender, RoutedEventArgs e)
        {
            nieuw = GetLocalPicture();
            if (nieuw != null)
            {
                imgAfbeelding2.Source =
                    new ImageSourceConverter().ConvertFrom(nieuw) as ImageSource;
            }
            else
            {
                imgAfbeelding2.Source = null;
            }
        }

        #region GetLocalPicture
        // GetLocalPicture leest een afbeelding op je computer in een array van byte in.
        // GetLocalPicture heef de volgende waarden:
        // - null: geen afbeelding ingelezen
        // - ongelijk null: de ingelezen afbeelding
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

        private void TbJaar2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
