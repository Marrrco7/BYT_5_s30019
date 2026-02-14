using DesignPattern.Strategy.Discount.Payment;

namespace DesignPattern.Strategy.Payment;

public class CashPayment : IPaymentStrategy
{
    public bool CanHandle(Order order) => order.Subtotal < 10000m;

    public decimal CalculateTotal(Order order)
        => order.Subtotal + 1;
}