namespace DesignPattern.Strategy.Discount;

public class RegularCustomerDiscount : IDiscountStrategy
{
    public decimal CalculateDiscount(Order order)
        => order.Subtotal - order.ItemsCount * 5m;

    public bool CanHandle(Order order)
     => order.Subtotal >= 10000m;
}