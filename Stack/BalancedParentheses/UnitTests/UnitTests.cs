using System;
using BalancedParentheses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            string line_input;
            string pathToTestFile = @"C:\Users\schapaeva\Desktop\WORK-ST\Study\Studying\Stack\BalancedParentheses\TestFiles\TestCase5_Input.txt";
            string pathToResultsFile = @"C:\Users\schapaeva\Desktop\WORK-ST\Study\Studying\Stack\BalancedParentheses\TestFiles\TestCase5_Expected.txt";
            System.IO.StreamReader file_input = new System.IO.StreamReader(pathToTestFile);
            System.IO.StreamReader file_result = new System.IO.StreamReader(pathToResultsFile);

            while ((line_input = file_input.ReadLine()) != null)
            {
                bool actualResult = Program.CheckBalancedParentheses(line_input.ToCharArray());
                string expectedResult = file_result.ReadLine();
                if ((actualResult && expectedResult == "NO") || (!actualResult && expectedResult == "YES"))
                {
                    Assert.Fail(line_input);
                }     
            }
        }

        [TestMethod]
        public void TestMethod2()
        {
            char[] input = "[{".ToCharArray();
            Assert.IsFalse(Program.CheckBalancedParentheses(input));
        }

    }

    
}
