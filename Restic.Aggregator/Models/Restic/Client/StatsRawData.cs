namespace Restic.Aggregator.Models.Restic.Client
{
    public class StatsRawData
    {
        public long total_size { get; set; }
        public long total_uncompressed_size { get; set; }
        public double compression_ratio { get; set; }
        public int compression_progress { get; set; }
        public double compression_space_saving { get; set; }
        public long total_blob_count { get; set; }
        public int snapshots_count { get; set; }
    }
}
