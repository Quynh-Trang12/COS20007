using System;
using _1._2____Object_Orientated_Programming;
namespace HelloWorld
{
    class HelloWorld()
    {
        class MainClass()
        {
            public static void Main(string[] args)
            {
                Message myMessage;
                myMessage = new Message("Hello World...");
                myMessage.Print();
                string name;

                Message message1 = new Message("Welcome back!");
                Message message2 = new Message("What a lovely name");
                Message message3 = new Message("Great name");
                Message message4 = new Message("Oh hi!");
                Message message5 = new Message("That is a silly name");

                Message[] messages = [message1, message2, message3, message4, message5];

                Console.WriteLine("Enter Name:");

                name = Console.ReadLine().ToLower();

                if (name == "mark")
                {
                    messages[0].Print();
                }
                else if (name == "wilma")
                {
                    messages[1].Print();
                }
                else if (name == "fred")
                {
                    messages[2].Print();
                }
                else if (name == "alice")
                {
                    messages[3].Print();
                }
                else
                {
                    messages[4].Print();
                }










            }

           
        }
    }

}

