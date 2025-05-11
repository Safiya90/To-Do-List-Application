namespace To_Do_List_Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] tasks = new string[10];
            bool[] isCompleted = new bool[10];
            int count = 0;
            while (true)
            {
                Console.WriteLine("Menu:\n1-Add Task\r\n2-Delete Task\r\n3-Mark Task as Completed\r\n4-View Tasks\r\n5-Clear Completed Tasks\r\n6-Exit");
                string choose = Console.ReadLine();
                switch (choose)
                {
                    case "1":
                        Console.Write("Enter a task: ");
                        tasks[count] = Console.ReadLine();
                        isCompleted[count] = false;
                        count++;
                        break;

                        case "2":
                        Console.Write("Enter a task number to delete: ");
                        int deleteTask = int.Parse(Console.ReadLine()) - 1;
                        if (deleteTask >= 0 && deleteTask < count)
                        {
                            for (int i = deleteTask; i < count - 1; i++)
                            {
                                tasks[i] = tasks[i + 1];
                                isCompleted[i] = isCompleted[i + 1];
                            }
                            count--;
                        }
                        break;

                    case "3":
                        Console.Write("Enter task number to mark as completed: ");
                        int complete = int.Parse(Console.ReadLine()) - 1;
                        if (complete >= 0 && complete < count)
                        {
                            isCompleted[complete] = true;
                            Console.WriteLine("Task marked as completed.");
                        }
                        break;

                    case "4":
                        if (count == 0)
                        {
                            Console.WriteLine("No tasks found.");
                        }
                        else
                        {
                            for (int i = 0; i < count; i++)
                            {
                                string status = isCompleted[i] ? "Done" : "Pending";
                                Console.WriteLine($"{i + 1}. {tasks[i]} is [{status}]");
                            }
                        }
                        break;

                    case "5":
                        int newCount = 0;
                        for (int i = 0; i < count; i++)
                        {
                            if (!isCompleted[i])
                            {
                                tasks[newCount] = tasks[i];
                                isCompleted[newCount] = false;
                                newCount++;
                            }
                        }
                        count = newCount;
                        Console.WriteLine("Completed tasks have been cleared :)");
                        break;

                    case "6":
                        Console.WriteLine("Thank you!");
                        return;

                }
            }   
            }
    }
}
