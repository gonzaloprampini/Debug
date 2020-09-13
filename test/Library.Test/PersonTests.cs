using NUnit.Framework;

using UnitTestAndDebug;

namespace Tests
{
    public class PersonTests
    {
        private Person person;
        [SetUp]
        public void Setup()
        {
           person = new Person("Gonzalo","31075329");
        }

        [Test]
        public void SetNameCorrect() 
        {
            person.Name="Jorge";
            string expected="Jorge";
            Assert.AreEqual(expected,person.Name,"No se modifico el nombre");

        }
        [Test]
        public void SetNameEmpty() 
        {
            person.Name="";
            string expected="Gonzalo";
            Assert.AreEqual(expected,person.Name,"Esta mal, se modifico el nombre con vacio");

        }
         [Test]
        public void GetNameCorrect()
        {
            string expected="Gonzalo";
            Assert.AreEqual(expected,person.Name,"No se recupero el nombre correctamente ");
        }
    }
}