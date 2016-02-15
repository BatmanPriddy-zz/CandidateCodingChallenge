/* Utilties MergeArray class used to centralize code for both 2 and 2.1 console programs */
using System.Collections.Generic;
using System.Linq;

namespace Utilities
{
    public sealed class PangramChecker
    {
        #region methods

            public static bool IsPangram(string value, string alphaChars)
            {
                return alphaChars.All(value.ToLower().Contains);
            }

            public static bool IsPangram(string value)
            {
                var alphaChars = Enumerable.Range(97, 26);
                var charItems = new List<int>();

                foreach (int ch in value.ToLower().ToArray())
                {
                    if (ch >= alphaChars.Min() && ch <= alphaChars.Max())
                    {
                        if (!charItems.Contains(ch))
                            charItems.Add(ch);
                    }
                }

                return (charItems.Count() == 26);
            }

        #endregion
    }
}