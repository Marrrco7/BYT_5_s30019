namespace DesignPattern.Strategy.Discount.Payment;

public class PaymentCalculator(IPaymentStrategy paymentStrategy)
{
    public decimal CalculateTotal(Order order) => paymentStrategy.CalculateTotal(order);
    
}