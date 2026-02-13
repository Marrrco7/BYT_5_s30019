namespace DesignPattern.Strategy.Shipping;

public interface IShippingCostStrategy
{
    bool CanHandle(Order order);
    decimal Calculate(Order order);
}