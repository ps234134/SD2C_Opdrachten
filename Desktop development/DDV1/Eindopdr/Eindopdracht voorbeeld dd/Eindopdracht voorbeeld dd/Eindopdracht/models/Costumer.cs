using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Eindopdracht.models
{
    public class Costumer
    {

        private int id;
        private string firstName;
        private string lastName;

        public string FullName
        {
            get { return FirstName + " " + LastName; }
            set { }
        }


        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }


        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }


    }
}
