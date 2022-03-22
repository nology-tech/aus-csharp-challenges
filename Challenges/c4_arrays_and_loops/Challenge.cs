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
        ///     Find all numbers within an inclusive range of min - max and return them in an array.
        ///
        ///     If the given min is greater than the given max return a empty integer array.
        /// </summary>
        /// 
        /// <param name="min"> - The starting range value e.g. 3 (inclusive) </param>
        /// <param name="max"> - The ending range value e.g. 6 (inclusive) </param>
        /// <returns> a new array of all numbers between and including the min and max number. e.g. [3, 4, 5, 6] </returns>
        ///
        public int[] GetRange(int min, int max)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///     Swap the names within a given string. If fullName contains a middle name, the swap will pivot around
        ///     the middle name. e.g -> "Alexander Graham Bell" -> "Bell Graham Alexander" 
        /// </summary>
        /// 
        /// <param name="fullName"> e.g. "Andy Evans" or "Jane Doe Smith" </param>
        /// <returns> a string with the last name, followed by the first name e.g. "Evans Andy" or "Smith Doe Jane"</returns>
        ///
        public string SwapNames(string fullName)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///     Determine whether a given score is the highest score out of an array of scores.
        /// 
        /// 
        ///     Could you use a for-each loop?
        ///     
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
        ///     NOTE: There are many sorting algorithms out there - any of them will suffices. Three popular ones are
        ///           bubble sort, insertion sort, and quick sort. For your initial solution, try using bubble sort
        ///           as it is the easiest. Then, try your hand at Insertion and Quick Sort. Think about the time complexity of
        ///           each solution as you work through them. Which one is >quick<est? ;)
        ///
        /// 
        ///     Bubble Sort Ex: (Easy)
        ///     First Pass:
        ///     ( 5 1 4 2 8 ) –> ( 1 5 4 2 8 ), Here, algorithm compares the first two elements, and swaps since 5 > 1.
        ///     ( 1 5 4 2 8 ) –>  ( 1 4 5 2 8 ), Swap since 5 > 4
        ///     ( 1 4 5 2 8 ) –>  ( 1 4 2 5 8 ), Swap since 5 > 2
        ///     ( 1 4 2 5 8 ) –> ( 1 4 2 5 8 ), Now, since these elements are already in order (8 > 5), algorithm does not swap them
        ///     https://en.wikipedia.org/wiki/Bubble_sort
        ///
        ///     Insertion Sort Ex: (Medium) 
        ///         Insertion sort essentially builds a sorted array one element at a time.
        ///         It takes the first element and moves it each iteration until it finds the location
        ///         in which it belongs and inserts it there.
        ///     First Pass:
        ///     ( 5 1 4 2 8) -> ( 1 4 2 5 8 ), The algorithm takes the first element 5, and moves it left until it is in the correct position. 
        ///     ( 1 4 2 5 8) -> ( 1 2 4 5 8 ), 1 is already in the correct position, so we start at 4 and move it to its correct position. Voîla! Sorted.
        ///     https://en.wikipedia.org/wiki/Insertion_sort
        ///     
        ///     Quick Sort Ex: (Hard) 
        ///         Quick Sort chooses a pivot value, and compares the values to the left and right of the pivot to determine if they lay on the correct side.
        ///         It divides and conquers to sort the array through partitioning, recursively applying itself to the range up to and the range beyond the partition. 
        ///     First Pass:
        ///     ( 5 1 4 2 8 ) -> ( 2 1 4 5 8 ), using a pivot of 4, we move the values less than 4 to the left and the ones greater than 4 to the right
        ///     ( 2 1 4 5 8 ) -> ( 1 2 4 5 8 ), we make two sub-ranges (1 2 4) & (4 5 8), using pivots 1 and 5, respectively, we recursively sort both ranges
        ///     https://en.wikipedia.org/wiki/Quicksort
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
