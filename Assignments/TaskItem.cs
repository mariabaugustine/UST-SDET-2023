using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class TaskItem
    {
        public int TasKId{  get; set; }

        public string? TaskDescription {  get; set; }

        public bool IsCompleted { get; set; }

        public static List<TaskItem>TaskItemList=new List<TaskItem>();

        public void AddTask(int taskId,string?TaskDescription,bool isCompleted)
        {
            TaskItemList.Add(new TaskItem {  TasKId = taskId, TaskDescription = TaskDescription, IsCompleted = isCompleted });  
        }
        public void RemoveTask(int taskId)
        {
            var item=TaskItemList.Find(x=>x.TasKId == taskId);
            if (item != null) 
            {
                TaskItemList.Remove(item);
            }
            else
            {
                Console.WriteLine("No record found");
            }
        }
        public void MarkTaskComplete(int TaskId)

        {
            var item=TaskItemList.Find(x=>x.TasKId==TaskId);
            if (item != null)
            {
                item.IsCompleted = true;
            }
            else
            {
                Console.WriteLine("No record Found");
            }
        }
        public void DisplayTask()
        {
            Console.WriteLine("Task Details:");
            foreach (var task in TaskItemList)
            {
                Console.WriteLine("Task Id:"+task.TasKId+"\n"+"Task Description:"+task.TaskDescription+"\n"+"Task Status"+task.IsCompleted);
            }
        }
        public void DisplayPending()
        {
            Console.WriteLine("Pending Task:");
            foreach(var task in TaskItemList)
            {
                if(task.IsCompleted!=true)
                {
                    Console.WriteLine("Task Id:" + task.TasKId + "\n" + "Task Description:" + task.TaskDescription + "\n" + "Is Completed:" + task.IsCompleted);
                }
               
            
            }
        }
        public void displayCompletedTask()
        {
            Console.WriteLine("Completed Task:");
            foreach(var task in TaskItemList)
            {
                if (task.IsCompleted==true)
                {
                    Console.WriteLine("Task Id:" + task.TasKId + "\n" + "Task Description:" + task.TaskDescription + "\n" + "Task Status" + task.IsCompleted);
                }
              
            }
        }
        
    }
}
