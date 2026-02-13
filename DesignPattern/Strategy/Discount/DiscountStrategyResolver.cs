using DesignPattern.Strategy.Shipping;

namespace DesignPattern.Strategy.Discount;

public class DiscountStrategyResolver(IEnumerable<IDiscountStrategy> strategies)
{
    private readonly IReadOnlyList<IDiscountStrategy> _strategies = strategies.ToList();
    
    public IDiscountStrategy Resolve(Order order)
        => _strategies.FirstOrDefault(s => s.CanHandle(order))
           ?? throw new InvalidOperationException("No strategy found for order.");
}