using System;

namespace DesignPattern.Strategy;

public class CompressionContext
{
    private ICompressionStrategy _compressionStrategy;

    public CompressionContext(ICompressionStrategy compressionStrategy)
    {
        _compressionStrategy = compressionStrategy;
    }

    public void SetStrategy(ICompressionStrategy compressionStrategy)
    {
        _compressionStrategy = compressionStrategy;
    }
    
    public void CreateArchive(string filename)
    {
        if (_compressionStrategy == null) throw new ArgumentNullException(nameof(_compressionStrategy));
        if (filename == null) throw new ArgumentNullException(nameof(filename));
        _compressionStrategy.Compress(filename);
    }

    public CompressionContext()
    {
    }
}