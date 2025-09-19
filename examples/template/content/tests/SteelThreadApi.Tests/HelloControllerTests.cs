using ${{ values.name }}.Controllers;
using Xunit;

namespace ${{ values.name }}.Tests
{
    public class HelloControllerTests
    {
        [Fact]
        public void Get_ReturnsHelloMessage()
        {
            var controller = new HelloController();
            var result = controller.Get();
            Assert.Equal("Hello from ${{ values.name }}!", result.Value);
        }
    }
}
