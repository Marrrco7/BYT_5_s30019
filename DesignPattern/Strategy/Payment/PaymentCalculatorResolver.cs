using DesignPattern.Strategy.Discount.Payment;

namespace DesignPattern.Strategy.Payment;

public class PaymentCalculatorResolver
{
    private readonly IReadOnlyList<IPaymentStrategy> _strategies = new List<IPaymentStrategy>();
    
    public IPaymentStrategy? Resolve(Order order) => _strategies.FirstOrDefault(s => s.CanHandle(order));
}