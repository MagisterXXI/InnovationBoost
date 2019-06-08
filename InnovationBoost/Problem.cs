using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnovationBoost
{
    public class Problem
    {
        public Problem()
        {
            Name = "<без названия>";
        }
        public string Name { get; set; }

        public string Description { get; set; }

        public string Targets { get; set; }
    }
}
