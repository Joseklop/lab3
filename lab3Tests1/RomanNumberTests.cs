using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass()]
    public class RomanNumberTests
    {
        [TestMethod()]
        public void CloneTest()
        {
            RomanNumber test = new RomanNumber(24);
            RomanNumber c_test = test.Clone() as RomanNumber;
            Assert.IsNotNull(c_test);
            Assert.AreEqual(c_test.ToString(), test.ToString());
            
        }

        [TestMethod()]
        public void CompareToTest()
        {
            var test1 = new RomanNumber(34);
            var test2 = new RomanNumber(34);
            string expected = "0";
            var c_test = test1.CompareTo(test2);
            Assert.IsNotNull(c_test);
            Assert.AreEqual(c_test.ToString(), expected);
            Assert.ThrowsException<RomanNumberException>(() => test1.CompareTo(null as RomanNumber));
        }

        [TestMethod()]
        public void RomanNumberTest()
        {
            RomanNumber test = new RomanNumber(55);
            Assert.IsNotNull(test);
            Assert.ThrowsException<RomanNumberException>(() => new RomanNumber(4000));
            Assert.ThrowsException<RomanNumberException>(() => new RomanNumber(0));
        }

        [TestMethod()]
        public void AddTest()
        {
            RomanNumber test1_1 = new RomanNumber(55);
            RomanNumber test1_2 = new RomanNumber(34);
            string expected1 = "LXXXIX";

            Assert.AreEqual(expected1, RomanNumber.Add(test1_1, test1_2).ToString());
            RomanNumber test2_1 = new RomanNumber(3550);
            RomanNumber test2_2 = new RomanNumber(650); 
            Assert.ThrowsException<RomanNumberException>(() => RomanNumber.Add(test2_1, test2_2));
            Assert.ThrowsException<RomanNumberException>(() => RomanNumber.Add(null as RomanNumber, test2_2));
        }

        [TestMethod()]
        public void SubTest()
        {
            RomanNumber test1 = new RomanNumber(55);
            RomanNumber test2 = new RomanNumber(34);
            string expected = "XXI";

            Assert.AreEqual(expected, RomanNumber.Sub(test1, test2).ToString());
            Assert.ThrowsException<RomanNumberException>(() => RomanNumber.Sub(test2, test1));
            Assert.ThrowsException<RomanNumberException>(() => RomanNumber.Sub(null as RomanNumber, test1));
        }

        [TestMethod()]
        public void MulTest()
        {
            RomanNumber test1_1 = new RomanNumber(55);
            RomanNumber test1_2 = new RomanNumber(34);
            string expected = "MDCCCLXX";

            Assert.AreEqual(expected, RomanNumber.Mul(test1_1, test1_2).ToString());

            RomanNumber test2_1 = new RomanNumber(550);
            RomanNumber test2_2 = new RomanNumber(32);
            Assert.ThrowsException<RomanNumberException>(() => RomanNumber.Mul(test2_1, test2_2));
            Assert.ThrowsException<RomanNumberException>(() => RomanNumber.Mul(null as RomanNumber, test2_2));
        }

        [TestMethod()]
        public void DivTest()
        {
            RomanNumber test1 = new RomanNumber(55);
            RomanNumber test2 = new RomanNumber(34);
            string expected = "I";
            Assert.AreEqual(expected, RomanNumber.Div(test1, test2).ToString());
            Assert.ThrowsException<RomanNumberException>(() => RomanNumber.Div(test2, test1));
            Assert.ThrowsException<RomanNumberException>(() => RomanNumber.Div(null as RomanNumber, test2));
        }

        [TestMethod()]
        public void ToStringTest()
        {
            RomanNumber test = new RomanNumber(3999);
            string expected = "MMMCMXCIX";
            Assert.AreEqual(expected, test.ToString());
            Assert.ThrowsException<RomanNumberException>(() => new RomanNumber(5041));
        }
    }
}