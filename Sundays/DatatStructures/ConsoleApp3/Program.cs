using ConsoleApp3;
using System;
using System.Collections;
using System.Collections.Generic;
namespace DataStructureExercise {
	class Program {
		static void Main() {

			StackedQueue stackedQueue = new StackedQueue();

			stackedQueue.Enqueue(314);
			stackedQueue.Enqueue(42);
			stackedQueue.Enqueue(2048);

			stackedQueue.PrintQueue();

			stackedQueue.Dequeue();

			stackedQueue.PrintQueue();
			
		}

	}
}