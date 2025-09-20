using Xunit;

namespace TriangleApp.Tests;

public class TriangleTests
{
    [Fact]
    public void IsValid_WithValidTriangle_ReturnsTrue()
    {
        // Arrange
        int a = 3, b = 4, c = 5;
        
        // Act
        bool result = Triangle.IsValid(a, b, c);
        
        // Assert
        Assert.True(result);
    }

    [Theory]
    [InlineData(1, 2, 3, false)] // Not a triangle
    [InlineData(2, 2, 3, true)]  // Valid triangle
    [InlineData(1, 1, 2, false)] // Not a triangle
    public void IsValid_WithVariousInputs_ReturnsExpectedResult(int a, int b, int c, bool expected)
    {
        // Act
        bool result = Triangle.IsValid(a, b, c);
        
        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(1, 1, 1, true)]  // Equilateral triangle (minimum)
    [InlineData(1, 2, 2, true)]  // Valid triangle (boundary value)
    [InlineData(2, 2, 2, true)]  // Equilateral triangle
    public void IsValid_WithBoundaryValues_ReturnsExpectedResult(int a, int b, int c, bool expected)
    {
        // Act
        bool result = Triangle.IsValid(a, b, c);
        
        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(3, 4, 5, true)]  // Right triangle
    [InlineData(5, 5, 5, true)]  // Equilateral triangle
    [InlineData(3, 3, 4, true)]  // Isosceles triangle
    [InlineData(2, 3, 4, true)]  // Scalene triangle
    public void IsValid_WithSpecialTrianglePatterns_ReturnsTrue(int a, int b, int c, bool expected)
    {
        // Act
        bool result = Triangle.IsValid(a, b, c);
        
        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(1, 1, 3, false)] // 1+1=2 ≤ 3, not a triangle
    [InlineData(1, 3, 1, false)] // 1+1=2 ≤ 3, not a triangle
    [InlineData(3, 1, 1, false)] // 1+1=2 ≤ 3, not a triangle
    public void IsValid_WithTriangleInequalityViolations_ReturnsFalse(int a, int b, int c, bool expected)
    {
        // Act
        bool result = Triangle.IsValid(a, b, c);
        
        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(2, 3, 5, false)] // Collinear points (not a triangle)
    [InlineData(1, 2, 3, false)] // Collinear points (not a triangle)
    public void IsValid_WithCollinearPoints_ReturnsFalse(int a, int b, int c, bool expected)
    {
        // Act
        bool result = Triangle.IsValid(a, b, c);
        
        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(1000000, 1000000, 1000000, true)] // Large equilateral triangle
    [InlineData(1, 1, 999999, false)] // Very thin triangle (boundary value) - actually not a triangle
    public void IsValid_WithExtremeValues_ReturnsExpectedResult(int a, int b, int c, bool expected)
    {
        // Act
        bool result = Triangle.IsValid(a, b, c);
        
        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(int.MaxValue, int.MaxValue, int.MaxValue, true)] // Equilateral triangle (overflow consideration)
    [InlineData(int.MaxValue, int.MaxValue, 1, true)] // Boundary value
    [InlineData(int.MaxValue, 1, 1, false)] // Boundary value - actually not a triangle
    public void IsValid_WithIntMaxValue_ReturnsExpectedResult(int a, int b, int c, bool expected)
    {
        // Act
        bool result = Triangle.IsValid(a, b, c);
        
        // Assert
        Assert.Equal(expected, result);
    }
}
