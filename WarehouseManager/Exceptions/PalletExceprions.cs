using StockManager.Models;

namespace StockManager.Exceptions;

public class PalletExceprions : WarehouseExceptions
{
    internal PalletExceprions(string? message) 
        : base(message)
    {
    }

    internal static PalletExceprions BoxSizeError(Box box, Pallet pallet)
    {
        string message = $"Box dimensions exceed the pallet dimensions. Box sizes: width - {box.Width}, depth - {box.Depth}. " +
            $"Pallet sizes: width - {pallet.Width}, depth - {pallet.Depth}.";
        return new PalletExceprions(message);
    }
}