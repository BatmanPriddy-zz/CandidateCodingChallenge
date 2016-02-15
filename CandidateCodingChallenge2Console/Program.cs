/*  2/10/2016 Jason Priddy, Candidate Coding Challenge 2 for Imprivata (using Enumerable for alphabet) */
namespace CandidateCodingChallenge2Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Utilities.ConsoleWriter.WriteTitleMessage("Welcome to the Pangram Checker program!");
            Utilities.ConsoleWriter.WritePangramPromptMessage();
            Utilities.ConsoleReader.SetValue();

            if (Utilities.ConsoleReader.IsValueInRange(1, 103, Utilities.ConsoleReader.RangeType.StrVal))
            {
                var value = Utilities.ConsoleReader.Value;

                //using Enumerable from the utility class
                var isPangram = Utilities.PangramChecker.IsPangram(value);

                Utilities.ConsoleWriter.WritePangramOutputMessages(isPangram, value);
                Utilities.ConsoleReader.ReadLine();
            }
        }
    }
}