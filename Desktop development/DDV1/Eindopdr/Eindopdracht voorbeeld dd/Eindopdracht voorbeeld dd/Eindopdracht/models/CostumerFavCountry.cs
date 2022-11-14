using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindopdracht.models
{
    public class CostumerFavCountry
    {
        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private int costumerid;

        public int CostumerId
        {
            get { return costumerid; }
            set { costumerid = value; }
        }

        private int countryid;

        public int CountryID
        {
            get { return countryid; }
            set { countryid = value; }
        }

    }
}
