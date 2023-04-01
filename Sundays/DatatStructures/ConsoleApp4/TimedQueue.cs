using System;
using System.Collections.Generic;

namespace DataStructureExercise {
	internal class TimedQueue<T> {
		List<TimedElement<T>> timedQueue;
		public TimedQueue() { 
			timedQueue = new List<TimedElement<T>>();
		}

		public void Enqueue(T element, float duration) { 
			TimedElement<T> timedElement = new TimedElement<T>(element, duration);
			timedQueue.Add(timedElement);
		}

		public T Dequeue() {
			TimedElement<T> temp;

			do {
				temp = timedQueue[0];
				timedQueue.RemoveAt(0);
			} while ((timedQueue.Count == 0) || (IsExpired(temp)));

			return temp.Item;
		}

		public void Expire() {
			for(int i = timedQueue.Count - 1; i >= 0; i--) {
				if (IsExpired(timedQueue[i])) {
					timedQueue.RemoveAt(i);
				}
			}
		}

		public bool IsExpired(TimedElement<T> temp) {
			if (temp.Expiration < DateTime.Now) {
				return true;
			}
			return false;
		}


		public void PrintQueue() {
			for(int i = 0; i < timedQueue.Count; i++) {
				Console.WriteLine(timedQueue[i]);
			}
		}

	}
}
