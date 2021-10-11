using System;

namespace TestRepo
{
    class Program
    {
        static public int userId {get; set;}

        static void Login()
        {
            // You can set the global variable userId in any method to any value. It is a normal variable
            // These are two different EXAMPLES
            userId = 1;

            Console.Write("Enter your user id: ");
            int tempId = Convert.ToInt32(Console.ReadLine());            
            userId = tempId;
        }

        static void answerQuestion()
        {
            // You can access the userId variable from any method just like normal

            // This will print it to the console
            Console.WriteLine($"{userId}");

            // This uses it in an if statement
            if (userId == 1)
            {
                Console.WriteLine("Your user id is 1");
            }
        }


        static void Main(string[] args)
        {
            Login();
            answerQuestion();
        }
    }
}
