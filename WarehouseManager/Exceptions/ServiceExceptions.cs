namespace StockManager.Exceptions;

public class ServiceExceptions : WarehouseExceptions
{
    internal ServiceExceptions(string? message) 
        : base(message)
    {
    }

    internal static ServiceExceptions EmptyPallet()
    {
        string message = "Pallet list is empty. Check your data.";
        return new ServiceExceptions(message);
    }
}