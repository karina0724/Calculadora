using Xunit;
using Microsoft.AspNetCore.Mvc;
using Calculadora.Controllers;

namespace PruebasCalculadora
{
    public class OperationsControllerTests
    {
        private readonly OperationsController _controller;

        public OperationsControllerTests()
        {
            // Inicializamos el controlador
            _controller = new OperationsController();
        }

        [Fact]
        public void Add_Returns_Correct_Result()
        {
            // Act
            var result = _controller.Add(5, 3) as ViewResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal(8.0, result.ViewData["Result"]);
        }

        [Fact]
        public void Subtract_Returns_Correct_Result()
        {
            // Act
            var result = _controller.Subtract(10, 4) as ViewResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal(6.0, result.ViewData["Result"]);
        }

        [Fact]
        public void Multiply_Returns_Correct_Result()
        {
            // Act
            var result = _controller.Multiply(3, 4) as ViewResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal(12.0, result.ViewData["Result"]);
        }

        [Fact]
        public void Divide_Returns_Correct_Result()
        {
            // Act
            var result = _controller.Divide(10, 2) as ViewResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal(5.0, result.ViewData["Result"]);
        }

        [Fact]
        public void Divide_Returns_Error_For_Division_By_Zero()
        {
            // Act
            var result = _controller.Divide(10, 0) as ViewResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal("Error: División por cero no permitida.", result.ViewData["Result"]);
        }
    }
}
