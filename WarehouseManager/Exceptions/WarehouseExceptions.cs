namespace StockManager.Exceptions;

public abstract class WarehouseExceptions : Exception
{
    private protected WarehouseExceptions(string? message) 
        : base(message)
    {
    }
}