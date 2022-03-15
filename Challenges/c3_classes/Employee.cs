using System;
namespace Challenges.c3_classes
{


/// -------------- Foundation -----------------
///
/// The Employee class represents a generic employee.
///
/// This is a skeleton of a class you will have to complete it by following these steps.
/// - Adding data fields / properties
/// - Adding a constructor
/// - Implementing three methods
///
/// Each step is documented through the class.


        public class Employee
    {

        ///
        /// Create 4 public fields:
            ///- name is a string
            /// - position is a string
            /// - rating is a integer
            /// - yearsEmployed is a integer
            ///- completedDeals is a integer
        ///

        ///
        ///Complete the constructor below to initialize the class and the data to the fields above.
        ///
        public Employee(String name, String position, int rating, int yearsEmployed, int completedDeals)
            {
            // complete the constructor in here
        }

        ///
        ///Complete the isPromotable method
        ///
        /// It needs to check if the employee rating is over 7, if so return true... else false
        ///
        /// <returns> boolean if employee is promotable </returns>
        ///
        public bool IsPromotable()
            {
                return false;
        }

        ///
        /// Complete the calculateDealsPerYear method
        ///
        /// It needs to calculate the average number of deals completed  each year since they have joined the company.
        ///
        /// <returns> int average deals per year </returns>
        ///
        public int CalculateDealsPerYear()
            {
                return -1;
        }

        ///
        ///Complete the hasBonusQualification method
        ///
        /// It needs to check if the employee is able to get a bonus.
        ///
        /// To get a bonus:
            /// - They need a rating above 8.
            /// - They need a deals per year average greater than or equal to 20.
        ///
        /// <returns> boolean if they are eligible for a bonus </returns> 
        ///
        public bool HasBonusQualification()
            {
                return false;
            }
        }
}
