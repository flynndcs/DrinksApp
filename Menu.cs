using System;
using System.Collections.Generic;

namespace DrinksApp.Drinks.Data
{
    public class Menu
    {

        Order UserOrder = new Order();

        public static Dictionary<string, int> DrinkCategories { get; private set; } = new Dictionary<string, int>
        {
            { "Non-Alcoholic", 0 },
            { "Alcoholic", 0 }
        };

        public static Dictionary<string, int> NonAlcoholicDrinkCategories { get; private set; } = new Dictionary<string, int>
        {
            { "Hot", 0 },
            { "Cold", 0 }
        };

        public static Dictionary<string, int> AlcoholicDrinkCategories { get; private set; } = new Dictionary<string, int>
        {
            { "Beer", 0 },
            { "Wine", 0 },
            { "Liquor", 0 }
        }; 

        public static Dictionary<string, int> NonAlcoholicHotDrinkCategories { get; private set; } = new Dictionary<string, int>
        {
            {"Coffee", 0 },
            { "Tea", 0 }
        };

        public static Dictionary<string, int> NonAlcoholicHotCoffeeDrinks { get; private set; } = new Dictionary<string, int>
        {
            { "Regular", 2 },
            { "Decaf", 2 }
        };

        public static Dictionary<string, int> NonAlcoholicHotTeaDrinks { get; private set; } = new Dictionary<string, int>
        {
            { "Black", 3 },
            { "Green", 3 },
            { "Herbal", 4 },
            { "Oolong", 5 }
        };

        public static Dictionary<string, int> NonAlcoholicColdMilkDrinkCategories { get; private set; } = new Dictionary<string, int>
        {
            { "Whole", 3 },
            { "2%", 3 },
            { "Skim", 3 }
        };

        public static Dictionary<string, int> NonAlcoholicColdColaDrinks { get; private set; } = new Dictionary<string, int>
        {
            { "Coke", 3 },
            { "Pepsi", 3 },
            { "Dr. Pepper", 3 },
            { "Sprite", 3 },
            { "Root Beer", 4 },
            { "Orange", 3 },
            { "Grape", 3 },
            { "Big Red", 3 }
        };

        public static Dictionary<string, int> NonAlcoholicColdDrinkCategories { get; private set; } = new Dictionary<string, int>
        {
            { "Water", 1 },
            { "Sparkling Water", 2 },
            { "Milk", 0 },
            { "Cola", 0 }
        };

        public static Dictionary<string, int> AlcoholicBeerDrinks { get; private set; } = new Dictionary<string, int>
        {
            { "IPA", 6 },
            { "Stout/Porter", 7 },
            { "Ale", 5 },
            { "Lager", 4 },
            { "Sour", 7 },
            { "Malt", 4 }
        };

        public static Dictionary<string, int> AlcoholicWineDrinks { get; private set; } = new Dictionary<string, int>
        {
            { "Red", 7 },
            { "White", 6 },
            { "Sparkling", 5 },
            { "Blend", 4 }
        };

        public static Dictionary<string, int> AlcoholicLiquorDrinks { get; private set; } = new Dictionary<string, int>
        {
            { "Liquers", 4 },
            { "Whiskey", 6 },
            { "Vodka", 5 },
            { "Gin", 5 },
            { "Rum", 6 },
            { "Tequila", 6 }
        };

        public static Dictionary<string, int> MasterPriceList { get; private set; } = new Dictionary<string, int>
        {
            { "Regular", 2 },
            { "Decaf", 2 },
            { "Black", 3 },
            { "Green", 3 },
            { "Herbal", 4 },
            { "Oolong", 5 },
            { "Whole", 3 },
            { "2%", 3 },
            { "Skim", 3 },
            { "Coke", 3 },
            { "Pepsi", 3 },
            { "Dr. Pepper", 3 },
            { "Sprite", 3 },
            { "Root Beer", 4 },
            { "Orange", 3 },
            { "Grape", 3 },
            { "Big Red", 3 },
            { "Water", 1 },
            { "Sparkling Water", 2 },
            { "IPA", 6 },
            { "Stout/Porter", 7 },
            { "Ale", 5 },
            { "Lager", 4 },
            { "Sour", 7 },
            { "Malt", 4 },
            { "Red", 7 },
            { "White", 6 },
            { "Sparkling", 5 },
            { "Blend", 4 },
            { "Liquers", 4 },
            { "Whiskey", 6 },
            { "Vodka", 5 },
            { "Gin", 5 },
            { "Rum", 6 },
            { "Tequila", 6 }

        };

        public void DisplayMenu()
        {
            
            Console.WriteLine("\nWelcome to the Bar! Select a drink category to get started.\nIf you would like to close out, write Close Out.");
            SelectFromMenu();
            
        }

        public void SelectFromMenu()
        {
            Console.WriteLine("--------");
            foreach (var item in DrinkCategories)
            {
                string MenuItem = item.Key;
                Console.WriteLine(MenuItem);
            }
            string userInput = Console.ReadLine();
            if (userInput == "Non-Alcoholic")
            {
                Console.Clear();
                foreach (var item in NonAlcoholicDrinkCategories)
                {
                    string MenuItem = item.Key;
                    Console.WriteLine(MenuItem);
                }
                //var dic = NonAlcoholicDrinkCategories;
                userInput = Console.ReadLine();
                if (userInput == "Hot")
                {
                    Console.Clear();
                    foreach (var item in NonAlcoholicHotDrinkCategories)
                    {
                        string MenuItem = item.Key;
                        Console.WriteLine(MenuItem);
                    }
                    userInput = Console.ReadLine();
                    if (userInput == "Coffee")
                    {
                        Console.Clear();
                        foreach (var item in NonAlcoholicHotCoffeeDrinks)
                        {
                            Console.WriteLine(item.ToString().Trim('[', ']'));
                        }
                        userInput = Console.ReadLine();
                        if (userInput == "Regular")
                        {
                            MenuOrder(userInput);
                        }
                        else if (userInput == "Decaf")
                        {
                            MenuOrder(userInput);

                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Please enter a valid input.");
                            SelectFromMenu();
                        }

                    }
                    else if (userInput == "Tea")
                    {
                        Console.Clear();
                        foreach (var item in NonAlcoholicHotTeaDrinks)
                        {
                            Console.WriteLine(item.ToString().Trim('[', ']'));
                        }
                        userInput = Console.ReadLine();
                        if (userInput == "Black")
                        {
                            MenuOrder(userInput);
                        }
                        else if (userInput == "Green")
                        {
                            MenuOrder(userInput);
                        }
                        else if (userInput == "Herbal")
                        {
                            MenuOrder(userInput);
                        }
                        else if (userInput == "Oolong")
                        {
                            MenuOrder(userInput);
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Please enter a valid input.");
                            SelectFromMenu();
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Please enter a valid input");
                        SelectFromMenu();
                    }
                }
                else if (userInput == "Cold")
                {
                    Console.Clear();
                    foreach (var item in NonAlcoholicColdDrinkCategories)
                    {
                        string MenuItem = item.Key;
                        Console.WriteLine(MenuItem);
                    }
                    userInput = Console.ReadLine();
                    if (userInput == "Water")
                    {
                        MenuOrder(userInput);
                    }
                    else if (userInput == "Sparkling Water")
                    {
                        MenuOrder(userInput);
                    }
                    else if (userInput == "Milk")
                    {
                        Console.Clear();
                        foreach (var item in NonAlcoholicColdMilkDrinkCategories)
                        {
                            Console.WriteLine(item.ToString().Trim('[', ']'));
                        }
                        if (userInput == "Skim")
                        {
                            MenuOrder(userInput);
                        }
                        else if (userInput == "2%")
                        {
                            MenuOrder(userInput);
                        }
                        else if (userInput == "Whole")
                        {
                            MenuOrder(userInput);
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Please enter a valid input.");
                            SelectFromMenu();
                        }
                    }
                    else if (userInput == "Cola")
                    {
                        Console.Clear();
                        foreach (var item in NonAlcoholicColdColaDrinks)
                        {
                            Console.WriteLine(item.ToString().Trim('[', ']'));
                        }
                        userInput = Console.ReadLine();
                        if (userInput == "Coke")
                        {
                            MenuOrder(userInput);
                        }
                        else if (userInput == "Pepsi")
                        {
                            MenuOrder(userInput);
                        }
                        else if (userInput == "Dr. Pepper")
                        {
                            MenuOrder(userInput);
                        }
                        else if (userInput == "Sprite")
                        {
                            MenuOrder(userInput);
                        }
                        else if (userInput == "Root Beer")
                        {
                            MenuOrder(userInput);
                        }
                        else if (userInput == "Orange")
                        {
                            MenuOrder(userInput);
                        }
                        else if (userInput == "Grape")
                        {
                            MenuOrder(userInput);
                        }
                        else if (userInput == "Big Red")
                        {
                            MenuOrder(userInput);
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Please enter a valid input");
                            SelectFromMenu();
                        }
                        
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Please enter a valid input");
                        SelectFromMenu();
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Please enter a valid input");
                    SelectFromMenu();
                }
            }
            else if (userInput == "Alcoholic")
            {
                Console.Clear();
                foreach (var item in AlcoholicDrinkCategories)
                {
                    string MenuItem = item.Key;
                    Console.WriteLine(MenuItem);
                }
                userInput = Console.ReadLine();
                if (userInput == "Beer")
                {
                    Console.Clear();
                    foreach (var item in AlcoholicBeerDrinks)
                    {
                        Console.WriteLine(item.ToString().Trim('[', ']'));
                    }
                    userInput = Console.ReadLine();
                    if (userInput == "IPA")
                    {
                        MenuOrder(userInput);
                    }
                    else if (userInput == "Stout/Porter")
                    {
                        MenuOrder(userInput);
                    }
                    else if (userInput == "Ale")
                    {
                        MenuOrder(userInput);
                    }
                    else if (userInput == "Lager")
                    {
                        MenuOrder(userInput);
                    }
                    else if (userInput == "Sour")
                    {
                        MenuOrder(userInput);
                    }
                    else if (userInput == "Malt")
                    {
                        MenuOrder(userInput);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Please enter a valid input");
                        SelectFromMenu();

                    }
                }
                else if (userInput == "Wine")
                {
                    Console.Clear();
                    foreach (var item in AlcoholicWineDrinks)
                    {
                        Console.WriteLine(item.ToString().Trim('[', ']'));
                    }
                    userInput = Console.ReadLine();
                    if (userInput == "Red")
                    {
                        MenuOrder(userInput);
                    }
                    else if (userInput == "White")
                    {
                        MenuOrder(userInput);
                    }
                    else if (userInput == "Sparkling")
                    {
                        MenuOrder(userInput);
                    }
                    else if (userInput == "Blend")
                    {
                        MenuOrder(userInput);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Please enter a valid input");
                        SelectFromMenu();
                    }
                }
                else if (userInput == "Liquor")
                {
                    Console.Clear();
                    foreach (var item in AlcoholicLiquorDrinks)
                    {
                        Console.WriteLine(item.ToString().Trim('[',']'));
                    }
                    userInput = Console.ReadLine();
                    if (userInput == "Liquers")
                    {
                        MenuOrder(userInput);
                    }
                    else if (userInput == "Whiskey")
                    {
                        MenuOrder(userInput);
                    }
                    else if (userInput == "Vodka")
                    {
                        MenuOrder(userInput);
                    }
                    else if (userInput == "Gin")
                    {
                        MenuOrder(userInput);
                    }
                    else if (userInput == "Rum")
                    {
                        MenuOrder(userInput);
                    }
                    else if (userInput == "Tequila")
                    {
                        MenuOrder(userInput);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Please enter a valid input");
                        SelectFromMenu();
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Please enter a valid input");
                    
                    SelectFromMenu();
                }
            }
            else if (userInput == "Close Out")
            {
                int OrderSum = 0;
                Console.Clear();
                foreach (string item in UserOrder)
                {
                    OrderSum = OrderSum + MasterPriceList[item];
                }
                Console.WriteLine(UserOrder.ToString());
                Console.WriteLine("---------\nThe charge for your order is $" + OrderSum +".\nPlease enter your name.");
                var DrinkCustomer = new Customer(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Thank you, " + DrinkCustomer.CustomerName + ".");
                Console.ReadLine();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Please enter a valid input");
                
                SelectFromMenu();
            }
        }

        public void MenuOrder(string userInput)
        {

            UserOrder.DrinkOrder.Add(userInput);
            
            Console.Clear();
            Console.WriteLine("\n" + userInput + " has been added to your order.");
            Console.WriteLine("Order: \n" + UserOrder.ToString() + "\n");
            
            DisplayMenu();
        }
    }
}
