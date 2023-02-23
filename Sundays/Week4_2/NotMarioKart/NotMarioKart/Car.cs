using System;
using System.Collections.Generic;


namespace NotMarioKart {
	class Car {
		float speed;
		float driftPower;
		float boostSpeed;
		int boostCooldown;

		public float Speed{
			get { return speed; }
		}

		public float DriftPower {
			get { return driftPower; }
		}

		public float BoostSpeed {
			get { return boostSpeed; }
		}

		public int BoostCooldown {
			get { return boostCooldown; }
		}

		public Car(float speed, float driftPower, float boostSpeed, int boostCooldown) {
			this.speed = speed;
			this.driftPower = driftPower;
			this.boostSpeed = boostSpeed;
			this.boostCooldown = boostCooldown;
		}
	}
}
