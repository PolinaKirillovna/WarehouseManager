using StockManager.Exceptions;
using StockManager.Models;
using StockManager.Services;
using Xunit;

namespace StockManager.Tests;

public class WarehouseServiceTests
{
    [Fact]
    public void SortPalletsByExpiryDateAndWeight_EmptyCollection_ShouldThrowException()
    {
        var service = new WarehouseService();
        var pallets = new List<Pallet>();
        
        Assert.Throws<ServiceExceptions>(() => service.SortPalletsByExpiryDateAndWeight(pallets));
    }

    [Fact]
    public void GetPalletsWithLongestExpiryBoxes_EmptyCollection_ShouldThrowException()
    {
        var service = new WarehouseService();
        var pallets = new List<Pallet>();
        
        Assert.Throws<ServiceExceptions>(() => service.GetPalletsWithLongestExpiryBoxes(pallets));
    }

}