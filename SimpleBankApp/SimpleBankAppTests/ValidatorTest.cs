using SimpleBankApp;
using NUnit.Framework;
using System.Xml.Linq;

namespace SimpleBankAppTests
{
    public class ValidatorTest
    {
        [Test]
        public void TestAreDetailsValid()
        {
            Account validAccount = Validator.AreDetailValid("0", "123456789");

            Assert.IsTrue(validAccount is Account);

            Account invalidAccount = Validator.AreDetailValid("8", "123456789");

            Assert.IsFalse(invalidAccount is Account);

            Account blankEntrys = Validator.AreDetailValid("", "");

            Assert.IsFalse(blankEntrys is Account);

            Account notNumeric = Validator.AreDetailValid("ABC", "Hello");

            Assert.IsFalse(notNumeric is Account);

            Account wrongPassword = Validator.AreDetailValid("0", "12345678");

            Assert.IsFalse(wrongPassword is Account);
        }

        [Test]
        public void TestAccountFound()
        {
            Account testResult1 = Validator.AccountFound(0);

            Assert.IsTrue(testResult1 is Account);

            Account testResult2 = Validator.AccountFound(10);

            Assert.Null(testResult2);
        }

        [Test]
        public void TestEmptyTextCheck()
        {
            bool testAccEmpty = Validator.EmptyTextCheck("", "123");

            Assert.True(testAccEmpty);

            bool testPACEmpty = Validator.EmptyTextCheck("999", "");

            Assert.True(testPACEmpty);

            bool testBothEmpty = Validator.EmptyTextCheck("", "");

            Assert.True(testBothEmpty);

            bool testBothFull = Validator.EmptyTextCheck("5", "127896");

            Assert.False(testBothFull);
        }

        [Test]
        public void TestNumericCheck()
        {
            bool testAllLetters = Validator.NumericCheck("Hello");

            Assert.False(testAllLetters);

            bool testAllNumeric = Validator.NumericCheck("123456");

            Assert.True(testAllNumeric);

            bool testHalfandHalf = Validator.NumericCheck("123ABC");

            Assert.False(testHalfandHalf);
        }
    }
}