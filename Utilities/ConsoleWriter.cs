/* Utilties ConsoleWriter class used to combine duplicated code which would appear in the associated console programs */
using System;

namespace Utilities
{
    public sealed class ConsoleWriter
    {
        #region methods

            public static void WriteTitleMessage(string message)
            {
                Console.WriteLine(message);
                Console.WriteLine();
            }

            public static void WriteArrayPromptMessage()
            {
                Console.Write("Please enter an array size as an integer value: ");
            }

            public static void WritePangramPromptMessage()
            {
                Console.Write("Please enter your sentence to determine if it is a pangram: ");
            }

            public static void WritePromptMessage(string message)
            {
                Console.Write(message);
            }

            public static void WriteFormattedPromptMessage(string message, object value)
            {
                Console.Write(string.Format(message, value));
            }

            public static void WriteErrorMessage(string error)
            {
                Console.Write(error);
            }

            public static void WriteMessage(string message)
            {
                Console.WriteLine(message);
            }

            public static void WriteFormattedMessage(string message, object value)
            {
                Console.WriteLine(string.Format(message, value));
            }

            public static void WriteArraySizesMessage(int[] a, int[] b)
            {
                var arraySizeMessageFormat = "Array {0} size: {1}";

                Console.WriteLine();
                Console.WriteLine(string.Format(arraySizeMessageFormat, 1, a.Length));
                Console.WriteLine(string.Format(arraySizeMessageFormat, 2, b.Length));
                Console.WriteLine();
            }

            public static void WriteArrayOutputMessages()
            {
                Console.WriteLine("Your merged arrays are as follows:");
                Console.WriteLine();
                Console.WriteLine(string.Join(",", Utilities.MergeArray.combined));
                Console.WriteLine();
                Console.WriteLine("Thank you for using Array Merger!  Press enter to exit...");
            }

            public static void WritePangramOutputMessages(bool isPangram, object value)
            {
                var pangramMessage = string.Format((isPangram) ? "{0} is a pangram!" : "{0} is not a pangram!", value);

                Console.WriteLine();
                Console.WriteLine((isPangram) ? 1 : 0);
                Console.WriteLine(pangramMessage);
                Console.WriteLine();
                Console.WriteLine("Thank you for using Pangram Checker!  Press enter to exit...");
            }

            public static void WriteLine()
            {
                Console.WriteLine();
            }

        #endregion
    }
}