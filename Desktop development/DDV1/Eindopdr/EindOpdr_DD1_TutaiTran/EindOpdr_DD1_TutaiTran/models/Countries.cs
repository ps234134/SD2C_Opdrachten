using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EindOpdr_DD1_TutaiTran.models
{
    public class Countries
    {
        //class for countryId and countryName
        private int countryId;

        public int CountryId { get { return countryId; } set { countryId = value; } }

        private string countryName;

        public string CountryName { get { return countryName; } set { countryName = value; } }
    }
}
