namespace DesignPattern.Strategy.Discount;

public class DiscountCalculator(IDiscountStrategy discountStrategy)
{
    public decimal CalculateDiscount(Order order) => discountStrategy.CalculateDiscount(order);
}