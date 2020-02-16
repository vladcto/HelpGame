using System;

namespace HelpGame
{
    /// <summary>
    /// Class for game mathematical operations (comparisons and calculations)
    /// </summary>
    public static class GMath
    {

        //Methods for compares the difference between 2 numbers with a suitable difference.
        #region methods DiffrLess
        /// <summary>
        /// Compares the difference between 2 numbers, and gives the truth if it is less max_differ.
        /// </summary>
        /// <param name="first">The first number to compare</param>
        /// <param name="second">The second number to compare </param>
        /// <param name="max_differ">The maximum modulus of the difference between these numbers</param>
        /// <returns>
        /// true, if the difference between the numbers is less max_differ, otherwise false
        /// </returns>
        /// /// <example>
        /// <code>
        /// float first=1;
        /// float second=1.0001;
        /// bool res= DiffrLess(first,second,0.1) //Gives true
        /// </code>
        /// </example>
        /// <seealso cref="GMath.DiffrLess(double, double,double)"/>
        /// <seealso cref="GMath.DiffrLess(int, int,int)"/>
        public static bool DiffrLess(float first,float second,float max_differ)
        {
            return Math.Abs(first - second) < max_differ;
        }
        /// <summary>
        /// Compares the difference between 2 numbers, and gives the truth if it is less max_differ.
        /// </summary>
        /// <param name="first">The first number to compare</param>
        /// <param name="second">The second number to compare </param>
        /// <param name="max_differ">The maximum modulus of the difference between these numbers</param>
        /// <returns>
        /// true, if the difference between the numbers is less max_differ, otherwise false
        /// </returns>
        /// /// <example>
        /// <code>
        /// double first=1;
        /// double second=1.0001;
        /// bool res= DiffrLess(first,second,0.1) //Gives true
        /// </code>
        /// </example>
        /// <seealso cref="GMath.DiffrLess(float, float,float)"/>
        /// <seealso cref="GMath.DiffrLess(int, int,int)"/>
        public static bool DiffrLess(double first, double second, double max_differ)
        {
            return Math.Abs(first - second) < max_differ;
        }
        /// <summary>
        /// Compares the difference between 2 numbers, and gives the truth if it is less max_differ.
        /// </summary>
        /// <param name="first">The first number to compare</param>
        /// <param name="second">The second number to compare </param>
        /// <param name="max_differ">The maximum modulus of the difference between these numbers</param>
        /// <returns>
        /// true, if the difference between the numbers is less max_differ, otherwise false
        /// </returns>
        /// /// <example>
        /// <code>
        /// int first=1;
        /// int second=4;
        /// bool res= DiffrLess(first,second,5) //Gives true
        /// </code>
        /// </example>
        /// <seealso cref="GMath.DiffrLess(double, double,double)"/>
        /// <seealso cref="GMath.DiffrLess(float, float,float)"/>
        public static bool DiffrLess(int first, int second, int max_differ)
        {
            return Math.Abs(first - second) < max_differ;
        }
        #endregion DiffrLess

    }
}
