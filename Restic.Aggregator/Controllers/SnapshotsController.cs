using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restic.Aggregator.Models.Restic.Client;
using Restic.Aggregator.Services;

namespace Restic.Aggregator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SnapshotsController : ControllerBase
    {
        // GET: api/<RepositoryController>
        [HttpGet]
        public async Task<List<RepositorySnapshot>?> Get()
        {
            return await ResticRepositoryService.GetRepositoryData();
        }

        [HttpGet("{id}")]
        public async Task<RepositorySnapshot?> Get(string id)
        {
            return await ResticRepositoryService.GetSnapshot(id);
        }
    }
}
