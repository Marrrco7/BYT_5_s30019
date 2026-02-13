using System;

namespace DesignPattern.Strategy;

public class SevenZipCompressionStrategy:ICompressionStrategy
{
    public void Compress(string filename)
    {
        Console.WriteLine($"File {filename} compressed using 7zip compression.");
    }
}