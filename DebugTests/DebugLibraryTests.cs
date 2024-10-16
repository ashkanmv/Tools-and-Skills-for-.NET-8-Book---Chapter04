using Packt.Shared;

namespace DebugTests
{
    public class DebugLibraryTests
    {
        [Fact]
        public void WebConfigPropertiesInstantiated()
        {
            WebConfig config = new WebConfig();

            Assert.NotNull(config.Base64Encoded);
            Assert.NotNull(config.DbConnectionString);
            Assert.NotNull(config.JsonWebToken);
        }
    }
}