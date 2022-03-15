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
            return -1;
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
        /// <summary>
        ///     A method to calculate a price discount. Given the price
        /// </summary>
        /// and the amount to be discounted return the new discounted price.
        /// <param name="price"> The advertised price of a product </param>
        /// <param name="discount"> The percentage discount available </param>
        /// <returns> returns the price with the discount applied </returns>
        public double GetDiscount(double price, double discount)
        {
            // Extra Challenge: How would this change if price & discount were int types?
            return -1;
        }

        // -------------- INTERMEDIATE --------------

        /// <summary>
        ///     A method to check whether 2 numbers are equal to 4 decimal places.
        /// </summary>
        /// <param name="num1"> a double to be compared with the other parameter </param>
        /// <param name="num2"></param>
        /// <returns> a boolean to specify whether the 2 params match to 4 decimal places. </returns>
        public bool CompareTwoNumbers(double num1, double num2)
        {
            return true;
        }
        /// <summary>
        ///     A method to determine which day of the week it is from a numeric input.
        ///     e.g 0 = "Sunday", 1 = "Monday" etc.
        ///     If the input is out of range return "Not a valid day range! The number needs to be from 0-6"
        ///     EXTENSION Use a switch?
        ///     https://www.w3schools.com/java/java_switch.asp
        /// </summary>
        /// <param name="day"> an Integer from 0-6 (that corresponds to the days of the week) </param>
        /// <returns>
        ///     the day that corresponds to the number that was passed to the method as a parameter or "Not a valid
        ///     day range! The number needs to be from 0-6" if param passed is outside of the range
        /// </returns>
        public string GetDayName(int day)
        {
            return "";
        }

        /// <summary>
        ///     A method to check whether a word has an even length or not.
        ///     If an empty string is given it should return false.
        /// </summary>
        /// <param name="word"> a String to be checked whether the string has an even length or not. </param>
        /// <returns> a boolean the result of the length check. </returns>
        public bool IsEvenWord(String word)
        {
            return true;
        }

        // -------------- ADVANCED --------------
        /// <summary>
        ///     A method to determine whether any given year is a leap year.
        ///     A leap year occurs on:
        ///         - any year that is divisible by 4
        ///         - except years that are divisible by 100 as well
        ///         - unless that year is also divisible by 400
        /// </summary>
        /// <param name="year"> year the year to be checked </param>
        /// <returns> true if it is a leap year, false if not </returns>
        public bool LeapYearChecker(int year)
        {
            return false;
        }
    }
}
