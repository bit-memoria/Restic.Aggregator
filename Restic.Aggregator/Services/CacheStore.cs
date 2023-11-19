using Restic.Aggregator.Models.Restic.Client;
using Restic.Aggregator.Models.Restic.Store;

namespace Restic.Aggregator.Services
{
    public class CacheStore
    {
        public List<Snapshot> Snapshots { get; set; } = new List<Snapshot>();



        // SET EXAMPLE DATA
        public CacheStore()
        {
            Snapshots.AddRange(_snapshots);
        }


        // EXAMPLE DATA
        private List<Snapshot> _snapshots = new List<Snapshot>
        {
            new Snapshot {
                Time = new DateTime(2023, 11, 19, 10, 5, 3),
                Tree = "93eea3c9d04f0112f3dca5f850b4c5c06fc41bce27070ab8385161d4af7424a5",
                Paths = new List<string> { "\"C:\\Users\\Kai\\Downloads\"" },
                Hostname = "Stargazer",
                Username = "Stargazer\\Kai",
                Id = "fb47a50f9eaa1a7f1869c8dd40c8d03958a7306ff1c8793a943118fb2822543a",
                ShortId = "fb47a50f",
                TotalContentSize = 13208345294,
                TotalSize = 12710876320,
                TotalUncompressedSize = 13124862711,
                CompressionRatio = 1.0325694610330376,
                CompressionProgress = 100,
                CompressionSpaceSaving = 3.1542150201162578,
                TotalBlobCount = 10008,
                TotalContentFileCount = 366
            }
        };


    }
}
