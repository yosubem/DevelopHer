using System.Collections.Generic;
using System.Linq;

namespace PizzaSystem2 {
	public class Pizza {
		public List<string> toppings = new List<string>();


		//Returns which toppings are on the pizza as a string
		public override string ToString() {
			string toppingsOnPizza = string.Empty;

			for(int i = 0; i < toppings.Count; i++) {
				toppingsOnPizza += toppings[i];
				if (i < toppings.Count - 1) {
					toppingsOnPizza += ", ";
				}
			}
			return toppingsOnPizza;
		}
	}
}
