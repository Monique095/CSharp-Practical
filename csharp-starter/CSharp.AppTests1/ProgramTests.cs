using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharp.App;
using System;
using System.Collections.Generic;
using System.Text;
using CSharp.Domain;

namespace CSharp.App.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void GetCollectionTest()
        {
            //Arrange
            var expected = new List<InvoiceItems>();

            //Act
            expected.Add(new InvoiceItems() { Testing_per_hour = 2.5, Testing_Rate = 132.45 });
            expected.Add(new InvoiceItems() { Development_per_hour = 2.5, Development_Rate = 320.00 });
            expected.Add(new InvoiceItems() { Consultation_fee = 100, Description = "Unit Testing" });
            expected.Add(new InvoiceItems() { Api_Development = 500.00, Hosting = 300.00 });

            Console.WriteLine("Unit Test works!");

            //Assert
            Assert.IsNotNull(expected);
        }

       
        [TestMethod()]
        public void InvoiceDateTest()
        {
            //Arrange
            var today = DateTime.Now;
            var startDate = new DateTime(today.Year, today.Month, 1);
            var endDate = startDate.AddMonths(1).AddDays(-6);

            //Act
            var (FirstDayOfMonth, LastDayOfMonth) = DateTime.Now.InvoiceDateTest();

            //Assert
            Assert.IsTrue(startDate.Equals(FirstDayOfMonth),
                "Expected start dates to match.");

            Assert.IsTrue(endDate.Equals(LastDayOfMonth),
                "Expected end dates to match");
        }

        [TestMethod()]
        public void InvoiceDueDateTest()
        {
            //Arrange
            var today = DateTime.Now;
            var startDate = new DateTime(today.Year, today.Month, 1);
            var endDate = startDate.AddMonths(2).AddDays(-1);

            //Act
            var (FirstDayOfMonth, LastDayOfMonth) = DateTime.Now.InvoiceDueDateTest();

            //Assert
            Assert.IsTrue(startDate.Equals(FirstDayOfMonth),
                "Expected start dates to match.");

            Assert.IsTrue(endDate.Equals(LastDayOfMonth),
                "Expected end dates to match");
        }


    }
}