using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobsProcessing
{
    class JobManager
    {
        public Queue jobQueue = new Queue();
        public Stack jobStack = new Stack();

        public void ProcessJobQueue(Queue workingQueue)
        {
            Job localJob = new Job();
            Job nextJob = new Job();
            while (workingQueue.Count != 0)
            {
                if (jobStack.Count != 0)
                {
                    if (workingQueue.Count > 0)
                        nextJob = (Job)workingQueue.Peek();
                    if (nextJob.priority == "high")
                    {
                        localJob = (Job)workingQueue.Dequeue();
                        Console.WriteLine("Processing High Priority Job {0} from the Queue, the stack left alone:", localJob.name);
                    }
                    if (nextJob.priority == "low")
                    {
                        localJob = (Job)jobStack.Pop();
                        Console.WriteLine("Processing Job {0} POP-ed from stack:", localJob.name);
                    }
                }
                if (jobStack.Count == 0)
                {
                    localJob = (Job)workingQueue.Dequeue();
                    if (workingQueue.Count > 0)
                        nextJob = (Job)workingQueue.Peek();
                    if (localJob.priority == "high")
                        Console.WriteLine("Processing High priority Job {0} directly from queue:", localJob.name);
                    if (localJob.priority == "low" && nextJob.priority == "low")
                        Console.WriteLine("Processing Low priority Job {0} directly from queue with a low priority job behind it:", localJob.name);
                    if (localJob.priority == "low" && nextJob.priority == "high")
                    {
                        jobStack.Push(localJob);
                        Console.WriteLine("Stack Length: {0} ", jobStack.Count.ToString());
                        Console.WriteLine("Job PUSH-ed on stack {0}", localJob.name);

                        localJob = (Job)workingQueue.Dequeue();
                        Console.WriteLine("Processing Job {0} , the previous job was pushed onto the stack. ", localJob.name); 
                    }
                } 
            }
            if (jobStack.Count != 0)
            {
                localJob = (Job)jobStack.Pop();
                Console.WriteLine("Processing Job : {0}", localJob.name);
            }
        }

    }
}
