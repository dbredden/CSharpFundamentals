using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _06_Methods
{
    [TestClass]
    public class MethodExamples
    {
        [TestMethod]
        public void MethodExecution()
        {
            SayHello("Danny");
            int methodReturn = AddTwoNumbers(1, 2);
            Console.WriteLine(methodReturn);

            AddTwoNumbers(3.05, 2.56);
            AddTwoNumbers(3, 2.55);


            int age = CalculateAge(new DateTime(1892, 11, 24));
            Console.WriteLine($"My age is: {age}");
        }

        //1) Access Modifier
        //2) Return Type
        //3) Method Signature
            //Name
            //Parameters
        //4) Body - the actual code
        [TestMethod]
        public void SayHello(string name)
        {
            Console.WriteLine($"Hello World! And Hello {name}");
        }
        [TestMethod]
        public int AddTwoNumbers(int numOne, int numTwo)
        {
            int sum = numOne + numTwo;
            return sum;
        }

        [TestMethod]
        public double AddTwoNumbers(double numOne, double numTwo)
        {
            double sum = numOne + numTwo;
            return sum;
        }

        [TestMethod]
        public int CalculateAge(DateTime birthday)
        {
            TimeSpan ageSpan = DateTime.Now - birthday;
            double totalAgeInYears = ageSpan.TotalDays / 365.25;
            int years = Convert.ToInt32(Math.Floor(totalAgeInYears));
            return years; 
        }
    }
}
