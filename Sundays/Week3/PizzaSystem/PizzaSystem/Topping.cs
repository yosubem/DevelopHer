using System;
using System.Collections.Generic;

namespace PizzaSystem {
	public class Topping {
		string name;
		float price;

		public float Price {
			get {
				return price;
			}
		}

		public Topping(string name, float price) {
			this.name = name;
			this.price = price;
		}

		public override string ToString() {
			return name;
		}
	}
}
