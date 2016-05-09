using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobsProcessing
{
    class Job
    {
        public string name;
        public string priority;

        public Job() { }

        public Job (string name, string priority)
        {
            this.name = name;
            this.priority = priority;
        }
    }
}
