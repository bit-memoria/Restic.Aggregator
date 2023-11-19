namespace Restic.Aggregator.Models.Restic.Store
{
    public class Snapshot
    {
        public DateTime Time { get; set; }
        public string Id { get; set; }
        public string ShortId { get; set; }
        public List<string> Paths { get; set; }
        public string Hostname { get; set; }
        public string Tree { get; set; }
        public string Username { get; set; }
        public long TotalContentSize { get; set; }
        public long TotalContentFileCount { get; set; }
        public long TotalBlobCount { get; set; }
        public long UniqueFileCount { get; set; }
        public long TotalUncompressedSize { get; set; }
        public long TotalSize { get; set; }
        public int CompressionProgress { get; set; }
        public double CompressionRatio { get; set; }
        public double CompressionSpaceSaving { get; set; }
    }
}
