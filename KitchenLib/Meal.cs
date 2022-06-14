using System;
using System.Collections.Generic;
using System.Text;

namespace KitchenLib
{
    internal class Meal
    {
        public DateTime Date { get; set; }
        public List<Recipe> Courses { get; set; }
        public DateTime? Reminder { get; set; }
        public Mealtime Mealtime { get; set; }
    }
}
