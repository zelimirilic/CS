using System;
using DinerMax3000Console.Business;

namespace DinerMax3000Console
{
    class Program
    {
        static void Main(string[] args)
        {
            FoodMenu summerMenue = new FoodMenu();
            summerMenue.Name = "Summer Menue 2019";
            summerMenue.AddMenuItem("Salmon", "Fresh salmon from Oslo", 25.50);
            summerMenue.AddMenuItem("Taco", "Norge eat taco on Fridays", 10.05);
            summerMenue.HospitalDirections = "Right and left and Hospital is right there !";

            DrinkMenu outsideDrinks = new DrinkMenu();
            outsideDrinks.Disclaimer = "Do not drink !";
            outsideDrinks.AddMenuItem("Cuban", "Classic", 10);
            outsideDrinks.AddMenuItem("Screwdriver", "Kit", 15);

            Order orderHungryCustomer = new Order();
            for (int x = 0; x < summerMenue.items.Count; x++)
            {
                MenuItem currentitem = summerMenue.items[x];
                orderHungryCustomer.items.Add(currentitem);
            }

            foreach (MenuItem currentitem in outsideDrinks.items)
            {
                orderHungryCustomer.items.Add(currentitem);
            }

            Console.WriteLine("Total is: " + orderHungryCustomer.Total);

            try
            {
                outsideDrinks.AddMenuItem("Himchok", "Drink all!!", 0);
            }
            catch (Exception thrownException)
            {
                Console.WriteLine(thrownException.Message);
            }



        }
    }
}

