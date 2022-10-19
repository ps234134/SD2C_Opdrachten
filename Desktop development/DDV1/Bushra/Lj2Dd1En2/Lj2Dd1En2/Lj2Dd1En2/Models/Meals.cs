﻿using System;
using System.Configuration;
using System.Collections.Generic;
using System.Text;

namespace Lj2Dd1En2.Models
{
    public class Meal
    {
        private int mealId;
        public int MealId
        {
            get { return mealId; }
            set { mealId = value; }
        }
        private string name = null!;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string? description;
        public string? Description
        {
            get { return description; }
            set { description = value; }
        }
        private decimal price;
        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}
