using DesignPattern.Strategy.Discount.Payment;

namespace DesignPattern.Strategy.Payment
{
    public interface IPaymentStrategy
    {
        bool CanHandle(Order order);
        decimal CalculateTotal(Order order);
    }
}