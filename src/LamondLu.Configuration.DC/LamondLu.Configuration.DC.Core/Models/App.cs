using System;
using System.Collections.Generic;
using System.Text;

namespace LamondLu.Configuration.DC.Core
{
    public class App
    {
        public Guid AppId { get; set; }

        public string AppName { get; set; }

        public List<Guid> EnvironmentIds { get; set; }
    }
}
