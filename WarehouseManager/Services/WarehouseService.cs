using StockManager.Exceptions;
using StockManager.Models;

namespace StockManager.Services;

public class WarehouseService
{
    //Группировка всех паллетов по сроку годности
    //Сортировка по возрастанию срока годности
    //Сортировка в каждой группе по весу
    public IEnumerable<Pallet> SortPalletsByExpiryDateAndWeight(IEnumerable<Pallet> pallets)
    {
        if (!pallets.Any())
        {
            throw ServiceExceptions.EmptyPallet();
        }

        return pallets
            .GroupBy(p => p.ExpiryDate)
            .OrderBy(g => g.Key)
            .SelectMany(g => g.OrderBy(p => p.Weight));
    }
    
    //Сортировка паллет по убыванию срока годности 
    //Сортировка по объему 
    //Выбор трех
    public IEnumerable<Pallet> GetPalletsWithLongestExpiryBoxes(IEnumerable<Pallet> pallets)
    {
        if (!pallets.Any())
        {
            throw ServiceExceptions.EmptyPallet();
        }
        
        return pallets
            .Where(p => p.Boxes.Any())
            .OrderByDescending(p => p.Boxes.Max(b => b.ExpiryDate))
            .ThenBy(p => p.Volume)
            .Take(3);
    }
}
