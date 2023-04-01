using System;
using System.Collections.Generic;
namespace DataStructureExercise {
	public class Class1 {
		public static void Main() {
			Queue<int> elements = new Queue<int>();

			elements.Enqueue(314);
			elements.Enqueue(42);
			elements.Enqueue(256);
			elements.Enqueue(7);
			elements.Enqueue(271);

			Console.WriteLine($"The minimum element in the queue: {FindMinimumElement(elements)}");
		}

		/*Makes a copy of the queue. Dequeue the first element and store it in a variable.
		 Then check if the first element in the queue is smaller than the one stored.
		If so, put it in the variable insted. When the queue is empty return the variable.*/
		static int FindMinimumElement(Queue<int> elements) {
			Queue<int> elementsCopy = elements; //Copy of the orignal queue
			int currMin;    //The current minimum element
			int temp;

			currMin = elements.Dequeue();

			do {
				temp = elements.Dequeue();
				if (currMin > temp) {
					currMin = temp;
				}

			} while (elementsCopy.Count > 0);

			return currMin;
		}
	}
}
