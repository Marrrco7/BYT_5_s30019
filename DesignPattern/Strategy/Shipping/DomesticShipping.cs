namespace DesignPattern.Strategy.Shipping;

public sealed class DomesticShipping : IShippingCostStrategy
{
    public bool CanHandle(Order order) => order.Country == "PL";

    public decimal Calculate(Order order)
        => 5m + 0.5m * order.WeightKg;
}