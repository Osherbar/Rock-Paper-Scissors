using System;
using AppKit;
using Foundation;

namespace r
{
	public partial class ViewController : NSViewController
		{
		string userChoice = "null";
		string pcChoice = "null";
		int randPcChoise = 0;
        string[] pcOptions = { "rock", "paper", "scissors" };


        public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			// Do any additional setup after loading the view.
		}

		public override NSObject RepresentedObject {
			get {
				return base.RepresentedObject;
			}
			set {
				base.RepresentedObject = value;
				// Update the view, if already loaded.
			}
		}

        public static class RandomNumberGenerator
        {
            private static readonly Random rand = new Random();

            public static int GenerateRandomNumber(int min, int max)
            {
                return rand.Next(min, max);
            }
        }

        partial void PaperPush(NSButton sender)
        {
            userChoice = "paper";
            MainFieldStatus.StringValue = "User choise : Paper";
        }

        partial void RockPush(NSButton sender)
        {
            userChoice = "rock";
			MainFieldStatus.StringValue = "User choise : Rock";
        }

        partial void ScissorsPush(NSButton sender)
        {
            userChoice = "scissors";
			MainFieldStatus.StringValue = "User choise : Scissors";
        }

        partial void StartGamePush(NSButton sender)
        {
            pcChoice = pcOptions[RandomNumberGenerator.GenerateRandomNumber(0, 3)];
            pcRandChoice.StringValue = "Pc choise :" + pcChoice;
            if (userChoice == "null")
            {
                MainFieldStatus.StringValue = "Choose Rock Papaer Or Scissors!";
            }

			 else if (userChoice == pcChoice)
			{
				WinLoseStatus.StringValue = "its a tie";
			}
            else if ((userChoice == "rock" && pcChoice == "scissors") ||
                     (userChoice == "paper" && pcChoice == "rock") ||
                     (userChoice == "scissors" && pcChoice == "paper"))
            {
                WinLoseStatus.StringValue = "You win!";
            }
            else
            {
                WinLoseStatus.StringValue = "You lose!";
            }

        }
    }
}
