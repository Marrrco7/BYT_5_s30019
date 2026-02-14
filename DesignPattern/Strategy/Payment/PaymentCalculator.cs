using DesignPattern.Strategy.Discount.Payment;

namespace DesignPattern.Strategy.Payment;

public class PaymentCalculator(IPaymentStrategy paymentStrategy)
{
    public decimal CalculateTotal(Order order) => paymentStrategy.CalculateTotal(order);
    
}