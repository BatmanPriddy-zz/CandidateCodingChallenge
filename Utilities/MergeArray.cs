/* Utilties MergeArray class used to centralize/combine duplicated code which would appear in both 1 and 1.1 console programs */
using System;
using System.Linq;

namespace Utilities
{
    public sealed class MergeArray
    {
        #region fields

            public static int[] combined;

        #endregion

        #region methods

            public static void MergeArrayLinq(int[] a, int[] b, int m)
            {
                //using concat here vs union, as union will remove duplicates
                //m parameter actually isn't necessary, as the arrays were prebuilt with their max sizes, and then passed into this method
                //using LINQ for this method, as it does an excellent job combining two arrays, and includes ordering extention methods
                combined = a.Concat(b).OrderBy(_ => _).ToArray();
            }

            public static void MergeArrayCopy(int[] a, int[] b, int m)
            {
                //m parameter actually isn't necessary, as the arrays were prebuilt with their max sizes, and then passed into this method
                //using Array Copy/Sort for this method, simply to give the programmer another option to combine and sort the array :)
                combined = new int[a.Length + b.Length];

                Array.Copy(a, combined, a.Length);
                Array.Copy(b, 0, combined, a.Length, b.Length);
                Array.Sort(combined);
            }

            public static int[] CreateArray(int m) //<= this would be the duplicated method in the console programs
            {
                //using random numbers to create the arrays of m length
                //if the capacity is different than the m value entered by the user, there will be numerous 0 value array items created
                //wanted to avoid that here
                var array = new int[m];
                var random = new Random();

                for (var i = 0; i < m; i++)
                    array[i] = random.Next(1, m);

                return array;
            }

        #endregion
    }
}