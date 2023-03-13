using MindBox;
using NUnit.Framework;

namespace TestGeometry;

public class GeometryLibraryTest
{
    [Test]
    public void CalculateCircle_WithPositiveRadius_ReturnsCorrectArea()
    {
        var radius = 5;
        
        var area = Geometry.CalculateCircle(radius);
        
        Assert.AreEqual(Math.PI * radius * radius, area);
    }
    
    [Test]
    public void CalculateCircle_WithNegativeRadius_ThrowsArgumentException()
    {
        double radius = -5;
        
        Assert.Throws<ArgumentException>(() => Geometry.CalculateCircle(radius));
    }
    
    [Test]
    public void CalculateTriangle_WithValidSides_ReturnsCorrectArea()
    {
        double a = 3;
        double b = 4;
        double c = 5;
        
        var area = Geometry.CalculateTriangle(a, b, c);
        
        Assert.AreEqual(6, area);
    }
    
    [Test]
    public void CalculateTriangle_WithInvalidSides_ThrowsArgumentException()
    {
        double a = 3;
        double b = 4;
        double c = 10;
        
        Assert.Throws<ArgumentException>(() => Geometry.CalculateTriangle(a, b, c));
    }
    
    [Test]
    public void CalculateCircleOrTriangle_WithValidArguments_ReturnsCorrectArea()
    {
        double a = 3;
        double b = 4;
        double c = 5;

        var area = Geometry.CalculateCircleOrTriangle(a, b, c);
        
        Assert.AreEqual(6, area);
    }
    
    [Test]
    public void CalculateCircleOrTriangle_WithValidRadius_ReturnsCorrectArea()
    {
        double radius = 5;
        
        var area = Geometry.CalculateCircleOrTriangle(radius);
        
        Assert.AreEqual(Math.PI * radius * radius, area);
    }
    
    [Test]
    public void CalculateCircleOrTriangle_WithInvalidArguments_ReturnsZero()
    {
        double a = 3;
        double b = 4;
        
        var area = Geometry.CalculateCircleOrTriangle(a, b);
        
        Assert.AreEqual(0, area);
    }
}