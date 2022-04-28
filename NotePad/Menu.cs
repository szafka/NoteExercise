using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotePad
{
    public class Menu
    {
        private static TaskCollection taskCollection;
        public static void Run()
        {
            taskCollection = new TaskCollection();
            bool isRunning = true;
            while (isRunning)
            {

                Console.WriteLine("Choose number:");
                Console.WriteLine("1 : Active tasks");
                Console.WriteLine("2 : Tasks menu");
                Console.WriteLine("0 : Exit");
                Console.WriteLine("\n");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        taskCollection.GetActiveCollectionDet();
                        Console.WriteLine(taskCollection.GetActiveCollectionDet());
                        break;
                    case 2:
                        chooseTaskMenu();
                        break;
                    case 0:
                        isRunning = false;
                        Console.Clear();
                        break;
                }
            }
        }
        public static int TaskMenu()
        {
            Console.WriteLine("1: Add new task.");
            Console.WriteLine("2: Show tasks");
            int option = Convert.ToInt32(Console.ReadLine());
            return option;
        }
        public static void chooseTaskMenu()
        {
            Console.Clear();
            switch (TaskMenu())
            {
                case 1:
                    Console.WriteLine("Task title:");
                    String name = Console.ReadLine();
                    taskCollection.AddTask(CreateNewTask(name));
                    //Add new task to list
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine(taskCollection.GetCollectionDetails());
                    //writeLine task list
                    ChoiseActionMenu();
                    break;
            }
        }
        public static void ChoiseActionMenu()
        {
            Console.WriteLine("\n1: Change to active");
            Console.WriteLine("2: Remove task");
            Console.WriteLine("0: Exit\n");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    int number; String setAct;
                    Console.WriteLine("Task number to change active status:");
                    number = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Change active status?: Y/N");
                    setAct = Console.ReadLine().ToUpper();
                    ChangeTaskToActive(number, setAct);
                    break;
                case 2:
                    Console.WriteLine("Task number to remove:");
                    int remNum = Convert.ToInt32(Console.ReadLine());
                    taskCollection.RemoveFunction(remNum);
                    break;
                case 0:
                    break;
            }
        }
        
        private static void ChangeTaskToActive(int number, String setAct)
        {
            taskCollection.ChangeTaskActiveFlag(number, setAct.Equals("Y"));
        }
        public static Task CreateNewTask(String name)
        {
            return new Task(name, false);
        }
    }
}
