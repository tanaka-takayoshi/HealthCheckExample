using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace HealthCheckExample
{
    internal class ReadinessHealthCheck : IHealthCheck
    {
        private HealthStatusData data;

        public ReadinessHealthCheck(HealthStatusData data)
        {
            this.data = data;
        }

        public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (data.IsReady)
            {
                return Task.FromResult(HealthCheckResult.Healthy());
            }
            else
            {
                return Task.FromResult(HealthCheckResult.Unhealthy("Error"));
            }
        }
    }
}