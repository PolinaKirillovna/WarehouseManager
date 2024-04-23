using StockManager.Exceptions;
using StockManager.Models;
using Xunit;
namespace StockManager.Tests;


public class BoxTests
{
    [Fact]
    public void CreateBox_ValidParameters_ShouldSetProperties()
    {
        var productionDate = DateTime.Now;
        var weight = 10.0;
        
        var box = new Box(1, 1, 1, weight, productionDate);
        
        Assert.Equal(productionDate, box.ProductionDate);
        Assert.Equal(weight, box.Weight);
    }

    [Fact]
    public void CreateBox_WithNullProductionDateAndDefaultExpiryDate_ShouldThrowException()
    {
        Assert.Throws<BoxExceptions>(() => new Box(1, 1, 1, 10.0, null, default(DateTime)));
    }
}