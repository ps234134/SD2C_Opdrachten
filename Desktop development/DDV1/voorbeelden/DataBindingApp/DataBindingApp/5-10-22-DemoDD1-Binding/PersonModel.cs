﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _5_10_22_DemoDD1_Binding
{
    public class PersonModel : ObservableObject
    {
		private string _name;

		public string Name
		{	
			get { return _name; }
			set 
			{ 
				_name = value;
                OnPropertyChanged();
            }
		}
	}
}