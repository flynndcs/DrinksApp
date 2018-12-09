using System.Collections.Generic;

namespace DrinksApp
{
    public class Order
    {
        public List<string> DrinkOrder { get; set; } = new List<string>();

        public override string ToString()
        {
            string OrderString = "";
            foreach (var item in DrinkOrder)
            {
                OrderString += item;
            }
            return OrderString;
        }
    }
}

