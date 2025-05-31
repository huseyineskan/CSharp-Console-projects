// ToDo List App

List<MenuList> menuList = new List<MenuList>
{
    new MenuList{ MenuId=1, MenuTitle="Add Task"},
    new MenuList{ MenuId=2, MenuTitle="List Tasks"},
    new MenuList{ MenuId=3, MenuTitle="Update Task"},
    new MenuList{ MenuId=4, MenuTitle="Delete Task"},
    new MenuList{ MenuId=5, MenuTitle="Toggle Task Status (Completed/Not Completed)"},
    new MenuList{ MenuId=0, MenuTitle="Exit"},

};

List<Task> allTasks = new List<Task>
{
    new Task{TaskId= 1, TaskTitle = "Build a new website for my customer.", TaskLastDay = "29-08-2025"},
    new Task{TaskId= 2, TaskTitle = "Edit images.", TaskLastDay = "29-07-2025"},
    new Task{TaskId= 3, TaskTitle = "Fix bugs.", TaskLastDay = "14-06-2025"}
};

// MY APP START

int inputSelectAMenu;
bool isInputNumber;

Console.WriteLine("\nWELCOME TO TODO LIST APP");

while (true)
{
    Console.WriteLine();
    foreach (var menuItem in menuList)
    {
        Console.WriteLine(menuItem.MenuId + "." + menuItem.MenuTitle);
    }
    Console.WriteLine();

    do
    {
        Console.Write("Select a menu: ");
        string menuInput = Console.ReadLine().Trim();
        isInputNumber = int.TryParse(menuInput, out inputSelectAMenu);

        if (isInputNumber)
        {
            if (inputSelectAMenu == 0)
            {
                Console.WriteLine("Thanks for using ToDo App...\n");
                return;
            }

            if (!menuList.Exists(x => x.MenuId == inputSelectAMenu))
            {
                Console.WriteLine("Please enter a valid menu number!\n");
                isInputNumber = false;
            }
        }
        else
            Console.WriteLine("Please enter a number value!\n");

    } while (!isInputNumber);

    // MENU OPERATIONS

    switch (inputSelectAMenu)
    {
        case 0:
            return;
        case 1:
            //Add Task
            Console.WriteLine("You're adding a task\n");
            string taskTitle;
            string taskLastDay;

            do
            {
                Console.Write("Task Title: ");
                taskTitle = Console.ReadLine().Trim();

            } while (string.IsNullOrEmpty(taskTitle));

            do
            {
                Console.Write("Task Last Day (25-05-2025): ");
                taskLastDay = Console.ReadLine().Trim();
            } while (string.IsNullOrEmpty(taskLastDay));

            int maxId = allTasks.Max(x => x.TaskId);
            allTasks.Add(new Task { TaskId = maxId + 1, TaskTitle = taskTitle, TaskLastDay = taskLastDay, TaskIsCompleted = false });

            Console.WriteLine($"'{taskTitle}' task added to the list.");
            break;
        case 2:
            //List Tasks
            ListAllTasks();
            Console.Write("\n<- Back");
            Console.ReadLine();
            break;
        case 3:
            //Update Task
            ListAllTasks();
            isInputNumber = false;
            int updateTaskId = 0;
            do
            {
                Console.Write("\nWhich task do you want to update?: ");
                isInputNumber = int.TryParse(Console.ReadLine(), out updateTaskId);

                if (isInputNumber)
                {
                    if (allTasks.Exists(x => x.TaskId == updateTaskId))
                    {

                        string newTaskTitle;
                        string newTaskLastDay;

                        do
                        {
                            Console.Write("New Task Title: ");
                            newTaskTitle = Console.ReadLine().Trim();

                        } while (string.IsNullOrEmpty(newTaskTitle));

                        do
                        {
                            Console.Write("New Task Last Day(21-02-2026): ");
                            newTaskLastDay = Console.ReadLine().Trim();

                        } while (string.IsNullOrEmpty(newTaskLastDay));

                        var updateTask = from t in allTasks where t.TaskId == updateTaskId select t;
                        updateTask.First().TaskTitle = newTaskTitle;
                        updateTask.First().TaskLastDay = newTaskLastDay;

                        Console.WriteLine("Task was updated.\n");
                        Console.ReadLine();
                    }
                    else
                        Console.WriteLine("Please enter a valid number!\n");
                }
                else
                {
                    Console.WriteLine("Please enter a number value!\n");
                }

            } while (!isInputNumber);
            break;
        case 4:
            //Delete Task
            ListAllTasks();
            isInputNumber = false;
            int deleteTaskId = 0;
            do
            {
                Console.Write("\nWhich task do you want to delete?: ");
                isInputNumber = int.TryParse(Console.ReadLine(), out deleteTaskId) && allTasks.Exists(x => x.TaskId == deleteTaskId);
                Console.WriteLine("Try again.\n");
            } while (!isInputNumber);

            allTasks.RemoveAt(deleteTaskId - 1);
            Console.WriteLine($"{deleteTaskId} was deleted.");
            Console.Write("<- Back");
            Console.ReadLine();
            break;
        case 5:
            //Toggle Task Status
            ListAllTasks();
            isInputNumber = false;
            int toggleTaskId = 0;
            bool isThisBool = false;
            do
            {
                Console.Write("\nWhich task do you want to update?: ");
                isInputNumber = int.TryParse(Console.ReadLine(), out toggleTaskId);

                if (isInputNumber)
                {
                    if (allTasks.Exists(x => x.TaskId == toggleTaskId))
                    {

                        bool updateTaskStatusId;

                        do
                        {
                            Console.Write($"Is this ({toggleTaskId}) completed? (true | false): ");
                            isThisBool = bool.TryParse(Console.ReadLine(), out updateTaskStatusId);

                        } while (!isThisBool);

                        var updateTaskStatus = from t in allTasks where t.TaskId == toggleTaskId select t;
                        updateTaskStatus.First().TaskIsCompleted = updateTaskStatusId;

                        Console.WriteLine("The task status has been changed.\n");
                        Console.ReadLine();
                        break;
                    }
                    else
                        Console.WriteLine("Please enter a valid number!\n");
                }
                else
                {
                    Console.WriteLine("Please enter a number value!\n");
                }

            } while (!isInputNumber);
            break;
        default:
            break;
    }
}



Console.WriteLine();
Console.Read();

// MY APP END
void ListAllTasks()
{
    Console.WriteLine("\nID\tLAST DAY\tSTATUS\tTASK");
    foreach (var task in allTasks)
    {
        System.Console.WriteLine($"{task.TaskId}\t{task.TaskLastDay}\t{(task.TaskIsCompleted ? "Yes" : "No")}\t{task.TaskTitle}");
    }
}
class MenuList
{
    public int MenuId { get; set; }
    public string MenuTitle { get; set; }
}

class Task
{
    public int TaskId { get; set; }
    public string TaskTitle { get; set; }
    public string TaskLastDay { get; set; }
    public bool TaskIsCompleted { get; set; }
}

