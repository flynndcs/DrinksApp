using System;


namespace DrinksApp.Drinks.Data
{
    public class Menu
    {

        Order UserOrder = new Order();

        public static string[] DrinkCategories { get; private set; } = 
        {
            "Non-Alcoholic",
            "Alcoholic"
        };

        public static string[] NonAlcoholicDrinkCategories { get; private set; } =
        {
            "Hot",
            "Cold"
        };

        public static string[] AlcoholicDrinkCategories { get; private set; } =
        {
            "Beer",
            "Wine",
            "Liquor"
        };

        public static string[] NonAlcoholicHotDrinkCategories { get; private set; } =
        {
            "Coffee",
            "Tea"
        };

        public static string[] NonAlcoholicHotCoffeeDrinks { get; private set; } =
        {
            "Regular",
            "Decaf"
        };

        public static string[] NonAlcoholicHotTeaDrinks { get; private set; } =
        {
            "Black",
            "Green",
            "Herbal",
            "Oolong"
        };

        public static string[] NonAlcoholicColdMilkDrinkCategories { get; private set; } =
        {
            "Whole",
            "2%",
            "Skim",
        };

        public static string[] NonAlcoholicColdColaDrinks { get; private set; } =
        {
            "Coke",
            "Pepsi",
            "Dr. Pepper",
            "Sprite",
            "Root Beer",
            "Orange",
            "Grape",
            "Big Red"
        };

        public static string[] NonAlcoholicColdDrinkCategories { get; private set; } =
        {
            "Water",
            "Sparkling Water",
            "Milk",
            "Cola"
        };

        public static string[] AlcoholicBeerDrinks { get; private set; } =
        {
            "IPA",
            "Stout/Porter",
            "Ale",
            "Lager",
            "Sour",
            "Malt"
        };

        public static string[] AlcoholicWineDrinks { get; private set; } =
        {
            "Red",
            "White",
            "Sparkling",
            "Blend"
        };

        public static string[] AlcoholicLiquorDrinks { get; private set; } =
        {
            "Liquers",
            "Whiskey",
            "Vodka",
            "Gin",
            "Rum",
            "Tequila"
        };

        public void DisplayMenu()
        {
            
            Console.WriteLine("\nWelcome to the Bar! Select a drink category to get started.\n If you would like to close out, write Close Out.");
            SelectFromMenu();
            
        }

        public void SelectFromMenu()
        {
            Console.WriteLine("--------");
            foreach (var item in DrinkCategories)
            {
                Console.WriteLine(item);
            }
            string userInput = Console.ReadLine();
            if (userInput == "Non-Alcoholic")
            {
                Console.Clear();
                foreach (var category in NonAlcoholicDrinkCategories)
                {
                    Console.WriteLine(category);
                }
                userInput = Console.ReadLine();
                if (userInput == "Hot")
                {
                    Console.Clear();
                    foreach (var item in NonAlcoholicHotDrinkCategories)
                    {
                        Console.WriteLine(item);
                    }
                    userInput = Console.ReadLine();
                    if (userInput == "Coffee")
                    {
                        Console.Clear();
                        foreach (var item in NonAlcoholicHotCoffeeDrinks)
                        {
                            Console.WriteLine(item);
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
                            Console.WriteLine(item);
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
                        Console.WriteLine(item);
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
                            Console.WriteLine(item);
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
                            Console.WriteLine(item);
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
                foreach (var category in AlcoholicDrinkCategories)
                {
                    Console.WriteLine(category);
                }
                userInput = Console.ReadLine();
                if (userInput == "Beer")
                {
                    Console.Clear();
                    foreach (var item in AlcoholicBeerDrinks)
                    {
                        Console.WriteLine(item);
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
                        Console.WriteLine(item);
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
                        Console.WriteLine(item);
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
                Console.Clear();
                Console.WriteLine("The charge for your order is $X.");
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
            if (UserOrder.DrinkOrder.Count == 0)
            {
                UserOrder.DrinkOrder.Add(userInput);
            }
            else
            {
                UserOrder.DrinkOrder.Add(", " + userInput);
            }
            
            Console.Clear();
            Console.WriteLine("\n" + userInput + " has been added to your order.");
            Console.WriteLine("Order: \n " + UserOrder.ToString() + "\n");
            
            DisplayMenu();
        }
    }
}
