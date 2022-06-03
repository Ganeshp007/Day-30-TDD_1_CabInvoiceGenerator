using Day_30_TDD_1_CabInvoiceGenerator;
using NUnit.Framework;

namespace TestProject_CabInvoiceGen
{
    public class Tests
    {
        InvoiceGenerator invoiceGenerator = null;   //creating refrance of invoice gen class
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GivenDistanceAndTimeShouldReturnTotalFare()
        {
            invoiceGenerator = new InvoiceGenerator(RideType.NORMAL); //calling param constructor of invoice genrator class 
            double distance = 2.0;
            int time = 5;
            double fare = invoiceGenerator.CalculateFare(distance, time); //calling method to calculate Fare by passing distance and time param
            double expected = 25; //excpecting result 
            Assert.AreEqual(expected, fare); //overloading Areeual method to check actual and expected fare
        }

        [Test]
        public void GivenMultipleRideShouldReturnInvoiceSummary()
        {
            invoiceGenerator = new InvoiceGenerator(RideType.NORMAL); //calling param constructor of invoice genrator class 
            Ride[] rides = { new Ride(2.0, 5), new Ride(0.1, 5) }; //creating array of type Ride and storing Ride objects in it
            InvoiceSummary summary = invoiceGenerator.CalculateFare(rides);//calling calculateFare method with param Ride Array
            InvoiceSummary expectedSummary = new InvoiceSummary(2, 31.0); 
            //Assert.AreEqual(expectedSummary.GetType(), summary.GetType());
            Assert.AreEqual(summary, expectedSummary);
        }

    }
}