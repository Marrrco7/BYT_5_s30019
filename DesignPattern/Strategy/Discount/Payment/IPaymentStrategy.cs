namespace DesignPattern.Strategy.Discount.Payment;

public interface IPaymentStrategy
{
    bool CanHandle(Order order);
    decimal CalculateTotal(Order order);
}