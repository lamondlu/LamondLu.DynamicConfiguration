using System;
using System.Collections.Generic;
using System.Text;

namespace LamondLu.Configuration.DC.Core
{
    public class Field
    {
        public string ConfigKey { get; set; }

        public string OldValue { get; set; }

        public string NewValue { get; set; }

        public string Description { get; set; }
    }
}
