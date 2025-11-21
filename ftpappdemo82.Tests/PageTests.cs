using System;
using System.Web.UI;
using Xunit;

namespace ftpappdemo82.Tests
{
    public class PageTests
    {
        [Fact]
        public void DefaultPage_ShouldBeInstantiable()
        {
            // Act
            var page = new _Default();

            // Assert
            Assert.NotNull(page);
        }

        [Fact]
        public void DefaultPage_ShouldInheritFromPage()
        {
            // Act
            var page = new _Default();

            // Assert
            Assert.IsAssignableFrom<Page>(page);
        }

        [Fact]
        public void AboutPage_ShouldBeInstantiable()
        {
            // Act
            var page = new About();

            // Assert
            Assert.NotNull(page);
        }

        [Fact]
        public void AboutPage_ShouldInheritFromPage()
        {
            // Act
            var page = new About();

            // Assert
            Assert.IsAssignableFrom<Page>(page);
        }

        [Fact]
        public void ContactPage_ShouldBeInstantiable()
        {
            // Act
            var page = new Contact();

            // Assert
            Assert.NotNull(page);
        }

        [Fact]
        public void ContactPage_ShouldInheritFromPage()
        {
            // Act
            var page = new Contact();

            // Assert
            Assert.IsAssignableFrom<Page>(page);
        }
    }
}
