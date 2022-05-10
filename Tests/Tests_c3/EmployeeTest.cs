using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Challenges.c3_classes;

namespace Tests.c3
{
    [TestClass]
    public class EmployeeTest
    {
        public Employee manager;
        public Employee salesRep;
        public Employee intern;


        [TestInitialize]
        public void SetUp()
        {
            manager = new Employee("Karen", "Manager", 10, 10, 400);
            salesRep = new Employee("Judy", "Sales Rep", 9, 2, 30);
            intern = new Employee("Jilly", "Intern", 7, 1, 2);
        }

    // Testing the Fields and the Constructor
    // You will have to uncomment the tests below once you have added the fields and constructor

        //[TestMethod]
        //public void Employee_ValidFields_nameMatches()
        //{
        //    Assert.
        //        AreEqual("Karen", manager.name);
        //}

        //[TestMethod]
        //public void Employee_ValidFields_positionMatches()
        //{
        //    Assert.
        //       AreEqual("Manager", manager.position);
        //}

        //[TestMethod]
        //public void Employee_ValidFields_ratingMatches()
        //{
        //    Assert.
        //       AreEqual(10, manager.rating);
        //}

        //[TestMethod]
        //public void Employee_ValidFields_yearsEmployedMatches()
        //{
        //    Assert.
        //       AreEqual(10, manager.yearsEmployed);
        //}

        //[TestMethod]
        //public void Employee_ValidFields_completedDealsMatches()
        //{
        //    Assert.
        //       AreEqual(400, manager.completedDeals);
        //}

    // Testing isPromotable

        [TestMethod]
        public void IsPromotable_ValidPromotion_ReturnsTrue()
        {
            bool managerResult = this.manager.IsPromotable();
            Assert.IsTrue(managerResult);

            bool salesRepResult = this.salesRep.IsPromotable();
            Assert.IsTrue(salesRepResult);
        }

        [TestMethod]
        public void IsPromotable_InValidPromotion_ReturnsFalse()
        {
            bool internResult = this.intern.IsPromotable();
            Assert.IsFalse(internResult);
        }

        // Testing calculateDealsPerYear

        [TestMethod]
        public void CalculateDealsPerYear_ValidFields_ReturnsSumOfDeals()
        {
            int managerResult = this.manager.CalculateDealsPerYear();
            Assert.AreEqual(40, managerResult);

            int salesRepResult = this.salesRep.CalculateDealsPerYear();
            Assert.AreEqual(15, salesRepResult);

            int internResult = this.intern.CalculateDealsPerYear();
            Assert.AreEqual(2, internResult);
        }

    // Testing hasBonusQualification

        [TestMethod]
        public void HasBonusQualification_ValidBonus_ReturnsTrue()
        {
            bool managerResult = this.manager.HasBonusQualification();
            Assert.IsTrue(managerResult);
        }

        [TestMethod]
        public void HasBonusQualification_InvalidBonus_ReturnsFalse()
        {
            bool salesRepResult = this.salesRep.HasBonusQualification();
            Assert.IsFalse(salesRepResult);

            bool internResult = this.intern.HasBonusQualification();
            Assert.IsFalse(internResult);
        }
    }
}
