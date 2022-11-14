using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using MySql.Data.MySqlClient;

namespace EindOpdr_DD1_TutaiTran.models
{
    internal class DBconnection
    {
        #region Messages
        public static readonly string UNKNOWN = "Unknown";
        public static readonly string OK = "Ok";
        public static readonly string NOTFOUND = "not found";
        private readonly string _conn = ConfigurationManager.ConnectionStrings["MySqlConnectionString"].ConnectionString; //connection string
        #endregion

        #region Customers
        // GetCustomers leest alle rijen in uit de databasetabel Meals en voegt deze toe aan een ICollection. 
        // Als de ICollection bij aanroep null is, volgt er een ArgumentException
        // De waarde van GetCustomers:
        // - "ok" als er geen fouten waren. 
        // - een foutmelding, als er wel fouten waten (mogelijk zijn niet alle Customers ingelezen)
        public string GetCustomers(ICollection<Customers> customers)
        {
            // if customers is empty show error message
            if (customers == null)
            {
                throw new ArgumentException("Ongeldig argument bij gebruik van GetCustomers");
            }
            string methodResult = UNKNOWN;
            //making connection with de database
            using (MySqlConnection conn = new MySqlConnection(_conn))
            {
                try
                {
                    conn.Open();
                    MySqlCommand sql = conn.CreateCommand();
                    sql.CommandText = @"
                    SELECT g.customer_id, g.customer
                    FROM customers g
                    ";
                    MySqlDataReader reader = sql.ExecuteReader();
                    while (reader.Read())
                    {
                        // add the database information from the query into customer from the Object Customers.
                        Customers customer = new Customers()
                        {

                            CustomerId = (int)reader["customer_id"],
                            CustomerName = (string)reader["customer"]
                        };

                        // puts the information from customer into the Icollection customers as an item
                        customers.Add(customer);
                    }
                    methodResult = OK;
                }
                catch (Exception e)
                {
                    Console.Error.WriteLine(nameof(GetCustomers));
                    Console.Error.WriteLine(e.Message);
                    methodResult = e.Message;
                }
            }
            return methodResult;
        }

        // CreateCustomers voegt een customer object uit de parameter toe aan de database. 
        // De customer object moet aan alle database eisen voldoen. De waarde van CreateCustomers:
        // - "ok" als er geen fouten waren. 
        // - een foutmelding (de melding geeft aan wat er fout was)
        public string CreateCustomers(Customers customers)
        {
            // if customers is empty show error message
            if (customers == null || string.IsNullOrEmpty(customers.CustomerName))
            {
                throw new ArgumentException("Ongeldig argument bij gebruik van GetCustomers");
            }
            string methodResult = UNKNOWN;
            //making connection with de database
            using (MySqlConnection conn = new MySqlConnection(_conn))
            {
                try
                {
                    conn.Open();
                    MySqlCommand sql = conn.CreateCommand();
                    sql.CommandText = @"
                    INSERT INTO customers (customer_id, customer)
                    VALUES (NULL, @customer);
                    ";
                    sql.Parameters.AddWithValue("@customer", customers.CustomerName);

                    if (sql.ExecuteNonQuery() == 1)
                    {
                        methodResult = OK;
                    }
                    else
                    {
                        methodResult = $"{customers.CustomerName} kon niet toegevoegd worden.";
                    }
                }
                catch (Exception e)
                {
                    Console.Error.WriteLine(nameof(CreateCustomers));
                    Console.Error.WriteLine(e.Message);
                    methodResult = e.Message;
                }
            }
            return methodResult;
        }

        // DeleteCustomer verwijdert de customer met de id customerId uit de database. De waarde
        // van DeleteCustomer :
        // - "ok" als er geen fouten waren. 
        // - een foutmelding (de melding geeft aan wat er fout was)
        public string DeleteCustomer(int customerId)
        {
            string methodResult = UNKNOWN;

            using (MySqlConnection conn = new(_conn))
            {
                try
                {
                    conn.Open();
                    MySqlCommand sql = conn.CreateCommand();
                    sql.CommandText = @"
                        DELETE 
                        FROM customers
                        WHERE customer_id = @customerId 
                    ";
                    sql.Parameters.AddWithValue("@customerId", customerId);
                    if (sql.ExecuteNonQuery() == 1)
                    {
                        methodResult = OK;
                    }
                    else
                    {
                        methodResult = $"Customer met id {customerId} kon niet verwijderd worden.";
                    }

                }
                catch (Exception e)
                {
                    Console.Error.WriteLine(nameof(DeleteCustomer));
                    Console.Error.WriteLine(e.Message);
                    methodResult = e.Message;
                }
            }
            return methodResult;
        }



        #endregion

        #region Countries
        // GetCountries leest alle rijen in uit de databasetabel Meals en voegt deze toe aan een ICollection. 
        // Als de ICollection bij aanroep null is, volgt er een ArgumentException
        // De waarde van GetCountries:
        // - "ok" als er geen fouten waren. 
        // - een foutmelding, als er wel fouten waten (mogelijk zijn niet alle Countries ingelezen)

        public string GetCountries(ICollection<Countries> countries)
        {
            // if gamers is empty show error message
            if (countries == null)
            {
                throw new ArgumentException("Ongeldig argument bij gebruik van GetCountries");
            }
            string methodResult = UNKNOWN;
            //making connection with de database
            using (MySqlConnection conn = new MySqlConnection(_conn))
            {
                try
                {
                    conn.Open();
                    MySqlCommand sql = conn.CreateCommand();
                    sql.CommandText = @"
                    SELECT g.country_id, g.countries
                    FROM countries g
                    ";
                    MySqlDataReader reader = sql.ExecuteReader();
                    while (reader.Read())
                    {
                        // add the database information from the query into country from the Object Countries.
                        Countries country = new Countries()
                        {

                            CountryId = (int)reader["country_id"],
                            CountryName = (string)reader["countries"]
                        };

                        // puts the information from country into the Icollection countries as an item
                        countries.Add(country);
                    }
                    methodResult = OK;
                }
                catch (Exception e)
                {
                    Console.Error.WriteLine(nameof(GetCountries));
                    Console.Error.WriteLine(e.Message);
                    methodResult = e.Message;
                }
            }
            return methodResult;
        }
        #endregion
    }
}
