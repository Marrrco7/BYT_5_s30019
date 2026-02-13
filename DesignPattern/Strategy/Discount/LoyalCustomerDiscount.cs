namespace DesignPattern.Strategy.Discount;

public class LoyalCustomerDiscount : IDiscountStrategy
{
    public decimal CalculateDiscount(Order order)
        => order.Subtotal - order.ItemsCount * 10m;

    public bool CanHandle(Order order)
        => order.Subtotal < 10000m;
}