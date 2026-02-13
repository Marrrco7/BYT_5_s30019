namespace DesignPattern.Strategy.Discount;

public interface IDiscountStrategy
{
    decimal CalculateDiscount(Order order);
    bool CanHandle(Order order);
}