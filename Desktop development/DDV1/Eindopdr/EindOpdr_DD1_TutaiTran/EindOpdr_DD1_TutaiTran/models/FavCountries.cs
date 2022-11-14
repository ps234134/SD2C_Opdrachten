using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EindOpdr_DD1_TutaiTran.models
{
    public class FavCountries
    {
        //class for fav countryId, customerId, countryId
        private int favCountryId;

        public int FavCountryId { get { return favCountryId; } set { favCountryId = value; } }

        private int customerId;

        public int CustomerId { get { return customerId; } set { customerId = value; } }

        private int countryId;

        public int CountryId { get { return countryId; } set { countryId = value; } }

       
    }
}
