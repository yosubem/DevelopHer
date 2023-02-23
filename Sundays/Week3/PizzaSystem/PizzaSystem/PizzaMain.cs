using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaSystem2 {
	public class PizzaMain2 {
		public static void OldMain() {
			string[] availableToppings = new string[] { "Extra Cheese", "Green Olives", "Onions", "Mushrooms" }; //Keeping all the available toppings
			List<Pizza> pizzaOrder = new List<Pizza>();

			Console.WriteLine("Welcome to Pizza Pi!");
			MainMenu(pizzaOrder, availableToppings);

			Console.ReadLine();
		}
	
		static void MainMenu(List<Pizza> pizzaOrder, string[] availableToppings){
			int choice;
			int pizzaAmount;
			bool isTherePizza;

			do {
				isTherePizza = pizzaOrder.Count > 0;
				Console.WriteLine("Please choose an option:\n1.Add a pizza");
				if (isTherePizza) {
					Console.WriteLine("2.Add toppings to an exisiting pizza\n3.Remove pizza\n4.Remove pizzas with a spcecific topping");
				}
				Console.WriteLine("0.Quit");

				choice = ValidInt(0, isTherePizza ? 4 : 1);
				
				switch (choice) {
					case 1:
						Console.WriteLine("How many pizzas would you like to add?");
						pizzaAmount = ValidInt(1, 256);
						for (int i = 0; i < pizzaAmount; i++) {
							Console.WriteLine($"Pizza {i + 1}:\n");
							Pizza pizza = new Pizza();
							AddingToppings(pizza, availableToppings);
							pizzaOrder.Add(pizza);
						}
						break;
					case 2:
						AddMoreToppingsMenu(pizzaOrder, availableToppings);
						break;
					case 3:
						RemovePizza(pizzaOrder);
						break;
					case 4:
						RemovePizzaWithTopping(pizzaOrder);
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
		/// Method<c> ValidInt</c> Checks if the input is an int and if so, checks if it is in a specified range
		/// </summary>
		static int ValidInt(int min, int max) {
			bool isValid;
			int choice = 0;
			do {
				isValid = false;
				try {
					choice = Convert.ToInt32(Console.ReadLine());
					if ((choice >= min) && (choice <= max)) {
						isValid = true;
					} else {
						Console.WriteLine($"Not a vaild choice, enter a number between {min} and {max}");
					}
				} catch (FormatException) {
					Console.WriteLine("Try again, please enter an integer");
				}
			} while (!isValid);

			return choice;
		}
		

		/// <summary>
		/// Method<c>GetConformationString</c> Checks if input is "Y" or "N"
		/// </summary>
		static string GetConformationString() {
			bool flag;
			string answer = string.Empty;
			do {
				flag = false;
				answer = Console.ReadLine();
				flag = (answer == "Y" || answer == "N");
				if (!flag) {
					Console.WriteLine("Try again, Please enter Y/N");
				}
					
			}while(!flag);

			return answer;
		}

		/// <summary>
		/// Method<c>ShowPizzzaOrder</c> Prints out the pizzas with their toppings
		/// </summary>
		static void ShowPizzaOrder(List<Pizza> pizzaOrder) {
			for(int i = 0; i < pizzaOrder.Count; i++) {
				Console.WriteLine($"Pizza #{i + 1} with these toppings:\n" + pizzaOrder[i].ToString());
			}
		}

		/// <summary>
		/// Method<c>AddMoreToppingsMenu</c> Asks the user if they want to put more toppings on their pizzas
		/// </summary>
		static void AddMoreToppingsMenu(List<Pizza> pizzaOrder, string[] availableToppings){

			int choice;

			do {
				Console.WriteLine("What would you like to do:\n1.Add topping to pizza\n2.Go back");
				choice = ValidInt(1, 2);

				switch (choice) {
					case 1:
						ShowPizzaOrder(pizzaOrder);
						Console.WriteLine("Which pizza would you like to add a topping to:");
						int pizzaChoice = ValidInt(1, pizzaOrder.Count());
						AddingToppings(pizzaOrder[pizzaChoice - 1], availableToppings);
						break;
					case 2:
						break;
					default:
						Console.WriteLine("Not a valid choice");
						break;
				}
			} while (choice != 2);
			

		}
		/// <summary>
		/// Method<c>AddingToppings</c> Adds toppings to a pizza. If all available toppings are allready on the pizza, exit the function
		/// </summary>
		public static void AddingToppings(Pizza currentPizza, string[] availableToppings) {
			List<string> availableToppingsForPizza = new List<string>(availableToppings);       //Initiliazing the list to be to have the same values as the array
			bool addMore;
			int topping;
			string moreToppings;
			
			if(currentPizza.toppings.Count > 0){
				availableToppingsForPizza.RemoveAll(t => currentPizza.toppings.Contains(t));
			}

			if(availableToppingsForPizza.Count == 0) {
				Console.WriteLine("No more toppings for you!");
				return;
			}
			
			do {
				addMore = false;
				Console.WriteLine("Please choose a topping by pressing the corresponding nummber");

				for (int i = 0; i < availableToppingsForPizza.Count; i++) {
					Console.WriteLine($"{i + 1}. {availableToppingsForPizza[i]}");
				}

				topping = ValidInt(1, availableToppingsForPizza.Count);
				currentPizza.toppings.Add(availableToppingsForPizza[topping - 1]);
				availableToppingsForPizza.RemoveAt(topping - 1);
				if (availableToppingsForPizza.Count > 0) {
					Console.WriteLine("Do you want to add another topping? Y/N");
					moreToppings = GetConformationString();
					if (moreToppings == "Y") {
						addMore = true;
					}
				} else {
					Console.WriteLine("No more toppings for you!");
				}
			} while (addMore);

		}

		/// <summary>
		/// Method<c>RemovePizza</c> Removes a pizza from the order
		/// </summary>
		public static void RemovePizza(List<Pizza> pizzaList) {
			bool removeMore;
			int choice;
			string removePizza;


			do {
				removeMore = false;
				Console.WriteLine("Which pizza would you like to remove? (You monster...)");
				ShowPizzaOrder(pizzaList);
				choice = ValidInt(1, pizzaList.Count);
				pizzaList.RemoveAt(choice - 1);

				Console.WriteLine("Pizza removed :( \n");

				if (pizzaList.Count > 0) {
					Console.WriteLine("Do you want to remove another? Y/N");
					removePizza = GetConformationString();
					if (removePizza == "Y") {
						removeMore = true;
					}
				} else {
					Console.WriteLine("No more pizza for you");

				}
			} while (removeMore);
		}

		/// <summary>
		/// Method<c>RemovePizzaWithTopping</c> Asks the user which topping they would like to remove, and then removes all pizzas with that toppings, form the order
		/// </summary>
		//TODO: Change it when I understand LINQ :(
		public static void RemovePizzaWithTopping(List<Pizza> pizzaorder){
			List<string> toppingsOnPizzas = new List<string>();

			for(int i = 0; i < pizzaorder.Count; i++) {
				for(int j = 0; j < pizzaorder[i].toppings.Count; j++) {
					if (!toppingsOnPizzas.Contains(pizzaorder[i].toppings[j])){
						toppingsOnPizzas.Add(pizzaorder[i].toppings[j]);
					}
				}
			}
			Console.WriteLine("Which topping will you like to remove? It will remove all pizzas with that topping\n");
			for (int i = 0; i < toppingsOnPizzas.Count; i++) {
				Console.WriteLine($"{i + 1}.{toppingsOnPizzas[i]}");
			}
			int choice = ValidInt(1, toppingsOnPizzas.Count);
			pizzaorder.RemoveAll(p => p.toppings.Contains(toppingsOnPizzas[choice - 1]));

		}



	}
}

