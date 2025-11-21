using System;
using System.Web.Optimization;
using System.Web.Routing;
using Xunit;

namespace ftpappdemo82.Tests
{
    public class GlobalTests
    {
        [Fact]
        public void Global_ShouldBeInstantiable()
        {
            // Act
            var global = new Global();

            // Assert
            Assert.NotNull(global);
        }

        [Fact]
        public void Global_ShouldInheritFromHttpApplication()
        {
            // Act
            var global = new Global();

            // Assert
            Assert.IsAssignableFrom<System.Web.HttpApplication>(global);
        }
    }
}
