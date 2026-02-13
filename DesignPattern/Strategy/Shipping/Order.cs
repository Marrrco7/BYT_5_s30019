namespace DesignPattern.Strategy.Shipping;

public record Order(decimal Subtotal, decimal WeightKg, string Country);