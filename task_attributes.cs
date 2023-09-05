using System;
using System.Collections.Generic;

namespace TaskAttributes
{
    class Task
    {
        private int id;
        private string description = "";
        private string prioritylevel = "";
        private int deadline;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public string PriorityLevel
        {
            get { return prioritylevel; }
            set { prioritylevel = value; }
        }
        public int DeadLine
        {
            get { return deadline; }
            set { deadline = value; }
        }

        // List to store tasks
        List<string> TheList = new List<string>
        {
            "buy some chloroform",
            "prepare a piece of cloth",
            "steal a van",
            "look for my ski mask"
        };

        public string AddTask()
        {
            Console.WriteLine("Describe the task: ");
            Description = Console.ReadLine();

            TheList.Add(Description);

            return "Task added successfully.";
        }

        public string ViewTask()
        {
            foreach(string taskk in TheList) {
                Console.WriteLine(taskk);
            }
            return "-------------";
        }

        public string RemoveTask()
        {
            Console.WriteLine("Which task would you like to remove? Pick a Number");
            for (int i = 0; i < TheList.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {TheList[i]}");
            }

            int userchoice = Convert.ToInt32(Console.ReadLine());
            int indexRemove = userchoice - 1;

            if(indexRemove < TheList.Count){
                Console.WriteLine("Invalid Choice, You Imbecile Pleb");
            }
            else if(indexRemove > TheList.Count){
                Console.WriteLine("Invalid Choice, You Imbecile Pleb");
                }
            else{
                TheList.Remove(TheList[indexRemove]);   
            }
            return "------------------";
             
        }

        public string ExitProgram (){
            Console.WriteLine("Giving Up?....");
            return "Bye";
        }  
    }
}
