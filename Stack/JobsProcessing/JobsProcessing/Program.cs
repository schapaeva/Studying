using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobsProcessing
{
    class Program
    {
        static void Main(string[] args)
        {
            Job job1 = new Job("job1", "low");
            Job job2 = new Job("job2", "low");
            Job job3 = new Job("job3", "high");
            Job job4 = new Job("job4", "high");
            Job job5 = new Job("job5", "low");
            Job job6 = new Job("job6", "low");
            Job job7 = new Job("job7", "high");
            Job job8 = new Job("job8", "low");
            Job job9 = new Job("job9", "low");
            Job job10 = new Job("job10", "high");
            Job job11 = new Job("job11", "high");
            Job job12 = new Job("job12", "low");
            Job job13 = new Job("job13", "low");

            JobManager jobManager = new JobManager();

            jobManager.jobQueue.Enqueue(job1);
            jobManager.jobQueue.Enqueue(job2);
            jobManager.jobQueue.Enqueue(job3);
            jobManager.jobQueue.Enqueue(job4);
            jobManager.jobQueue.Enqueue(job5);
            jobManager.jobQueue.Enqueue(job6);
            jobManager.jobQueue.Enqueue(job7);
            jobManager.jobQueue.Enqueue(job8);
            jobManager.jobQueue.Enqueue(job9);
            jobManager.jobQueue.Enqueue(job10);
            jobManager.jobQueue.Enqueue(job11);
            jobManager.jobQueue.Enqueue(job12);
            jobManager.jobQueue.Enqueue(job13);

            jobManager.ProcessJobQueue(jobManager.jobQueue);
            Console.ReadKey();
        }
    }
}
