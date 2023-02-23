using System;
using System.Collections.Generic;
using System.Linq;
using UtilityBelt;

namespace PizzaSystem {
	public class Pizza {
		public List<Topping> toppings = new List<Topping>();
		public float price = 20;


		//Returns which toppings are on the pizza as a string
		public override string ToString() {
			return "Pizza with " + string.Join(", ", toppings);
		}

		//TODO: Next assignment, modify the menu to include 0 to stop adding toppings
		/// <summary>
		/// Method<c>AddingToppings</c> Adds toppings to a pizza. If all available toppings are allready on the pizza, exit the function
		/// </summary>
		public void AddToppings(Topping[] availableToppings) {
			List<Topping> availableToppingsForPizza = new List<Topping>(availableToppings);       //Initiliazing the list to be to have the same values as the array
			bool addMore;
			int topping;
			bool moreToppings;

			if (toppings.Count > 0) {
				availableToppingsForPizza.RemoveAll(t => toppings.Contains(t));
			}

			if (availableToppingsForPizza.Count == 0) {
				Console.WriteLine("No more toppings for you!");
				return;
			}

			do {
				addMore = false;
				Console.WriteLine("Please choose a topping by pressing the corresponding nummber");

				for (int i = 0; i < availableToppingsForPizza.Count; i++) {
					Console.WriteLine($"{i + 1}. {availableToppingsForPizza[i]} will cost an additional {availableToppingsForPizza[i].Price} Money Units");
				}

				topping = Validation.GetIntInRange(1, availableToppingsForPizza.Count);
				toppings.Add(availableToppingsForPizza[topping - 1]);
				price += availableToppingsForPizza[topping - 1].Price;
				availableToppingsForPizza.RemoveAt(topping - 1);
				if (availableToppingsForPizza.Count > 0) {
					Console.WriteLine("Do you want to add another topping? Y/N");
					moreToppings = Validation.GetConfirmationString();
					if (moreToppings) {
						addMore = true;
					}
				} else {
					Console.WriteLine("No more toppings for you!");
				}
			} while (addMore);
		}
	}
}

