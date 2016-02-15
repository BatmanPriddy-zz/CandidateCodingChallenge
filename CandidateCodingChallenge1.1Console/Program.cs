/*  2/10/2016 Jason Priddy, Candidate Coding Challenge 1.1 for Imprivata (using Array Copy/Sort) */
namespace CandidateCodingChallenge1._1Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Utilities.ConsoleWriter.WriteTitleMessage("Welcome to the Super Awesome Array Merger program!");
            Utilities.ConsoleWriter.WriteArrayPromptMessage();

            if (Utilities.ConsoleReader.IsIntValue())
            {
                var m = int.Parse(Utilities.ConsoleReader.Value);
                var a = Utilities.MergeArray.CreateArray(m);
                var b = Utilities.MergeArray.CreateArray(2 * m);

                Utilities.ConsoleWriter.WriteArraySizesMessage(a, b);

                //merge the arrays using array copy from the utility class for this program
                Utilities.MergeArray.MergeArrayCopy(a, b, m);

                Utilities.ConsoleWriter.WriteArrayOutputMessages();
                Utilities.ConsoleReader.ReadLine();
            }
        }
    }
}