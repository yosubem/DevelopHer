using System;
using System.Collections.Generic;


namespace VariousPrograms {
	public static class Program {
		public static void Main() {
			List<string> weirdPizza = new List<string> { "mushrooms", "peach", "goombas" };

			foreach (var t in weirdPizza) {
				Console.WriteLine($"{t}");
			}

			Console.ReadLine();
		}
	}
}
