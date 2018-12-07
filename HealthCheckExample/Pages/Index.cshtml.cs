using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HealthCheckExample.Pages
{
    public class IndexModel : PageModel
    {
        private HealthStatusData data;

        public IndexModel(HealthStatusData data)
        {
            this.data = data;
        }

        public void OnGet()
        {

        }

        public void OnPostLiveness()
        {
            data.IsLiveness = false;
        }

        public void OnPostReadiness()
        {
            data.IsReady = false;
        }
    }
}
