using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
/*
Written by: Alex Munoz
Learned from: Barnacules
Email: alex@napend.com
Company: napend
*/
namespace Magic8Ball
{
	// Abstract means you can't create instances
	/*abstract class Alex
    {
      private static string name = "Alex";
      public static string alias = "Cubed";
      private static int age = 12;
    }*/


	/// <summary>
	/// Entry point for Magic8Ball program (By: Alex Munoz)
	/// </summary>

	class program
	{
		
		static void Main(string[] args)
		{	

			// Stores the regulur color of the CMD or terminal
			ConsoleColor oldColor = Console.ForegroundColor;

			TellPeopleWhatProgramThisIs();

			// A randomizer object
			//Random randomObject = new Random ();

			// Loop forever!!!! Never stops
			while (true) 
			{

				string questionString = GetQuestionFromUser();

				// A randomizer object
				Random randomObject = new Random ();

				// Sets the thinking about answer to sleep
				int numberOfSecondsToSleep = randomObject.Next (5) + 1;
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("Thinking about your answer, stand by......");
				Thread.Sleep(numberOfSecondsToSleep * 1000);

				// Tells the user to type a question if they entered nothing
				if (questionString.Length == 0) 
				{
					Console.ForegroundColor = ConsoleColor.DarkMagenta;
					Console.WriteLine ("You need to type a question!");
					continue;
				}

				// See if the user types quit
				if (questionString.ToLower () == "quit") 
				{
					break;
				}

				// If they insult me than it tells them they suck and closses it.
				if (questionString.ToLower () == "you suck") 
				{
					Console.WriteLine ("You suck even more! Bye!");
					break;
				}
					
				// If they say Am i a good coder it says OMG YES!
				if (questionString.ToLower () == "am i a good coder")
				{
					Console.WriteLine ("OMG YES!");
					continue;
				}
					

				// Get a random number
				int randomNumber = randomObject.Next (4);



				// Use a random number to determin response
				switch (randomNumber) 
				{
				case 0:
					{
						Console.ForegroundColor = ConsoleColor.Yellow;
						Console.WriteLine ("YES!");
						break;
					}

				case 1:
					{
						Console.ForegroundColor = ConsoleColor.Magenta;
						Console.WriteLine ("NO!");
						break;
					}

				case 2:
					{
						Console.ForegroundColor = ConsoleColor.DarkCyan;
						Console.WriteLine ("HELL NO!");
						break;
					}

				case 3:
					{
						Console.ForegroundColor = ConsoleColor.Blue;
						Console.WriteLine ("OMG YES!");
						break;
					}
				} // End of the while loop
				// Cleaning Up
				Console.ForegroundColor = oldColor;
			}



		}


		/// <summary>
		/// This will print the name of the program and who
		/// created it to the console for us
		/// </summary>
		static void TellPeopleWhatProgramThisIs()
		{
			// Changes console text color to Red than Cyan
			Console.ForegroundColor = ConsoleColor.Red;
			Console.Write("Magic 8 Ball");
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine(" (By: Cubed)");
		}
			

		/// <summary>
		/// This function wiull return the text the user types
		/// </summary>
		/// <returns></returns>

		static string GetQuestionFromUser()
		{
			// This block of code will ask the user for a question
			// and store the question text in questionString variable
			Console.ForegroundColor = ConsoleColor.White;
			Console.Write ("Ask a question?: ");
			Console.ForegroundColor = ConsoleColor.DarkGray;
			string questionString = Console.ReadLine();

			return questionString;
		}

	}

}
