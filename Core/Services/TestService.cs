using Core.Test;

namespace Core.Services
{
    public class TestService
    {
        public TestClass GetTestBody()
        {
            var body = new TestClass();
            body.Name = "test";
            return body;
        }
    }
}
