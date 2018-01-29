
using System;
using System.Collections.Generic;
using NUnit.Framework;
using Fibonacci;
namespace TestFibonacci
{
    [TestFixture]
    public class MyTest
    {
        
        FibonacciCalculator myCal = new FibonacciCalculator();

        [Test]
        public void PassZeroReturnNull() {
            myCal.RequestedListSize(0);
            Assert.AreEqual(null, myCal.getListOfFibonacciNumbers());

        }

        [Test]
        public void PassOneReturnOne() {
            myCal.RequestedListSize(1);
            List<int> aspectedList = new List<int>() {1};
            Assert.AreEqual(aspectedList, myCal.getListOfFibonacciNumbers());
        }

        [Test]
        public void PassTwoReturnOneOne() {
            myCal.RequestedListSize(2);
            List<int> aspectedList = new List<int>() { 1, 1 };
            Assert.AreEqual(aspectedList, myCal.getListOfFibonacciNumbers());

        }

        [Test]
        public void passThreeReturnOneOneTwo() {
            myCal.RequestedListSize(3);
            List<int> aspectedList = new List<int>() { 1, 1, 2 };
            Assert.AreEqual(aspectedList, myCal.getListOfFibonacciNumbers());
        }

        [Test]
        public void passFourReturnOneOneTwoThree()
        {
            myCal.RequestedListSize(4);
            List<int> aspectedList = new List<int>() { 1, 1, 2, 3 };
            Assert.AreEqual(aspectedList, myCal.getListOfFibonacciNumbers());
        }

        [Test]
        public void passTenReturnOneOneTwoThreeFiveEccEcc()
        {
            myCal.RequestedListSize(10);
            List<int> aspectedList = new List<int>() { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55 };
            Assert.AreEqual(aspectedList, myCal.getListOfFibonacciNumbers());
        }
    }
}
