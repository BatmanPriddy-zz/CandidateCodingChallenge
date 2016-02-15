/*  2/10/2016 Jason Priddy, Candidate Coding Challenge 2.1 for Imprivata (using explicit alphabet) */
namespace CandidateCodingChallenge2._1Console
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

                //using alphabet passed to the utility class
                var isPangram = Utilities.PangramChecker.IsPangram(value, "abcdefghijklmnopqrstuvwxyz");

                Utilities.ConsoleWriter.WritePangramOutputMessages(isPangram, value);
                Utilities.ConsoleReader.ReadLine();
            }
        }
    }
}