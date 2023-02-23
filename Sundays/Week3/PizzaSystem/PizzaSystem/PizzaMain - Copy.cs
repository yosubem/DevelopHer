using System;
using System.Collections.Generic;
using System.Linq;
using UtilityBelt;

namespace PizzaSystem {
	public class PizzaMain {
		public static void Main() {
			//Keeping all the available toppings
			Topping[] availableToppings = {new Topping("Extra Cheese", 3),
											new Topping("Green Olives", 2),
											new Topping("Onions",2),
											new Topping("Mushrooms", 2)}; 
			Order pizzaOrder = new Order();
			Console.WriteLine("Welcome to Pizza Pi!");
			MainMenu(pizzaOrder, availableToppings);

			Console.ReadLine();
		}
	
		static void MainMenu(Order pizzaOrder, Topping[] availableToppings){
			int choice;
			int pizzaAmount;
			bool isTherePizza;

			do {
				isTherePizza = pizzaOrder.Count > 0;
				Console.WriteLine("Please choose an option:\n1.Add a pizza");
				if (isTherePizza) {
					Console.WriteLine("2.Add toppings to an exisiting pizza\n3.Remove pizza\n4.Remove pizzas with a spcecific topping\n5.Show total order price");
				}
				Console.WriteLine("0.Quit");

				choice = Validation.GetIntInRange(0, isTherePizza ? 5 : 1);
				
				switch (choice) {
					case 1:
						Console.WriteLine("How many pizzas would you like to add?");
						pizzaAmount = Validation.GetIntInRange(1, 256);
						for (int i = 0; i < pizzaAmount; i++) {
							Console.WriteLine($"Pizza {i + 1}:\n");
							Pizza pizza = new Pizza();
							pizza.AddToppings(availableToppings);
							pizzaOrder.Add(pizza);
						}
						break;
					case 2:
						AddMoreToppingsMenu(pizzaOrder, availableToppings);
						break;
					case 3:
						pizzaOrder.RemovePizza();
						break;
					case 4:
						pizzaOrder.RemovePizzasWithTopping();
						break;
					case 5:
						pizzaOrder.GetTotalOrderSum();
						break;
					case 0:
						Console.WriteLine("Okay, bye");
						break;
					default:
						Console.WriteLine("Not a valid choice");
						break;
				}
			} while (choice != 0);
		}

		/// <summary>
		/// Method<c>AddMoreToppingsMenu</c> Asks the user if they want to put more toppings on their pizzas
		/// </summary>
		static void AddMoreToppingsMenu(Order pizzaOrder, Topping[] availableToppings) {

			int choice;

			do {
				Console.WriteLine("What would you like to do:\n1.Add topping to pizza\n2.Go back");
				choice = Validation.GetIntInRange(1, 2);

				switch (choice) {
					case 1:
						Console.WriteLine(pizzaOrder);
						Console.WriteLine("Which pizza would you like to add a topping to:");
						int pizzaChoice = Validation.GetIntInRange(1, pizzaOrder.Count);
						pizzaOrder[pizzaChoice - 1].AddToppings(availableToppings);
						break;
					case 2:
						break;
					default:
						Console.WriteLine("Not a valid choice");
						break;
				}
			} while (choice != 2);
		}
	}
}

