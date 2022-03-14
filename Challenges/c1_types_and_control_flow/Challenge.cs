using System;
using System.Collections.Generic;
using System.Text;

namespace Challenges.c1_types_and_control_flow
{
    public class Challenge
    {
        // -------------- FOUNDATION --------------

        /// <summary>
        /// A method to find the largest number of two given integers
        /// </summary>
        /// <param name="num1">a number to be compared with the other parameter</param>
        /// <param name="num2">a number to be compared with the other parameter</param>
        /// <returns>returns the larger of the 2 numbers passed as parameters</returns>
        public int FindLargestNumber(int num1, int num2)
        {
            if (num1 > num2) return num1;
            return num2;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="string1"></param>
        /// <param name="string2"></param>
        /// <returns></returns>
        public string FindLongestString(string string1, string string2)
        {
            return "";
        }
    }
}
