namespace DesignPattern.Strategy.Discount;

public class VipCustomerDiscount : IDiscountStrategy
{
    public decimal CalculateDiscount(Order order)
        => order.Subtotal - order.ItemsCount * 20m;

    public bool CanHandle(Order order) => true;
}