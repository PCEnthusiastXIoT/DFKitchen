using System;
using System.Collections.Generic;
using System.Text;

namespace KitchenLib
{
    internal class Ingredient
    {
        public string Name { get; set; }
        public Unit Unit { get; set; }
        public float Quantity { get; set; }


        public (Unit unit, float quantity) GetAmount()
        {
            return (unit: this.Unit, quantity: this.Quantity);
        }
    }
}
