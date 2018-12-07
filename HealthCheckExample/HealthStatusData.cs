using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace HealthCheckExample
{
    public class HealthStatusData
    {
        public bool IsReady { get; set; } = true;
        public bool IsLiveness { get; set; } = true;
    }
    
}