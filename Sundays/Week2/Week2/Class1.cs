using System;
using System.Runtime.Serialization.Formatters;
using System.Security;

namespace WeekTwo2 {
	public static class MainClass {
		public static void Main2() {

			Console.WriteLine("Please enter the appropriate values according to the instructions, use space for separation:\n 1.Enter 2 numbers and I will do some operations on them\n OR \n 2.Enter 3 edges of a triangle and I'll tell you which kind of a trinagle it is\n Please enter the numbers: ");
			String[] nums = Console.ReadLine().Split(' ');
			float[] floatNums = new float[nums.Length];

			//Check if the input is valid, if not print out an error message
			try{
				for(int i = 0; i < nums.Length; i++){
					floatNums[i] = float.Parse(nums[i]);
				}

				//Checking the length of the array and calls the appropriate function accordingly
				if(floatNums.Length == 3) {
					if((floatNums[0] > 0) && (floatNums[1] > 0) && (floatNums[2] > 0)){
						whichTriangle(floatNums[0], floatNums[1], floatNums[2]);
					}else{
						Console.WriteLine("Triangle edges must be positive numbers, goodbye");
						Console.ReadLine();
					}
				}else if(floatNums.Length == 2) {
					operationNum(floatNums[0], floatNums[1]);
				}else{
					Console.WriteLine("You entered the wrong amount of numbers, goodbye");
					Console.ReadLine();
				}
			}catch{
				Console.WriteLine("You entered invalid input, goodbye");
				Console.ReadLine();
			}

		}
		/// <summary>
		/// Method<c>operationNum</c> Does weird operations on two numbers 10 times and prints the end result
		/// </summary>
		private static void operationNum(float num1, float num2){
			float sum = num1 + num2;
				
			for(int i = 0; i < 10; i++){
				sum = -sum;
				sum = sum / 2f;
				sum = sum * 5;
			}

			Console.WriteLine($"The result is: {sum}");
			Console.ReadLine();
		}

		/// <summary>
		/// Method <c> whichTriangle</c> Prints the type of the triangle based on the giving edges
		/// </summary>
		private static void whichTriangle(float side1, float side2, float side3) {
			bool sides1 = side1 == side2;
			bool sides2 = side1 == side3;
			bool sides3 = side2 == side3;


			if(sides1){
				if(sides2){
					Console.Write("This is a Equiangular Triangle");
				}else{
					Console.Write("This is a Isosceles Triangle");
				}
			}else if(sides2 || sides3) {
				Console.WriteLine("This is a Isosceles Triangle");
			}else{
				Console.WriteLine("This is a Scalene Triangle");
			}

			Console.ReadLine();
		}
	}
}
