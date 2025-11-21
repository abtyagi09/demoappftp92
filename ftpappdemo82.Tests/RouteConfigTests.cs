using System.Web.Routing;
using Microsoft.AspNet.FriendlyUrls;
using Xunit;

namespace ftpappdemo82.Tests
{
    public class RouteConfigTests
    {
        [Fact]
        public void RegisterRoutes_ShouldEnableFriendlyUrls()
        {
            // Arrange
            var routes = new RouteCollection();

            // Act
            RouteConfig.RegisterRoutes(routes);

            // Assert
            Assert.NotEmpty(routes);
        }

        [Fact]
        public void RegisterRoutes_ShouldAddAtLeastOneRoute()
        {
            // Arrange
            var routes = new RouteCollection();

            // Act
            RouteConfig.RegisterRoutes(routes);

            // Assert
            Assert.True(routes.Count > 0);
        }

        [Fact]
        public void RegisterRoutes_ShouldNotThrowException()
        {
            // Arrange
            var routes = new RouteCollection();

            // Act & Assert
            var exception = Record.Exception(() => RouteConfig.RegisterRoutes(routes));
            Assert.Null(exception);
        }
    }
}
