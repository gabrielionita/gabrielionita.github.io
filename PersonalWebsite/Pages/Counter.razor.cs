using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;

namespace PersonalWebsite.Pages
{
    public partial class Counter
    {
        private int currentCount = 0;

        [Inject]
        public ILogger<Counter> Logger { get; set; }

        private void IncrementCount()
        {
            Logger.LogDebug("Increment");
            currentCount++;
        }
    }
}
