using StockManager.Models;

class Program
{
    static void Main(string[] args)
    {
        // Генерация данных
        var pallets = new List<Pallet>
        {
            new Pallet(120, 22, 100),
            new Pallet(120, 22, 100),
            new Pallet(120, 22, 100)
        };

        var random = new Random();
        DateTime baseDate = new DateTime(2023, 1, 1);
        for (int i = 0; i < 10; i++)
        {
            var productionDate = baseDate.AddDays(random.Next(0, 365));
            var box = new Box(20, 10, 10, 5, productionDate);
            pallets[random.Next(pallets.Count)].AddBox(box);
        }

        // Сортировка и группировка
        var sortedPallets = pallets
            .GroupBy(p => p.ExpiryDate)
            .OrderBy(g => g.Key)
            .SelectMany(g => g.OrderBy(p => p.Weight))
            .ToList();

        Console.WriteLine("Паллеты по сроку годности и весу:");
        foreach (var pallet in sortedPallets)
        {
            Console.WriteLine($"ID: {pallet.Id}, Срок годности: {pallet.ExpiryDate.ToShortDateString()}, Вес: {pallet.Weight}");
        }

        // Три паллеты с наибольшим сроком годности
        var topExpiryPallets = pallets.OrderByDescending(p => p.ExpiryDate).Take(3).OrderBy(p => p.Volume).ToList();

        Console.WriteLine("\nТри паллеты с наибольшим сроком годности:");
        foreach (var pallet in topExpiryPallets)
        {
            Console.WriteLine($"ID: {pallet.Id}, Срок годности: {pallet.ExpiryDate.ToShortDateString()}, Объем: {pallet.Volume}");
        }
    }
}