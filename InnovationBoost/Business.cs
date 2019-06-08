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

        public Project[] Projects { get; set; }

        private List<Project> projects = new List<Project>();

        public  Project CreateProject()
        {
            var p = new Project();
            projects.Add(p);
            return p;
        }
    }
}
