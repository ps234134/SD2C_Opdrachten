using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lj2Dd1En2.classes
{
    internal class carsDB
    {
        MySqlConnection _connection = new MySqlConnection("Server=localhost;Database=carsdb;Uid=root;Pwd=;");
        public DataTable SelectCarsInfo()
        {
            DataTable result = new DataTable();
            try
            {
                _connection.Open();
                MySqlCommand command = _connection.CreateCommand();
                command.CommandText = "SELECT * FROM cars;";
                MySqlDataReader reader = command.ExecuteReader();
                result.Load(reader);
            }
            catch (Exception)
            {

            }
            finally
            {
                _connection.Close();
            }
            return result;
        }

        //public string SelectCars(string CarName)
        //{


        //    string _year;
        //    DataTable result = new DataTable();

        //    _connection.Open();
        //    MySqlCommand cmd = _connection.CreateCommand();
        //    cmd.CommandText = "SELECT `yearOfIntroduction` FROM `cars` WHERE `make` = @Carname;";
        //    cmd.Parameters.AddWithValue("@Carname", CarName);
        //    MySqlDataReader rd = cmd.ExecuteReader();
            
        //    rd.Read();
        //    _year = rd.GetString(0);
            

        //    _connection.Close();
        //    return _year;


        //}

       


    }
}
