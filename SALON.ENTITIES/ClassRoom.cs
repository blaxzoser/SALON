using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SALON.ENTITIES
{
    public class ClassRoom
    {
        public string Code { get; set; }
        public int IdClassRoom { get; set; }
        public string Description { get; set; }
        public string Time { get; set; }
        public bool Su { get; set; }
        public bool Mo { get; set; }
        public bool Tu { get; set; }
        public bool We { get; set; }
        public bool Th { get; set; }
        public bool Fr { get; set; }
        public bool Sa { get; set; }

    }
}
