using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Eindopdracht.models
{
    class DBconnection
    {
        SqlConnection _conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MySqlConnectionString"].ConnectionString);


        /// <summary>
        /// Dit is een lijst met alle Costumer van database 
        /// </summary>
        /// <returns>
        /// het returns een null als er een fout is.
        /// </returns>
        public List<Costumer> GetAllCostumers()
        {
            List<Costumer> result = new List<Costumer>();
            try
            {
                _conn.Open();
                SqlCommand sql = _conn.CreateCommand();
                sql.CommandText = "SELECT *  FROM dbo.costumer";
                SqlDataReader reader = sql.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(reader);
                foreach (DataRow row in table.Rows)
                {
                    Costumer costumer = new Costumer();
                    costumer.ID = (int)row["id"];
                    costumer.FirstName = (string)row["firstnaam"];
                    costumer.LastName = (string)row["lastnaam"];
                    result.Add(costumer);
                }

            }
            catch (Exception e)
            {

                Console.Write(e.Message);
                return null;
            }
            finally
            {
                if (_conn.State == ConnectionState.Open)
                {
                    _conn.Close();
                }
            }

            return result;
        }

        public List<Land> GetAllLanden()
        {
            List<Land> result = new List<Land>();
            try
            {
                _conn.Open();
                SqlCommand sql = _conn.CreateCommand();
                sql.CommandText = "SELECT *  FROM dbo.tbllanden";
                SqlDataReader reader = sql.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(reader);
                foreach (DataRow row in table.Rows)
                {
                    Land landen = new Land();
                    landen.Code = (int)row["code"];
                    landen.Naam = (string)row["omschrijving"];
                    landen.Image = (byte[])row["vlag"];
                    result.Add(landen);
                }

            }
            catch (Exception e)
            {

                Console.Write(e.Message);
                return null;
            }
            finally
            {
                if (_conn.State == ConnectionState.Open)
                {
                    _conn.Close();
                }
            }

            return result;
        }
        
        public List<CostumerFavCountry> GetAllFavLanden()
        {
            List<CostumerFavCountry> result = new List<CostumerFavCountry>();
            try
            {
                _conn.Open();
                SqlCommand sql = _conn.CreateCommand();
                sql.CommandText = "SELECT *  FROM dbo.CostumerFavLand";
                SqlDataReader reader = sql.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(reader);
                foreach (DataRow row in table.Rows)
                {
                    CostumerFavCountry Favlanden = new CostumerFavCountry();
                    Favlanden.ID = (int)row["id"];
                    Favlanden.CostumerId = (int)row["costumerid"];
                    Favlanden.CountryID = (int)row["landid"];
                    result.Add(Favlanden);
                }

            }
            catch (Exception e)
            {

                Console.Write(e.Message);
                return null;
            }
            finally
            {
                if (_conn.State == ConnectionState.Open)
                {
                    _conn.Close();
                }
            }

            return result;
        }

        public void SaveCosutmer(Costumer costumer)
        {
            _conn.Open();
            SqlCommand cmd = _conn.CreateCommand();
            if (costumer.ID < 1)
            {
                cmd.CommandText = "insert into dbo.costumer (firstnaam, lastnaam) values (@firstname, @lastname)";
            }

            cmd.Parameters.AddWithValue("@firstname", costumer.FirstName);
            cmd.Parameters.AddWithValue("@lastname", costumer.LastName);
            cmd.ExecuteNonQuery();
            _conn.Close();
        }
        public void SaveFavCountry(Costumer costumer, Land land)
        {
            _conn.Open();
            SqlCommand cmd = _conn.CreateCommand();
            if (costumer.ID > 0 && land.Code > 1)
            {
                cmd.CommandText = "insert into dbo.CostumerFavLand (costumerid, landid) values (@costumerid, @landid)";
            }

            cmd.Parameters.AddWithValue("@costumerid", costumer.ID);
            cmd.Parameters.AddWithValue("@landid", land.Code);
            cmd.ExecuteNonQuery();
            _conn.Close();
        }
        public void DeleteFavCountry(Land land)
        {
            _conn.Open();
            SqlCommand cmd = _conn.CreateCommand();
            if (land.Code > 1)
            {
                cmd.CommandText = "DELETE FROM dbo.CostumerFavLand Where landid = @landid";
            }

            cmd.Parameters.AddWithValue("@landid", land.Code);
            cmd.ExecuteNonQuery();
            _conn.Close();
        }


    }
}
