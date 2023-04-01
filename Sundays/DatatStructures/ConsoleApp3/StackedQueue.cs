using System;
using System.Collections.Generic;

namespace ConsoleApp3 {
	internal class StackedQueue{
		//I am not that good with naming stuff
		Stack<int> stackPrime;
		Stack<int> stackTemp;

		public StackedQueue() {
			stackPrime = new Stack<int>();
			stackTemp = new Stack<int>();
		}


		/*Pop every element from stack A and Push to stack B. Then, Push the new element to stack A.
		 Pop every element from stac B and Push to stack A.*/
		public void Enqueue(int item) {
			
			while(stackPrime.Count > 0) {
				stackTemp.Push(stackPrime.Pop());
			}

			stackPrime.Push(item);
			
			while(stackTemp.Count > 0) {
				stackPrime.Push(stackTemp.Pop());
			}
		}

		public int Dequeue() {
			return stackPrime.Pop();	
		}

		public void PrintQueue() {
			foreach(int e in stackPrime) {
				Console.WriteLine(e);
			}
		}
	}
	
}
