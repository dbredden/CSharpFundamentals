﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _01_ValueTypes
{
    public enum PastryType
    {
        Cake,
        Danish,
        Croissant,
        Donut,
        Scone,
        Backlava
    }

    [TestClass]
    public class ValueTypes
    {
        [TestMethod]
        public void InitAndDeclareVariables()
        {
            // Declaring a Variable
            int numOne;
            numOne = 1;

            // Declaring and initializing a variable
            int numTwo = 2;

            // Variables
            // Named location in computer memory AKA RAM
        }

        [TestMethod]
        public void ValueTypeVariables()
        {
            // Whole Numbers
            byte byteExample = 255;
            sbyte sByteExample = -128;
            short shortExample = 32767;
            Int16 anotherShortExample = 32000;
            int intMin = -2147483648;
            int intMax = 2147483647;
            Int32 anotherIntExample = 123456;
            long longMax = 9223372036854775807;
            Int64 longMin = -9223372036854775808;

            // Decimals
            double doubleExample = 1.23456789; //least amount of memory
            float floatExample = 1.045678f; 
            decimal decimalExample = 1.24567894561230m; //most amount of memory used for currencies and accurate measures

            Console.WriteLine(doubleExample) ;

            // Character
            char charExample = 'a';
            char number = '3';
            char symbol = '&';
            char space = ' ';
            char specialChar = '\n';

            // Bool
            bool isHungry = true;
            bool isTired = false;

            // Enum
            PastryType myPastry = PastryType.Backlava;

            //Structs
            DateTime today = DateTime.Now;
            Console.WriteLine(today);

        }
    }
}
