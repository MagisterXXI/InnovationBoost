using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnovationBoost
{
    public class Business
    {
        public string Name { get; set; }

        public float Rate { get; set; }

        public Problem[] Projects { get; set; }

        private List<Problem> projects = new List<Problem>();

        public  Problem CreateProject()
        {
            var p = new Problem();
            projects.Add(p);
            return p;
        }
    }
}
