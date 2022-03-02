using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UpdateReloadPWA.Client
{
    public class AppState
    {
        public int Counter { get; set; } = 0;
        public int TimeToLiveInSeconds { get; set; } = 180;
        public DateTime LastAccessed { get; set; } = DateTime.Now;
    }
}