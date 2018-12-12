using System.Collections;
using System.Collections.Generic;

namespace DrinksApp
{
    public class Order : IEnumerable
    {
        public List<string> DrinkOrder { get; set; } = new List<string>();

        public IEnumerator GetEnumerator()
        {
            return DrinkOrder.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }


        //public IEnumerator GetEnumerator()
        //{
        //    //implement??

        //}

        public override string ToString()
        { 
           
            string OrderString = string.Empty;
            if (DrinkOrder.Count == 1)
            {
                foreach (var item in DrinkOrder)
                {
                    OrderString += item;
                }
            }
            else
            { 
                foreach (var item in DrinkOrder)
                {
                    OrderString += item + ", ";
                    
                }
            }
            return OrderString.TrimEnd(',', ' ');
        }
    }
}

