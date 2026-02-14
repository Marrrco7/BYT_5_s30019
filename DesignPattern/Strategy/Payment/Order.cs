namespace DesignPattern.Strategy.Discount.Payment;

public record Order(decimal Subtotal, string CustomerName, string CardNumber);