using System;
namespace WeekOne {
	public static class MainClass{
		public static void Main(){
			string answer;
			bool flag;

			do{
				Console.WriteLine("Shell we play a game?");
				answer = Console.ReadLine().ToLower();
				flag = (answer == "yes") || (answer == "y") ||
						(answer == "no") || (answer == "n");

				if(flag){
					Console.WriteLine($"You said {answer}");
				}else{
					Console.WriteLine("Answer Yes/y or No/n");
				}
			}while(!flag);
		}
	}
}
			//string lowerAnswer;

			/*do{
				Console.WriteLine("Shell we play a game?");
				answer = Console.ReadLine();
				lowerAnswer = answer.ToLower();
				if ((lowerAnswer == "yes") || (lowerAnswer == "y") || (lowerAnswer == "no") || (lowerAnswer == "n")){
					Console.WriteLine($"You said {answer}");
					flag = true;
				}else{
					Console.WriteLine("Answer Yes/y or No/n");
				}
			}while (!flag);
			
			Console.ReadLine();*/

			/*do {
				Console.WriteLine("Shell we play a game?");
				answer = Console.ReadLine().ToLower();
				if ((answer == "yes") || (answer == "y") || (answer == "no") || (answer == "n")) {
					Console.WriteLine($"You said {answer}");
					flag = true;
				} else {
					Console.WriteLine("Answer Yes/y or No/n");
				}
			} while (!flag);

			Console.ReadLine();*/


		