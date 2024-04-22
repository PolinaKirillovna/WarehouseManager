namespace StockManager.Models;

public class Pallet : WarehouseItem
{
    private readonly List<Box> _boxes = new List<Box>();
    public IReadOnlyCollection<Box> Boxes => _boxes;
    
    public override double Weight => _boxes.Sum(box => box.Weight) + 30;
    public DateTime ExpiryDate => _boxes.Any() ? _boxes.Min(box => box.ExpiryDate) : DateTime.MinValue;


    public override double Volume => base.Volume + _boxes.Sum(box => box.Volume);

    public Pallet(double width, double height, double depth) 
        : base(width, height, depth)
    {
    }
    
    public void AddBox(Box box)
    {
        if (box.Width <= Width && box.Depth <= Depth)
        {
            _boxes.Add(box);
        }
        else
        {
            throw new ArgumentException("Box dimensions exceed the pallet dimensions.");
        }
    }
}

    
