using System;
using System.Collections.Generic;
namespace DataStructureExercise {
	class Program {
		public static void Main() {
			Queue<int> elements = new Queue<int>();

			elements.Enqueue(314);
			elements.Enqueue(42);
			elements.Enqueue(1024);
			elements.Enqueue(7);
			elements.Enqueue(271);

			ReverseQueue(elements);

			foreach (int element in elements) {
				Console.WriteLine(element);
			}
		}

		/*Dequeueing an element and checking if there is only one element left in the queue.
		 * If not, call the function again untill ther is only one element left. Then enqueue the elements.*/
		static void ReverseQueue(Queue<int> elements) {
			int temp = elements.Dequeue();
			if(elements.Count > 1) { 
				ReverseQueue(elements);
			}
			elements.Enqueue(temp);
		}
	}
}