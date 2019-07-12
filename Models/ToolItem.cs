using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayRecord.core.Models
{
    public class ToolItem
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }
    }
}
