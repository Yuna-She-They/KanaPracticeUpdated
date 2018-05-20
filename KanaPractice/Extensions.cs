/*
 * 
 * 
 * 
 * 
 * 
 */
namespace KanaPractice
{
    #region Using Directives
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    #endregion Using Directives

    /// <summary>
    /// A class of extension methods.
    /// </summary>
    public static class Extensions
    {
        /// <summary>
        /// a random object used for Shuffle
        /// </summary>
        private static Random rng = new Random();


        /// <summary>
        /// An extension method to shuffle a list of type T
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n -= 1;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}
