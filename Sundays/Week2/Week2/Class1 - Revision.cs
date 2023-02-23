using System;
using System.Runtime.Serialization.Formatters;
using System.Security;

namespace WeekTwo{
	public static class MainClass {
		public static void Main() {
			int choice = 0;

			Console.WriteLine("Please choose a program to run: \n1.Weird operations\n2.Detect that TRAINGLE!\n3.Quit");
			
			try{
				choice = Convert.ToInt32(Console.ReadLine());
			}catch(FormatException){
				//Console.WriteLine("Invalid choice, goodbye");
				//If can't convert, choice will remain 0 and the switch will handle it
			}

			switch (choice) {
				case 1: 
					operationNum();
					break;
				case 2: 
					whichTriangle();
					break;
				case 3: 
					Console.WriteLine("You chose Quit, goodbye");
					break;
				default:
					Console.WriteLine("Not a valid choice, goodbye");
					break;
			}

			Console.ReadLine();

		}

		/// <summary>
		/// Method <c>checkingValuesFloats</c>Converts a string to an array of floats, if doesn't succeed returns null
		/// </summary>
		private static float[] checkingValuesFloats(string userInput){
			String[] nums = userInput.Split(' ');
			float[] floatNums = new float[nums.Length];

			try{
				for(int i = 0; i < nums.Length; i++){
					floatNums[i] = float.Parse(nums[i]);
				}

			}catch(FormatException){
				return null;
			}

			return floatNums;
		}

		/// <summary>
		/// Method<c>operationNum</c> Does weird operations on two numbers 10 times and prints the end result
		/// </summary>
		private static void operationNum(){
			Console.WriteLine("Please enter 2 numbers seperated by a space");
			string userInput = Console.ReadLine();

			float[] floats = checkingValuesFloats(userInput);

			if(floats == null){
				Console.WriteLine("You enterd invalid values");
				return;
			}

			float sum = floats[0] + floats[1];
			for(int i = 0; i < 10; i++){
				sum = -sum;
				sum /= 2f;
				sum *= 5;
			}

			Console.WriteLine($"The result is: {sum}");
		}

		/// <summary>
		/// Method <c> whichTriangle</c> Prints the type of the triangle based on the giving edges
		/// </summary>
		private static void whichTriangle(){
			Console.WriteLine("Please enter 3 edeges of a triangle seperated by spaces");
			string userInput = Console.ReadLine();

			float[] floats = checkingValuesFloats(userInput);
			if(floats == null){
				Console.WriteLine("You enterd invalid values");
				return;
			}

			//Thanks to Ori that reminded me about triangle properties
			//Checking that the sum of two edges is bigger than the third edge
			if((floats[0] + floats[1] <= floats[2]) || (floats[0] + floats[2] <= floats[1]) || (floats[1] + floats[2] <= floats[0])){
				Console.WriteLine("The numbers you entered cannot represent edges of a propper triangle");
				return;
			}

			//Checking which kind of triangle
			bool sides1 = Math.Abs(floats[0] - floats[1]) < float.Epsilon;
			bool sides2 = Math.Abs(floats[0] - floats[2]) < float.Epsilon;
			bool sides3 = Math.Abs(floats[1] - floats[2]) < float.Epsilon;

			if(sides1 && sides2 && sides3){
				Console.Write("This is a Equiangular Triangle");
			}else if(sides1 || sides2 || sides3){
				Console.Write("This is a Isosceles Triangle");
			}else{
				Console.WriteLine("This is a Scalene Triangle");
			}
			
		}
	}
}
