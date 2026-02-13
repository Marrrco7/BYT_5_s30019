namespace DesignPattern.Strategy.Shipping;

public class ShippingCostCalculator(IShippingCostStrategy shippingCostStrategy)
{
    private readonly IShippingCostStrategy _shippingCostStrategy = shippingCostStrategy;

    public decimal Calculate(Order order) => _shippingCostStrategy.Calculate(order);
}