namespace DesignPattern.Strategy.Discount;

public class DiscountCalculator(IDiscountStrategy discountStrategy)
{
    private readonly IDiscountStrategy _discountStrategy = discountStrategy;
    
    public decimal CalculateDiscount(Order order) => _discountStrategy.CalculateDiscount(order);
}