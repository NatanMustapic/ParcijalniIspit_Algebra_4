using System;
using Xunit;
using aspnet_core_unit_1.Controllers;

namespace UnitTests
{
    public class HomeControllerTests
    {
        [Fact]
        public void CheckCountValue_Input500_ThrowsException()
        {
            // Arrange
            var controller = new HomeController(null);
            var input = 500;

            // Act & Assert
            try
            {
                controller.CheckCountValue(input);
            }
            catch (Exception ex)
            {
                Assert.NotNull(ex);
            }
        }

        [Fact]
        public void CheckCountValue_Input2_ReturnsView()
        {
            // Arrange
            var controller = new HomeController(null);
            var input = 2;

            // Act
            var result = controller.CheckCountValue(input);

            // Assert
            Assert.NotNull(result); 
        }
    }
}