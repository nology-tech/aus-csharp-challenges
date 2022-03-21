using System;
namespace Challenges.c2_control_flow_extended
{
    public class Challenge
    {
        // -------------- FOUNDATION --------------

        /// <summary>
        ///     Write a method that concatenates two strings together with a space in between them.
        /// </summary>
        /// <param name="firstName"> the first name of a person </param>
        /// <param name="lastName"> the last name of a person </param>
        /// <returns> a string which is the concatenation of the 2 parameters </returns>
        public string GetFullName(string firstName, string lastName)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        ///     Write a method that checks if a number is within 0 and a given range. Both inclusive.
        /// </summary>
        /// <param name="number"> the number to find within the range </param>
        /// <param name="rangeLimit"> the limit of the range </param>
        /// <returns> a boolean based on whether the number is between 0 and the range limit </returns>
        public bool IsWithinRange(int number, int rangeLimit)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///     Write a method that takes two numbers and an operator. Based on the operator preform the
        ///     equation and return the result.
        ///     e.g 10, 2 , "/" = 5
        ///     e.g 10, 2 , "+" = 12
        ///
        ///     If either number is below 0 return -1
        ///     If an operator is not "*", "/", "+", "-" return -1
        /// </summary>
        /// <param name="numberOne"> the first number in the equation </param>
        /// <param name="numberTwo"> the second number in the equation </param>
        /// <param name="op"> the operator to complete the equation </param>
        /// <returns> the result of the equation </returns>
        public int StringCalculator(int numberOne, int numberTwo, String op)
        {
            throw new NotImplementedException();
        }

        // -------------- INTERMEDIATE --------------

        /// <summary>
        ///     We have a dog that likes to bark. We will wake up if the dog is barking at night!
        ///     This method should return true or false if we will wake up or not.
        ///
        ///     If the hourOfDay is <= 8 OR >= 22 AND the dog is barking, we should wake up. 
        ///     In all other cases we do not need to wake up.
        ///     If the hourOfDay is not within the valid range of 0 - 23, return false.
        /// </summary>
        /// <param name="barking"> bool - represents if our dog is currently barking or not. </param>
        /// <param name="hourOfDay"> int - the hour of the day with a valid range of 0-23. </param>
        /// <returns> bool - If we need to wake up or not based on the conditions above. </returns>
        public bool ShouldWakeUp(bool barking, int hourOfDay)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///     Write a method to display the middle character or characters of a word.
        ///     If multiple words separated with a " " or no words are given it should return "Invalid Input"
        /// </summary>
        /// <param name="word"> the word that we want to check </param>
        /// <returns> the middle character or characters... for example, passing in "Sam" would return "The middle character in the string: a"</returns>
        public string GetMiddleCharacter(string word)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///     Write a method called printMegaBytesAndKiloBytes that has 1 parameter of type int.
        ///     The method needs to see how many megabytes are in the given kilobyte and work out the remainder
        ///     Then it needs to return a message in the format "XX KB = YY MB and ZZ KB".
        ///
        ///     If the kiloBytes param is less than 0 return "Invalid value"
        ///     1 megaByte = 1024 kiloBytes
        ///     
        /// </summary>
        /// <param name="kiloBytes"> the number of kilobytes to be converted </param>
        /// <returns> a string in the format above if the input is valid, or "Invalid value" </returns>
        public string PrintMegaBytesAndKiloBytes(int kiloBytes)
        {
            throw new NotImplementedException();
        }

        // -------------- ADVANCED --------------

        /// <summary>
        ///     Write a method to compute the future investment value returned at a given interest rate for a specified number
        ///     of years.
        ///     It should return a string the matches this format "You now have RESULT" the RESULT needs to be rounded.
        ///
        ///     If initialInvestment is less than or equal 0 return "Invalid investment"
        ///     If years is less than or equal 0 return "Invalid years"
        ///     If rateOfInterest is less than 0 or greater than or equal to 1 return "Invalid rate of interest"
        ///
        ///     HINT: https://www.w3schools.com/java/java_for_loop.asp
        /// </summary>
        /// <param name="initialInvestment"> double - the starting value </param>
        /// <param name="years"> int - the number of years that the investment will take </param>
        /// <param name="rateOfInterest"> double - the rate at which, each year, the investment will increase by </param>
        /// <returns>
        ///     the total amount after x number of years (including the initial investment) to 2 floating points
        ///     ex) -> 'You now have 2593.74'
        /// </returns>
        public string CalculateReturn(double initialInvestment, int years, double rateOfInterest)
        {
            throw new NotImplementedException();
        }
    }
}
