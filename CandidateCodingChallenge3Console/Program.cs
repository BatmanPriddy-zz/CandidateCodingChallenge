/*  2/12/2016 Jason Priddy, Candidate Coding Challenge 3 for Imprivata */
using System;

namespace CandidateCodingChallenge3Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var stepCount = 0;
            var brokenStep = 0;

            Utilities.ConsoleWriter.WriteTitleMessage("Welcome to the Jumping Jack program!");
            Utilities.ConsoleWriter.WritePromptMessage("Please enter the amount of stairs you wish to jump: ");

            if (Utilities.ConsoleReader.IsIntInputValid(1, 2000, Utilities.ConsoleReader.RangeType.IntVal))
            {
                stepCount = Utilities.ConsoleReader.GetIntValue();
                Utilities.ConsoleWriter.WriteLine();
                Utilities.ConsoleWriter.WriteFormattedMessage("Get ready to jump {0} stairs!", stepCount);
                Utilities.ConsoleWriter.WriteLine();
            }

            Utilities.ConsoleWriter.WritePromptMessage("Now please enter the number of the broken step: ");

            if (Utilities.ConsoleReader.IsIntInputValid(1, 4000000, Utilities.ConsoleReader.RangeType.IntVal))
            {
                brokenStep = Utilities.ConsoleReader.GetIntValue();

                var brokenStairMessage = (brokenStep <= stepCount) ? "Uh oh, step {0} is broken, we'll have to watch out for that!" : "We don't have to worry about broken step {0}!";

                Utilities.ConsoleWriter.WriteLine();
                Utilities.ConsoleWriter.WriteFormattedMessage(brokenStairMessage, brokenStep);
                Utilities.ConsoleWriter.WriteLine();
            }

            var maxStep = MaxStep(stepCount, brokenStep);

            if (maxStep == 1)
            {
                Utilities.ConsoleWriter.WriteMessage("Nowhere to jump my friend!");
                Utilities.ConsoleWriter.WriteLine();
            }
            else
            {
                Utilities.ConsoleWriter.WriteFormattedMessage("The topmost step you can reach is: {0}", maxStep);
                Utilities.ConsoleWriter.WriteLine();
            }

            Utilities.ConsoleWriter.WriteMessage("Thank you for using Jumping Jack! Press enter to exit...");
            Utilities.ConsoleReader.ReadLine();
        }

        static int MaxStep(int n, int k)
        {
            var maxStep = 0;

            if ((maxStep + 1) == n) return 1; //nowhere to go!

            for (var i = 1; i <= n; i++)
            {
                if (i == k) //skip that pesky step!
                {
                    maxStep = maxStep + 2;
                    continue;
                }

                maxStep++;
            }

            return maxStep;
        }
    }
}
