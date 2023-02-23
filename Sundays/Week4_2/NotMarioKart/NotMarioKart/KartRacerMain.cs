using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotMarioKart {
	class KartRacerMain {
		public static void Main(){

			Track track = new Track(100, 5);
			Car[] cars = new Car[3];

			cars[0] = new Car(2, 15, 6, 2);
			cars[1] = new Car(3, 10, 4, 3);
			cars[2] = new Car(4, 5, 3, 4);

			Race race = new Race(track, cars);

			race.Run();

			Console.ReadLine();


		}
	}
}
