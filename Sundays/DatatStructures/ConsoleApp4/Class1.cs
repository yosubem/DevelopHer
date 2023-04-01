using System;
using System.Collections.Generic;

namespace DataStructureExercise {
	internal class TimedElement<T> {
		T _item;
		DateTime _expiration;
		
		public T Item { get { return _item; } }
		public DateTime Expiration { get { return _expiration; } }
		public TimedElement(T item, float duration) {
			this._item = item;
			this._expiration = DateTime.Now.AddSeconds(duration);
		}

		public override string ToString() {
			return $"item: {Item}, Expiration: {Expiration}";
			
		}
	}
}
