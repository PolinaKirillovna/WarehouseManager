using StockManager.Models;
using StockManager.Services;
using Xunit;

namespace StockManager.Tests;

public class WarehouseServiceTests
{
    [Fact]
    public void SortPalletsByExpiryDateAndWeight_ReturnsCorrectOrder()
    {
        // Arrange
        var service = new WarehouseService();
        var pallets = new List<Pallet>
        {
            // Создаем паллеты с разными сроками годности и весом для тестирования
        };

        // Act
        var sortedPallets = service.SortPalletsByExpiryDateAndWeight(pallets);

        // Assert
        // Проверка порядка сортировки
    }

    [Fact]
    public void GetPalletsWithLongestExpiryBoxes_ReturnsTop3WithCorrectOrder()
    {
        // Arrange
        var service = new WarehouseService();
        var pallets = new List<Pallet>
        {
            // Создаем паллеты с коробками разного срока годности для тестирования
        };

        // Act
        var topPallets = service.GetPalletsWithLongestExpiryBoxes(pallets);

        // Assert
        // Проверка наличия 3 паллет и их порядка
    }
}