namespace DesignPattern.Strategy.Discount.Payment;

public class CardPayment : IPaymentStrategy
{
    public bool CanHandle(Order order)
    {
        return order.Subtotal >= 10m;
    }

    public decimal CalculateTotal(Order order)
    {
        return order.Subtotal - order.Subtotal * 0.1m;
    }
}