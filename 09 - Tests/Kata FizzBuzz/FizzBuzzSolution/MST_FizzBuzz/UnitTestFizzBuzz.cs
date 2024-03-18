using CL_FizzBuzz;

namespace MST_FizzBuzz
{
    [TestClass]
    public class UnitTestFizzBuzz
    {
        [TestMethod]
        public void Given_Number_1_When_FizzBuzz_Then_Return_String_1()
        {
            // Arrange
            int nombre = 1;
            string retour;

            // Act
            retour = FizzBuzzToolTDD.FizzBuzz(nombre);

            // Assert 
            Assert.AreEqual("1", retour);
        }

        [TestMethod]
        public void Given_Number_3_When_FizzBuzz_Then_Return_String_Fizz()
        {
            // Arrange
            int nombre = 3;
            string retour;

            // Act
            retour = FizzBuzzToolTDD.FizzBuzz(nombre);

            // Assert 
            Assert.AreEqual("Fizz", retour);
        }

        [TestMethod]
        public void Given_Number_5_When_FizzBuzz_Then_Return_String_Buzz()
        {
            // Arrange
            int nombre = 5;
            string retour;

            // Act
            retour = FizzBuzzToolTDD.FizzBuzz(nombre);

            // Assert 
            Assert.AreEqual("Buzz", retour);
        }
    }
}
