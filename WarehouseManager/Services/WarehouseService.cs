using StockManager.Models;

namespace StockManager.Services;

public class WarehouseService
{
    public IEnumerable<Pallet> SortPalletsByExpiryDateAndWeight(IEnumerable<Pallet> pallets)
    {
        return pallets
            .GroupBy(p => p.ExpiryDate)
            .OrderBy(g => g.Key)
            .SelectMany(g => g.OrderBy(p => p.Weight));
    }

    public IEnumerable<Pallet> GetPalletsWithLongestExpiryBoxes(IEnumerable<Pallet> pallets)
    {
        return pallets
            .Where(p => p.Boxes.Any())
            .OrderByDescending(p => p.Boxes.Max(b => b.ExpiryDate))
            .ThenBy(p => p.Volume)
            .Take(3);
    }
}
