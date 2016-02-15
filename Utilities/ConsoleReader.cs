/* Utilties ConsoleReader class used to combine duplicated code which would appear in the associated console programs */
using System;

namespace Utilities
{
    public sealed class ConsoleReader
    {
        #region properties

            public static string Value { get; private set; }

        #endregion

        #region enums

            public enum RangeType { IntVal, StrVal }

        #endregion

        #region methods

            public static bool IsIntValue()
            {
                int intVal;

                //allow the user to keep entering a value, until they enter an integer
                while (!int.TryParse(Console.ReadLine(), out intVal))
                    ConsoleWriter.WriteErrorMessage("The value must be of type integer, please try again: ");

                Value = intVal.ToString();

                return true;
            }

            public static bool IsValueInRange(int minVal, int maxVal, RangeType rangeType)
            {
                //goto worked best here, the while loop had trouble with the OR conditional below
                //inputs can either be an int value or text value, in the latter case we must obtain the length
                Conditional:

                //extra check below for integer types, if the value entered is an empty string, don't parse (it will error out), just set value to the length of 0
                var value = (rangeType == RangeType.IntVal && !String.IsNullOrWhiteSpace(Value)) ? int.Parse(Value) : Value.Length; 

                if (value < minVal || value > maxVal)
                {
                    var message = (rangeType == RangeType.IntVal) ? "The value must be greater than {0} but less than {1}, please try again: " : "The value must be greater than {0} characters but less than {1}, please try again: ";

                    ConsoleWriter.WriteErrorMessage(string.Format(message, minVal - 1, maxVal + 1));
                    SetValue();

                    goto Conditional;
                }

                return true;
            }

            public static bool IsIntInputValid(int minVal, int maxVal, RangeType rangeType)
            {
                if (IsIntValue())
                    return IsValueInRange(minVal, maxVal, rangeType);
                
                return false;
            }

            public static void SetValue()
            {
                Value = Console.ReadLine();
            }

            public static int GetIntValue()
            {
                return int.Parse(Value);
            }

            public static void ReadLine()
            {
                Console.ReadLine();
            }

        #endregion
    }
}
