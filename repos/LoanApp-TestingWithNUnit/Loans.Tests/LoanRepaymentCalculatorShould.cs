using System;
using NUnit.Framework;
using Loans.Domain.Applications;


namespace Loans.Tests
{
    public class LoanRepaymentCalculatorShould
    {
        [Test]
        [TestCase(200000, 6.5, 30, ExpectedResult = 1264.14)]
        [TestCase(200000, 10, 30, ExpectedResult = 1755.14)]
        [TestCase(500000, 10, 30, ExpectedResult = 4387.86)]
        public decimal CalculateCorrectMontlyRepayment(decimal principal, decimal interestRate, int periodYear)
        {
            var sut = new LoanRepaymentCalculator();

            return sut.CalculateMonthlyRepayment(new LoanAmount("RSD", principal), interestRate, new LoanTerm(periodYear));


        }

        [Test]
        [Sequential]
        public void CalculateCorrectMontlyRepayment_Sequential(
                [Values(200000, 200000, 500000)] decimal principal,
                [Values(6.5,10,10)] decimal interestRate,
                [Values(30,30,30)] int periodYear,
                [Values(1264.14, 1755.14, 4387.86)] decimal expectedRes)
        {
            var sut = new LoanRepaymentCalculator();

            var monthlyPayment = sut.CalculateMonthlyRepayment(new LoanAmount("RSD", principal), interestRate, new LoanTerm(periodYear));

            Assert.That(monthlyPayment, Is.EqualTo(expectedRes));
        }

        [Test]
        public void CalculateCorrectMontlyRepayment_Range(
            [Range(50000, 1000000, 50000)]decimal principal,
            [Range(0.5, 20.00, 0.5)]decimal interestRate,
            [Values(10,20,30)]int periodYear)
        {
            var sut = new LoanRepaymentCalculator();

            sut.CalculateMonthlyRepayment(new LoanAmount("RSD", principal), interestRate, new LoanTerm(periodYear));
        }

    }
}