using FizzBuzzProject.Controllers;
using FizzBuzzProject.Repository;
using Microsoft.AspNetCore.Mvc;
using Moq;

[TestFixture]
public class FizzBuzzControllerTests
{
    private Mock<IDivision> _mockFactory;
    private FizzBuzzController _controller;

    [SetUp]
    public void Setup()
    {
        _mockFactory = new Mock<IDivision>();
        _controller = new FizzBuzzController(_mockFactory.Object);
    }

    [Test]
    public void CalculateFizzBuzz_ValidInput_ReturnsExpectedResult()
    {
        // Arrange
        string input = "15";
        string expectedResult = "FizzBuzz";
        _mockFactory.Setup(x => x.GetFizzBuzzResult(It.IsAny<int>())).Returns(expectedResult);

        // Act
        var response = _controller.CalculateFizzBuzz(input);

        // Assert
        Assert.IsInstanceOf<OkObjectResult>(response.Result);
        var okResult = response.Result as OkObjectResult;
        Assert.AreEqual(expectedResult, okResult.Value);
    }
    [Test]
    public void CalculateFizzBuzz_InputIs3_ReturnsExpectedResult()
    {
        // Arrange
        string input = "3";
        string expectedResult = "Fizz";
        _mockFactory.Setup(x => x.GetFizzBuzzResult(It.IsAny<int>())).Returns(expectedResult);

        // Act
        var response = _controller.CalculateFizzBuzz(input);

        // Assert
        Assert.IsInstanceOf<OkObjectResult>(response.Result);
        var okResult = response.Result as OkObjectResult;
        Assert.AreEqual(expectedResult, okResult.Value);
    }
    [Test]
    public void CalculateFizzBuzz_InputIs5_ReturnsExpectedResult()
    {
        // Arrange
        string input = "5";
        string expectedResult = "Buzz";
        _mockFactory.Setup(x => x.GetFizzBuzzResult(It.IsAny<int>())).Returns(expectedResult);

        // Act
        var response = _controller.CalculateFizzBuzz(input);

        // Assert
        Assert.IsInstanceOf<OkObjectResult>(response.Result);
        var okResult = response.Result as OkObjectResult;
        Assert.AreEqual(expectedResult, okResult.Value);
    }

    [Test]
    public void CalculateFizzBuzz_Input23_ReturnsExpectedResult()
    {
        // Arrange
        string input = "23";
        string expectedResult = "23/3 = 7 and 23/5 = 4";
        _mockFactory.Setup(x => x.GetFizzBuzzResult(It.IsAny<int>())).Returns(expectedResult);

        // Act
        var response = _controller.CalculateFizzBuzz(input);

        // Assert
        Assert.IsInstanceOf<OkObjectResult>(response.Result);
        var okResult = response.Result as OkObjectResult;
        Assert.AreEqual(expectedResult, okResult.Value);
    }
    [Test]
    public void CalculateFizzBuzz_InputIs1_ReturnsExpectedResult()
    {
        // Arrange
        string input = "1";
        string expectedResult = "1/3 = 0 and 1/5 = 0";
        _mockFactory.Setup(x => x.GetFizzBuzzResult(It.IsAny<int>())).Returns(expectedResult);

        // Act
        var response = _controller.CalculateFizzBuzz(input);

        // Assert
        Assert.IsInstanceOf<OkObjectResult>(response.Result);
        var okResult = response.Result as OkObjectResult;
        Assert.AreEqual(expectedResult, okResult.Value);
    }

    [Test]
    public void CalculateFizzBuzz_InvalidInput_ReturnsBadRequest()
    {
        // Arrange
        string input = "A";

        // Act
        var response = _controller.CalculateFizzBuzz(input);

        // Assert
        Assert.IsInstanceOf<BadRequestObjectResult>(response.Result);
        var badRequestResult = response.Result as BadRequestObjectResult;
        Assert.AreEqual("Invalid Item", badRequestResult.Value);
    }

    // Add more tests for edge cases, empty input, specific numbers like 1, 3, 5, etc.
}
