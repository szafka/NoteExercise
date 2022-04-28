using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotePad
{
    public class TaskCollection
    {
        public List<Task> Tasks = new List<Task>();

        public void AddTask(Task task)
        {
            Tasks.Add(task);
        }
        public String GetCollectionDetails(List<Task> taskList)
        {
            Console.Clear();
            String collectionDetails = "Task Collection:";
            int i = 1;
            foreach (Task task in taskList)
            {
                collectionDetails += "\n";
                collectionDetails += i++ + ":" + task.ToString();
            }
            Console.WriteLine("\n");
            return collectionDetails;
        }

        public String GetCollectionDetails() 
        {
            return GetCollectionDetails(Tasks);
        }

        public String GetActiveCollectionDet(List<Task> taskList)
        {
            Console.Clear();
            String activeDetails = "Active Task Collection:\n";
            int i = 1;
            foreach (Task task in taskList)
            {
                if (task.isActive())
                {
                    activeDetails += "\n";
                    activeDetails += i++ + ":" + task.ToString();
                }
            }
            Console.WriteLine("\n");
            return activeDetails;
        }
        public String GetActiveCollectionDet()
        {
            return GetActiveCollectionDet(Tasks);
        }

        public void ChangeTaskActiveFlag(int number, Boolean activeFlag)
        {
            Task toActive = Tasks[number - 1];
            toActive.ChangeActiveFlag(activeFlag);
        }

        public void RemoveFunction(int remNum)
        {
            GetCollectionDetails();
            Tasks.Remove(Tasks[remNum - 1]);
        }
    }
}
