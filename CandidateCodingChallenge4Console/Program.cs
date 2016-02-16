/*  2/14/2016 Jason Priddy, Candidate Coding Challenge 4 for Imprivata */
using System.Linq;

namespace CandidateCodingChallenge4Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var cityCount = 0; //N
            var clinicCount = 0; //B

            Utilities.ConsoleWriter.WriteTitleMessage("Welcome to the World Health Organization (WHO) program!");
            Utilities.ConsoleWriter.WritePromptMessage("Please enter the numbers of cities for immunization: ");

            cityCount = GetIntValueWithinRange(1, 500000);

            Utilities.ConsoleWriter.WriteLine();
            Utilities.ConsoleWriter.WritePromptMessage("Please enter the numbers of clinics to be opened: ");

            clinicCount = GetIntValueWithinRange(1, 2000000);

            var populationCount = new int[cityCount]; //ai

            for (var i = 0; i < cityCount; i++)
            {
                Utilities.ConsoleWriter.WriteLine();
                Utilities.ConsoleWriter.WriteFormattedPromptMessage("Please enter the total population of city {0}: ", (i + 1));

                populationCount[i] = GetIntValueWithinRange(1, 5000000);
            }

            GetMaxNumToBeImmunized(populationCount, clinicCount);

            Utilities.ConsoleWriter.WriteMessage("Thank you for using the program! Press enter to exit...");
            Utilities.ConsoleReader.ReadLine();
        }

        static int GetIntValueWithinRange(int minVal, int maxVal)
        {
            if (Utilities.ConsoleReader.IsIntInputValid(minVal, maxVal, Utilities.ConsoleReader.RangeType.IntVal))
                return Utilities.ConsoleReader.GetIntValue();

            return 0; //default value if conditional above fails for some reason
        }

        static void GetMaxNumToBeImmunized(int[] populationCount, int clinicCount)
        {
            var formattedNumber = (populationCount.Sum() / clinicCount).ToString("N0");

            Utilities.ConsoleWriter.WriteLine();
            Utilities.ConsoleWriter.WriteFormattedMessage("The maximum number of people to be immunized in any single clinic is {0}.", formattedNumber);
            Utilities.ConsoleWriter.WriteLine();
        }
    }
}