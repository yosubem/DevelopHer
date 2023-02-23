using System;
using System.Collections.Generic;


namespace NotMarioKart {
	 class Track {
		float length;
		float[] turns;

		public float Length {
			get { return length; }
		}

		public float[] Turns {
			get { return turns; }
		}

		public Track(float length, int numTurns) {
			this.length = length;

			float distance = length / numTurns;

			turns = new float[numTurns];

			for(int i = 0; i < turns.Length; i++) {
				turns[i] = i * distance;
			}

		}
	}
}
