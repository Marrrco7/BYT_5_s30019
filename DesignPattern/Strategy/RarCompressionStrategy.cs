using System;

namespace DesignPattern.Strategy;

public class RarCompressionStrategy:ICompressionStrategy
{
    public void Compress(string filename)
    {
        Console.WriteLine($"File {filename} compressed using RAR compression.");
    }
}