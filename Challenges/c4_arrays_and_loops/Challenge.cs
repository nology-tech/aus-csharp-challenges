using System;
namespace Challenges.c4_arrays_and_loops
{
    public class Challenge
    {
        // -------------- FOUNDATION --------------

        /// <summary>
        ///     Get the first and last items in an given string array.
        /// </summary>
        /// 
        /// If a the given array's length is 0 return an empty string array.
        ///
        /// <param name="namesArr"> e.g. ["Ollie", "Sam", "Bex"] </param>
        /// <returns> a new array containing the first and last items in the given array e.g. ["Ollie", "Bex"] </returns>
        ///
        public string[] GetFirstAndLast(string[] namesArr)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///     Find the SUM/Total of an array of peoples ages.
        /// </summary>
        /// <param name="agesArr"> e.g. [18, 25, 21, 40] </param>
        /// <returns> an amount e.g. 104 </returns>
        ///
        public int TotalAges(int[] agesArr)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///     Find the amount of odd numbers from a given array of numbers.
        /// </summary>
        /// <param name="numbersArr"></param> e.g. [5, 3, 8, 10, 1]
        /// <returns> Amount of odd numbers e.g. 3 </returns>
        ///
        public int GetAmountOfOddNumbers(int[] numbersArr)
        {
            throw new NotImplementedException();
        }

        // -------------- INTERMEDIATE --------------

        /// <summary>
        ///     Find all numbers between a min and a max value and return them in an array.
        ///     The min at the start and the max at the end of the returned array.
        ///
        ///     If the min is greater than the max return a empty integer array.
        /// </summary>
        /// 
        /// <param name="min"> - The starting range value e.g. 3 </param>
        /// <param name="max"> - The ending/finishing range value e.g. 6 </param>
        /// <returns> a new array of all numbers between and including the min and max number. e.g. [3, 4, 5, 6] </returns>
        ///
        public int[] GetRange(int min, int max)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///     Swap the first and last names in a string
        /// </summary>
        /// 
        /// <param name="fullName"> e.g. "Andy Evans" </param>
        /// <returns> a string with the last name, followed by the first name e.g. "Evans Andy" </returns>
        ///
        public string SwapNames(string fullName)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///     Determine whether a given score is the highest score out of a array of scores.
        /// 
        /// 
        ///     Can you use a for-each loop?
        ///     https://www.w3schools.com/java/java_for_loop.asp
        /// </summary>
        /// 
        /// <param name="scoresArr"> e.g. [3, 10, 2, 8] </param>
        /// <param name="newScore"> e.g. 11 </param>
        /// <returns> true or false depending on whether the newScore is the highest value in the array </returns>
        ///
        public bool IsHighestScore(int[] scoresArr, int newScore)
        {
            throw new NotImplementedException();
        }

        // -------------- ADVANCED --------------

        /// <summary>
        ///     Given an array of numbers, sort these numbers numerically lowest to highest by comparing adjacent numbers.
        ///
        ///     NOTE: Your code should work by repeatedly swapping the adjacent elements if they are in wrong order.
        ///     Example:
        ///     First Pass:
        ///     ( 5 1 4 2 8 ) –> ( 1 5 4 2 8 ), Here, algorithm compares the first two elements, and swaps since 5 > 1.
        ///     ( 1 5 4 2 8 ) –>  ( 1 4 5 2 8 ), Swap since 5 > 4
        ///     ( 1 4 5 2 8 ) –>  ( 1 4 2 5 8 ), Swap since 5 > 2
        ///     ( 1 4 2 5 8 ) –> ( 1 4 2 5 8 ), Now, since these elements are already in order (8 > 5), algorithm does not swap them
        ///
        ///     HINT: Can you use a nested for loop?
        ///     https://www.programiz.com/java-programming/nested-loop
        /// </summary>
        /// 
        /// <param name="numbersArr"> - array of numbers e.g. [5, 1, 4, 2, 8] </param>
        /// <returns> The sorted array of numbers e.g. [1, 2, 4, 5, 8] </returns>
        ///
        public int[] Sort(int[] numbersArr)
        {
            throw new NotImplementedException();
        }
    }
}
