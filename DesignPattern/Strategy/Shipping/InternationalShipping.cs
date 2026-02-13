namespace DesignPattern.Strategy.Shipping;

public class InternationalShipping : IShippingCostStrategy
{
    public bool CanHandle(Order order) => order.Country != "PL";

    public decimal Calculate(Order order)
        => 15m + 2m * order.WeightKg;
}