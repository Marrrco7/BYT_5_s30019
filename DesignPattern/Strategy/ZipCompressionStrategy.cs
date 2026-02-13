using System;

namespace DesignPattern.Strategy;

public class ZipCompressionStrategy:ICompressionStrategy
{
    public void Compress(string filename)
    {
        Console.WriteLine($"File {filename} compressed using ZIP compression.");
    }
}