using System;
using System.Collections.Generic;

namespace Challenges.c7_collections
{
    public class Challenge
    {
        // -------------- FOUNDATION --------------

        ///
        /// <summary>
        ///     Converts a comma-separated-list into a List
        /// </summary>
        /// <param name="csv"> The csv string we are converting e.g. Andy,Sam,Bex,Ollie </param>
        /// <returns> Converted List </returns>
        public List<string> CsvToList(string csv)
        {
            throw new NotImplementedException();
        }

        ///
        /// <summary>
        ///     Slices a list given a start & stop indexes. Make sure the indexes are within the bounds of the array
        /// </summary>
        /// <param name="items"> - list we are slicing </param>
        /// <param name="start"> - Start Index </param>
        /// <param name="stop"> - Stop Index </param>
        /// <returns> Sliced list from start to stop indexes </returns>
        public List<string> GetSlicedArray(List<string> items, int start, int stop)
        {
            throw new NotImplementedException();
        }

        /**
         * Swaps two items in an array
         * @param items - The list we are swapping elements in. e.g. [
         * @param first - First index
         * @param second
         * @return List with swapped elements
         */

        ///
        /// <summary>
        ///     Swaps two items and only those two items in an array
        /// </summary>
        /// <param name="items"> - list in which we are swapping elements </param>
        /// <param name="first"> - first Index </param>
        /// <param name="second"> - second Index </param>
        /// <returns> list with swapped elements </returns>
        public List<string> SwapElements(List<String> items, int first, int second)
        {
            throw new NotImplementedException();
        }

        // -------------- INTERMEDIATE --------------

        ///
        /// <summary>
        ///     Removes all odd numbers from a list of integers
        /// </summary>
        /// <param name="numbers"> - list we are filtering </param>
        /// <returns> list of even numbers </returns>
        public List<int> RemoveOddNumbers(List<int> numbers)
        {
            throw new NotImplementedException();
        }

        ///
        /// <summary>
        ///     Filter a list to only return unique/distinct items in an array without using a Set
        /// </summary>
        /// <param name="items"> - list we are filtering </param>
        /// <returns> unique items in list </returns>
        public List<string> GetUniqueItems(List<string> items)
        {
            throw new NotImplementedException();
        }



        // -------------- ADVANCED --------------

        ///
        /// <summary>
        ///     Without using any helper functions. Implement a binary search algorithm to search for an item in a sorted array.
        ///     A binary search uses a "Divide and Conquer" approach. It should divide an array in two, check if the middle value is the searchItem,
        ///     else if the searchItem is greater than the middle, repeat the same process in the top half of the array, and vice versa for
        ///     the lower half if the searchItem is less than the middle
        ///
        ///     NOTE: binary search algorithms ONLY work on sorted arrays 
        ///     EXTENSION: Once you've completed this without recursion. Consider how this could be done using recursion, you can even alter the method declaration ;)
        /// </summary>
        /// <param name="sortedArr"></param>
        /// <param name="searchItem"></param>
        /// <returns> number of iterations required to find the item </returns>
        public int FindItem(List<int> sortedArr, int searchItem)
        {
            throw new NotImplementedException();
        }
    }
}
