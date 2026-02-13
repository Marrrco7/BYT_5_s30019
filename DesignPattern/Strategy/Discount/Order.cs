namespace DesignPattern.Strategy.Discount;

public record Order(decimal Subtotal, string CustomerType, int ItemsCount, DateTime OrderDate);