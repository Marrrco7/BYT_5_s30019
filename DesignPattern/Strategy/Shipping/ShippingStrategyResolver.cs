namespace DesignPattern.Strategy.Shipping;

public class ShippingStrategyResolver(IEnumerable<IShippingCostStrategy> strategies)
{
    private readonly IReadOnlyList<IShippingCostStrategy> _strategies = strategies.ToList();
    
    public IShippingCostStrategy Resolve(Order order)
        => _strategies.FirstOrDefault(s => s.CanHandle(order))
           ?? throw new InvalidOperationException("No strategy found for order.");
}