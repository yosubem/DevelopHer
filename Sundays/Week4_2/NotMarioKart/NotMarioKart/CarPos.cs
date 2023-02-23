using System;

namespace NotMarioKart {

	/// <summary>
	/// Class<c>CarPos</c> Handles everything about car movement 
	/// </summary>
	class CarPos {
		Car car;
		Track track;
		int cooldownCounter;
		int turnIndex;
		float currPos;
		float prevPos;
		float nextTurn;
		Random rand;


		public float CurrPos {
			get { return currPos; }
		}

		public CarPos(Car c, Track track) {
			car = c;
			this.track = track;
			cooldownCounter = 0;
			turnIndex = 0;
			currPos = 0;
			prevPos = 0;
			nextTurn = track.Turns[turnIndex];
			rand = new Random();
		}

		
		public void Move() {
			cooldownCounter++;
			prevPos = currPos;
			currPos += car.Speed;

			if(cooldownCounter >= car.BoostCooldown) {
				Console.WriteLine("Activated Boost!");
				currPos += car.BoostSpeed;
				cooldownCounter = 0;
			}

			Console.WriteLine($"Current position: {currPos}");
		}

		/// <summary>
		/// Method<c>Turn</c>Checks if successfully made the turn or not
		/// </summary>
		public void Turn() {
			
			if(nextTurn >= prevPos && nextTurn < currPos) {
				Console.WriteLine("Arrived at turn");
				if(rand.Next(1, 21) > car.DriftPower) {
					currPos = nextTurn;
					Console.WriteLine("Failed, Lakitu helped you");
				}

				if (turnIndex < track.Turns.Length - 1) {
					turnIndex++;
					nextTurn = track.Turns[turnIndex];
					Console.WriteLine($"Next turn at {nextTurn}");
				}
			}
		}


	}
}
