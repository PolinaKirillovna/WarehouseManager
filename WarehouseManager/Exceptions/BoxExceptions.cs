namespace StockManager.Exceptions;

public class BoxExceptions : WarehouseExceptions
{
    internal BoxExceptions(string? message) 
        : base(message)
    {
    }

    internal static BoxExceptions MissingProductionOrExpiryDate()
    {
        string message = "Production date or Expiration date must be specified.";
        return new BoxExceptions(message);
    }
}