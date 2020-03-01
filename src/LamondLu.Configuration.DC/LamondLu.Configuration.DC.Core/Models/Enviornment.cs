using System;
using System.Collections.Generic;
using System.Text;

namespace LamondLu.Configuration.DC.Core
{
    public class Enviornment
    {
        public Guid EnviornmentId { get; private set; }

        public App App { get; private set; }

        public string Name { get; set; }
    }
}
