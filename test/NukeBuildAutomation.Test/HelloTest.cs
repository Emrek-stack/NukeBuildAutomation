namespace NukeBuildAutomation.HelloWorld;

[TestFixture]
public class HelloTests
{
    [Test]
    public void HelloWorld_ExpectHelloWorld()
    {
        //Arrange
        var hello = new Hello();

        //Act
        var result = hello.HelloWorld();

        //Assert
        Assert.That(result, Is.EqualTo("Hello, World!"));
    }
}