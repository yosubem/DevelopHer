using System;
using System.Collections.Generic;
namespace DataStructureExercise {
	class Program {
		static void Main() {
			
			TimedQueue<int> queue = new TimedQueue<int>();

			queue.Enqueue(314, 3);
			queue.Enqueue(42, 2);
			queue.Enqueue(512, 3);

			queue.PrintQueue();
			Console.WriteLine();

			queue.Dequeue();
			queue.PrintQueue();
			Console.WriteLine();

			queue.Expire();
			queue.PrintQueue();
		}
	}
}