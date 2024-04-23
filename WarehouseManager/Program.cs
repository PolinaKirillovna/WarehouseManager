using StockManager.Models;

class Program
{
    static void Main(string[] args)
    {
        var pallets = new List<Pallet>
        {
            new Pallet(900, 160, 150),
            new Pallet(800, 893, 100),
            new Pallet(340, 91, 100)
        };

        var random = new Random();
        DateTime baseDate = new DateTime(2023, 12, 4);
        for (int i = 0; i < 10; i++)
        {
            int depth = random.Next(1, 201); 
            int width = random.Next(1, 201); 
            int height = random.Next(1, 101); 
            int weight = random.Next(1, 101);
            var productionDate = baseDate.AddDays(random.Next(0, 365));
            var box = new Box(width, height, depth, weight, productionDate);
            pallets[random.Next(pallets.Count)].AddBox(box);
        }
        
        var sortedPallets = pallets
            .GroupBy(p => p.ExpiryDate)
            .OrderBy(g => g.Key)
            .SelectMany(g => g.OrderBy(p => p.Weight))
            .ToList();

        Console.WriteLine("Паллеты по сроку годности и весу:");
        foreach (var pallet in sortedPallets)
        {
            Console.WriteLine($"ID: {pallet.Id}, Срок годности: {pallet.ExpiryDate.ToString("dd.MM.yyyy")}, Вес: {pallet.Weight}");
        }
        
        var topExpiryPallets = pallets.OrderByDescending(p => p.ExpiryDate).Take(3).OrderBy(p => p.Volume).ToList();

        Console.WriteLine("\nТри паллеты с наибольшим сроком годности:");
        foreach (var pallet in topExpiryPallets)
        {
            Console.WriteLine($"ID: {pallet.Id}, Срок годности: {pallet.ExpiryDate.ToString("dd.MM.yyyy")}, Объем: {pallet.Volume}");
        }
    }
}