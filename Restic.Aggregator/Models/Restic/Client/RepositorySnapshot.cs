﻿namespace Restic.Aggregator.Models.Restic.Client
{
    public class RepositorySnapshot
    {
        public DateTime time { get; set; }
        public string? tree { get; set; }
        public List<string>? paths { get; set; }
        public string? hostname { get; set; }
        public string? username { get; set; }
        public string? id { get; set; }
        public string? short_id { get; set; }
    }
}
