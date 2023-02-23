using System;
using System.Collections.Generic;
using System.Security.Policy;

namespace UtilityBelt {
	public static class Validation {
		/// <summary>
		/// Method<c> GetInt</c> Converts input into an int. If the input is not an int, asks for input again untill an int is given
		/// </summary>
		public static int GetInt() {
			bool isValid;
			int choice = 0;
			do {
				isValid = false;
				try {
					choice = Convert.ToInt32(Console.ReadLine());
					isValid = true;
				} catch (FormatException) {
					Console.WriteLine("Try again, please enter an integer");
				}
			} while (!isValid);

			return choice;
		}
		/// <summary>
		/// Method<c> IsIntInRange</c> Checks if an int is in a specified range
		/// </summary>
		public static bool IsIntInRange(int num, int min, int max) { 
			return (num >= min) && (num <= max);
		} 

		public static int GetIntInRange(int min, int max) {
			bool isValid;
			int num;

			do {
				num = GetInt();
				isValid = IsIntInRange(num, min, max);
				if (!isValid) {
					Console.WriteLine($"Number must be between {min} and {max}");
				}
			} while (!isValid);

			return num;

		}

		/// <summary>
		/// Method<c>GetConformationString</c> Checks if input is "yes"/"no" or "y"/"n"
		/// </summary>
		public static bool GetConfirmationString() {
			bool flag = false;
			string answer;
			bool confirmation = false;
			do {
				answer = Console.ReadLine().ToLower();
				if((answer == "y") || (answer == "yes")) {
					flag = true;
					confirmation = true;
				}else if((answer == "n") || (answer == "no")){
					flag = true;
					confirmation = false;
				}
				if (!flag) {
					Console.WriteLine("Try again, Please enter Yes/No (or if you really want, Y/N)");
				}

			} while (!flag);

			return confirmation;
		}
	}
}