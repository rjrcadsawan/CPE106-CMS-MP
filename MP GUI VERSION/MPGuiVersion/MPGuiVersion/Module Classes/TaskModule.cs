using System;
using System.Collections.Generic;
using System.Text;

namespace MPGuiVersion
{
    static class TaskModule
    {
        static void addTask(string taskName, string duedate, float unitPrice, int EN, string desc, string MN)
        {
            Task C = new Task();
            C.TaskName = taskName;
            C.DueDate = duedate;
            C.Budget = unitPrice;
            C.EmployeesNeeded = EN;
            C.Description = desc;
            C.MaterialsNeeded = MN;
        }

        static void removeDuplicates()
        {
           
        }

        static void searchTask()
        {   
            //Need Sql Database Here
            Task taskName = new Task();
            if (taskName != null)
                Console.Write(taskName);
            else
                Console.Write("Task not found");
            //Hindi suree 
        }

        static void modifyItem()
        {

        }

        static void searchEmployee()
        {
            //Need SQL database
            var EmployeeName = new List<string> { "firstname", "middleName", "lastName" };
            if (EmployeeName != null)
                Console.Write(EmployeeName);
            else
                Console.Write("Employee not Found");
            //Di suree
        }

        static void deallocateEmployee()
        {

        }

        static void assignEmployeeToTask()
        {

        }

        static void taskHistory()
        {

        }

        static void summaryOfTask()
        {
            var sumtask = new List<string>();
            sumtask.Add("");
            Console.WriteLine(string.Join(", ", sumtask));
            //Hindi suree 
        }
    }
}
