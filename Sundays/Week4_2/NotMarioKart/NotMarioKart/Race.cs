using System;

namespace NotMarioKart {

	/// <summary>
	/// Class<c>Race</c> Handles a race
	/// </summary>
	class Race {
		Track track;
		CarPos[] carPoss;

		public Race(Track t, Car[] cars) {
			track = t;
			carPoss = new CarPos[cars.Length];

			for(int i = 0; i < cars.Length; i++) {
				carPoss[i] = new CarPos(cars[i], track);
			}
		}

		public void Run() {
			int leaderIdx = 0;

			do {
				Console.WriteLine("New round:\n");
				for (int i = 0; i < carPoss.Length; i++) {
					Console.WriteLine($"Car #{i}:");
					carPoss[i].Move();
					carPoss[i].Turn();

					if (carPoss[i].CurrPos > carPoss[leaderIdx].CurrPos) {
						leaderIdx = i;
						Console.WriteLine($"Car #{i} has the lead");
					}
					Console.WriteLine("\n");
				}

			} while (carPoss[leaderIdx].CurrPos < track.Length);

			Console.WriteLine($"Car #{leaderIdx} is the winner!");
		}
	}
}
