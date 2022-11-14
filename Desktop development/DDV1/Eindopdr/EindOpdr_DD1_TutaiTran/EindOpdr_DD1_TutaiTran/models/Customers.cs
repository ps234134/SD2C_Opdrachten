using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EindOpdr_DD1_TutaiTran.models
{
    public class Customers : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string? name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        #endregion
        //class for customerId and customerName
        private int customerId;

        public int CustomerId { get { return customerId; } set { customerId = value; OnPropertyChanged(); } }

        private string? customerName;

        public string? CustomerName {get { return customerName; } set { customerName = value; OnPropertyChanged(); } }
    }
}
