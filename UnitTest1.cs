
namespace lab3;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
    }

    [TestMethod]
    public void BasicRooterTest()
    {
        // Create an instance to test: 
        Rooter rooter = new Rooter();
        // Define a test input and output value: 
        double expectedResult = 2.0;
        double input = expectedResult * expectedResult;
        // Run the method under test:
        double actualResult = rooter.SquareRoot(input);
        // Verify the result: 
        Assert.AreEqual(expectedResult, actualResult, delta: expectedResult / 100);
    }
}

internal class Rooter
{
    internal double SquareRoot(double input)
    {
        return input / 2;
    }
}