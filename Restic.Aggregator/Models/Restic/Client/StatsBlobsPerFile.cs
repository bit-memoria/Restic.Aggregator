namespace Restic.Aggregator.Models.Restic.Client
{
    public class StatsBlobsPerFile
    {
        public long total_size { get; set; }
        public long total_file_count { get; set; }
        public long total_blob_count { get; set; }
        public int snapshots_count { get; set; }
    }
}
