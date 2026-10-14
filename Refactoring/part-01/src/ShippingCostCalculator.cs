namespace RefactoringLab;

// public class ShippingCostCalculator
// {
//     public decimal Calculate(string carrier, decimal weightKg)
//     {
//         switch (carrier)
//         {
//             case "Aramex":
//                 return weightKg * 12m;
//             case "FedEx":
//                 return weightKg * 15m;
//             case "DHL":
//                 return weightKg * 18m;
//             default:
//                 throw new ArgumentException($"Unknown carrier: {carrier}");
//         }
//     }
// }



public class ShippingCostCalculator
{
    private readonly IShippingCostStrategy _strategy;

    public ShippingCostCalculator(IShippingCostStrategy strategy)
    {
        _strategy = strategy
            ?? throw new ArgumentNullException(nameof(strategy));
    }

    public decimal Calculate(decimal weightKg)
    {
        if (weightKg < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(weightKg));
        }

        return _strategy.Calculate(weightKg);
    }
}

public interface IShippingCostStrategy
{
    decimal Calculate(decimal weightKg);
}


public class AramexShippingCostStrategy : IShippingCostStrategy
{
    public decimal Calculate(decimal weightKg)
    {
        return weightKg * 12m;
    }
}

public class FedExShippingCostStrategy : IShippingCostStrategy
{
    public decimal Calculate(decimal weightKg)
    {
        return weightKg * 15m;
    }
}

public class DHLShippingCostStrategy : IShippingCostStrategy
{
    public decimal Calculate(decimal weightKg)
    {
        return weightKg * 18m;
    }
}