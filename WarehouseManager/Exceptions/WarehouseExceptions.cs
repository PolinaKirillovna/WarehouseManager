namespace StockManager.Exceptions;

public abstract class StockExceptions : Exception
{
    private protected StockExceptions(string? message) 
        : base(message)
    {
    }
}