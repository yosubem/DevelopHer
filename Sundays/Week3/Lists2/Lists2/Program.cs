using System;
using System.Collections.Generic;

namespace Class1 {
	public static class MainClass {
		public class Class1 {
			public static void Main() {
				/*	List<int> list = new List<int> { 1, 2, 3, 4, 5 };
					Console.WriteLine($"{list[0]}");
					Console.WriteLine($"{list[4]}");
					Console.WriteLine($"{list[5]}");
					list.Clear();
					Console.WriteLine($"{list[0]}");

					Console.ReadLine();

				}*/

				int i = 0;
				List<int> list = new List<int> { 1, 2, 3};
				func1(i);

				Console.WriteLine($"{i}");
				func2(list);
				Console.WriteLine($"{list[0]}");

				Console.ReadLine();

			}
			private static void func1(int i) {
				i += 1;
			}


			private static void func2(List <int> list){
				list[0] += 1;
			}

		}
	}
}