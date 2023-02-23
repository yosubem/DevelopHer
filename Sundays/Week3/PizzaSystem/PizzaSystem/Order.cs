using System;
using System.Collections.Generic;
using UtilityBelt;
using System.Linq;

namespace PizzaSystem {
	public class Order {
		List<Pizza> pizzaOrder = new List<Pizza>();

		public Pizza this[int i] {
			get { return pizzaOrder[i]; }
		}

		public int Count {
			get {
				return pizzaOrder.Count;
			}
		}

		/// <summary>
		/// Method<c>ShowPizzzaOrder</c> Prints out the pizzas with their toppings
		/// </summary>
		public override string ToString() {
			string order = string.Empty;

			for (int i = 0; i < pizzaOrder.Count; i++) {
				order += $"Pizza #{i + 1}: {pizzaOrder[i]} - {pizzaOrder[i].price} Money Units\n";
			}
			return order;
		}

		public void Add(Pizza pizza) {
			pizzaOrder.Add(pizza);
		}

		public float GetTotalOrderSum() {
			float total = 0;
			foreach(var p in pizzaOrder) {
				total += p.price;
			}
			Console.WriteLine(this);
			Console.WriteLine($"Your total order price is {total} Money Units\n");

			return total;
		}

		/// <summary>
		/// Method<c>RemovePizza</c> Removes a pizza from the order
		/// </summary>
		public void RemovePizza() {
			bool removeMore;
			int choice;
			bool removePizza;


			do {
				removeMore = false;
				Console.WriteLine("Which pizza would you like to remove? (You monster...)");
				Console.WriteLine(this);
				choice = Validation.GetIntInRange(1, Count);
				pizzaOrder.RemoveAt(choice - 1);

				Console.WriteLine("Pizza removed :( \n");

				if (Count > 0) {
					Console.WriteLine("Do you want to remove another? Y/N");
					removePizza = Validation.GetConfirmationString();
					if (removePizza) {
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
		public void RemovePizzasWithTopping() {
			HashSet<Topping> toppingsOnPizzas = new HashSet<Topping>();


			foreach (Pizza p in pizzaOrder) {
				toppingsOnPizzas.UnionWith(p.toppings);
			}

			List<Topping> toppings = toppingsOnPizzas.ToList();

			Console.WriteLine("Which topping will you like to remove? It will remove all pizzas with that topping\n");

			for(int i = 0; i < toppings.Count; i++) {
				Console.WriteLine($"{i + 1}. {toppings[i]}");
			}

			int choice = Validation.GetIntInRange(1, toppingsOnPizzas.Count);

			pizzaOrder.RemoveAll(p => p.toppings.Contains(toppings[choice - 1]));
			
		}


	}
}
