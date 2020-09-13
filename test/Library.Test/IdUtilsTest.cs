using NUnit.Framework;

using UnitTestAndDebug;

namespace Tests
{
    public class IdUtilsTests
    {
        
        [SetUp]
        public void Setup()
        {
                  }

        [Test]
        public void IdCorrect() 
        {
            bool isValid=IdUtils.IdIsValid("97757078");
            Assert.True(isValid);
        }
        [Test]
        public void IdCorrect2() 
        {
            bool isValid=IdUtils.IdIsValid("9.775.707-8");
            Assert.True(isValid);
        }
        [Test]
        public void IdCorrect3() 
        {
            bool isValid=IdUtils.IdIsValid("9.775.7078");
            Assert.True(isValid);
        }
        [Test]
        public void IdCorrect4() 
        {
            bool isValid=IdUtils.IdIsValid("9775707-8");
            Assert.True(isValid);
        }
        [Test]
        public void IdCorrect5() 
        {
            bool isValid=IdUtils.IdIsValid("9....775707-8");
            Assert.True(isValid);
        }
        [Test]
        public void LongIncorrect() 
        {
            bool isValid=IdUtils.IdIsValid("977570758");
            Assert.False(isValid);
        }
        [Test]
        public void LongIncorrect2() 
        {
            bool isValid=IdUtils.IdIsValid("9775707");
            Assert.False(isValid);
        }
        [Test]
        public void VerificationIncorrect() 
        {
            bool isValid=IdUtils.IdIsValid("977570759");
            Assert.False(isValid);
        }
        [Test]
        public void DigitIncorrect() 
        {
            bool isValid=IdUtils.IdIsValid("aaaaaaaa");
            Assert.False(isValid);
        }
        [Test]
        public void EmptyIncorrect() 
        {
            bool isValid=IdUtils.IdIsValid("");
            Assert.False(isValid);
        }
        [Test]
        public void NullIncorrect() 
        {
            bool isValid=IdUtils.IdIsValid(null);
            Assert.False(isValid);
        }
    }
}