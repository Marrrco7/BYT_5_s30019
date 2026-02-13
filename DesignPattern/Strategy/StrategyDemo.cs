using System;
using DesignPattern.Strategy;

namespace DesignPattern.Strategy
{
    public class StrategyDemo
    {
        public static void run()
        {
            Console.WriteLine("Strategy Pattern Demo\n");

            var context = new CompressionContext();

            Console.WriteLine("Using ZIP strategy:");
            context.SetStrategy(new ZipCompressionStrategy());
            context.CreateArchive("report.zip");

            Console.WriteLine();

            Console.WriteLine("Using RAR strategy:");
            context.SetStrategy(new RarCompressionStrategy());
            context.CreateArchive("report.rar");

            Console.WriteLine();

            Console.WriteLine("Using 7z strategy:");
            context.SetStrategy(new SevenZipCompressionStrategy());
            context.CreateArchive("report.7z");
        }
    }
}