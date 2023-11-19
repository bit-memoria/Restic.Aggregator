using Restic.Aggregator.Models.Restic.Client;
using System.Diagnostics;
using System.Text;
using System.Text.Json;

namespace Restic.Aggregator.Services
{
    public static class ResticRepositoryService
    {
        public static async Task<List<RepositorySnapshot>?> GetRepositoryData()
        {
            Process process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "restic",
                    RedirectStandardOutput = true,
                    Arguments = "snapshots --json"
                }
            };

            process.Start();

            var _jsonOutput = await process.StandardOutput.ReadToEndAsync();

            if (_jsonOutput == null) return null;

            var _ms = new MemoryStream(Encoding.UTF8.GetBytes(_jsonOutput));
            var _repositorySnapshots = await JsonSerializer.DeserializeAsync<List<RepositorySnapshot>>(_ms);


            return _repositorySnapshots;
        }

        public static async Task<RepositorySnapshot?> GetSnapshot(string snapshotId)
        {
            
            Process process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "restic",
                    Arguments = $"snapshots {snapshotId} --json",
                    RedirectStandardOutput = true
                }
            };

            process.Start();

            var _jsonOutput = await process.StandardOutput.ReadToEndAsync();

            if (_jsonOutput == null) return null;

            var _ms = new MemoryStream(Encoding.UTF8.GetBytes(_jsonOutput));
            var _snapshots = await JsonSerializer.DeserializeAsync<List<RepositorySnapshot>>(_ms);

            return _snapshots?.FirstOrDefault();
        }
    }
}
