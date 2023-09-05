using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace TDL
{
    class Program
    {
        public static void Main(string[] args)
        {
            TaskAttributes.Task T = new TaskAttributes.Task();


            Console.WriteLine("Welcome to TDL Management. \n Here it is our mission to bring out the best in you.");
            int UserChoice = 0;
        do{
            Console.WriteLine("Woud you like to; \n 1. Add Task. \n 2. View Tasks \n 3. Remove Tasks \n 4. Exit TDL.");
            Console.WriteLine("Please Choose a corresponding number: ");
            UserChoice = Convert.ToInt32(Console.ReadLine());

        
            if(UserChoice == 1){
                T.AddTask();

            }
            else if(UserChoice == 2){
                T.ViewTask();

            }
            else if(UserChoice == 3){
                T.RemoveTask();
            }
            else if(UserChoice == 4){
                Console.WriteLine("Until next time...");
                return;
            }
            else{
                Console.WriteLine("Refrain from fucking around, it could tragically result in intense physical pain followed by ringing in the ears.");
                return;
            }
            } while( UserChoice != 4);


        }
    }
}