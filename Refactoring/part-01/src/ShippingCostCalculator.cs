namespace RefactoringLab;

public class ShippingCostCalculator
{
    public decimal Calculate(ICalculate carrier, decimal weightKg)
    {
        return carrier.Calculate(weightKg);
    }
}


public interface ICalculate
{
    public decimal Calculate(decimal weightKg);
}


public class AramexCalculator : ICalculate
{
    public decimal Calculate(decimal weightKg) => weightKg * 12m;
}

public class FedExCalculator : ICalculate
{
    public decimal Calculate(decimal weightKg) => weightKg * 15m;
}

public class DHLCalculator : ICalculate
{
    public decimal Calculate(decimal weightKg) => weightKg * 18m;
}
public class NewCalculator : ICalculate
{
    public decimal Calculate(decimal weightKg) => weightKg * 18m;
}