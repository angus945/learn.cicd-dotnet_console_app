using CICDDemo;
using Xunit;

namespace CICDDemo.Tests;

public class GreetingTests
{
    [Fact]
    public void Create_ReturnsExpectedGreeting()
    {
        // Arrange
        var name = "Test User";
        var expectedGreeting = $"Hello, {name}! The CI/CD project is running.";

        // Act
        var actualGreeting = Greeting.Create(name);

        // Assert
        Assert.Equal(expectedGreeting, actualGreeting);
    }

    [Theory]
    [InlineData("")]
    [InlineData(" ")]
    [InlineData("\t")]
    public void Create_ThrowsArgumentException_ForInvalidName(string name)
    {
        // Act 
        Action act = () => Greeting.Create(name);

        // Assert
        ArgumentException exception = Assert.Throws<ArgumentException>(act);

        Assert.Equal("name", exception.ParamName);
    }
}