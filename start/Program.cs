using System;
using System.Threading.Tasks;
using System.Text.Json;
using Azure;
using Azure.Storage.Queues;
using Azure.Storage.Queues.Models;

namespace StorageQueueApp
{


    class Program
    {
        static async Task Main(string[] args)
        {
            // Add code to create QueueClient and Storage Queue Here

            bool exitProgram = false;
            while (exitProgram == false)
            {
                Console.WriteLine("What operation would you like to perform?");
                Console.WriteLine("  1 - Send message");
                Console.WriteLine("  2 - Peek at the next message");
                Console.WriteLine("  3 - Receive message");
                Console.WriteLine("  X - Exit program");

                ConsoleKeyInfo option = Console.ReadKey();
                Console.WriteLine();  // ReadKey does not got the the next line, so this does
                Console.WriteLine();  // Provide some whitespace between the menu and the action

                if (option.KeyChar == '1')
                    await SendMessageAsync(queueClient);
                else if (option.KeyChar == '2')
                    await PeekMessageAsync(queueClient);
                else if (option.KeyChar == '3')
                    await ReceiveMessageAsync(queueClient);
                else if (option.KeyChar == 'X')
                    exitProgram = true;
                else
                    Console.WriteLine("invalid choice");
            }
        }
     

        static async Task SendMessageAsync(QueueClient queueClient)
        {
            throw new NotImplementedException();
        }


        static async Task PeekMessageAsync(QueueClient queueClient)
        {
            throw new NotImplementedException();
        }


        static async Task ReceiveMessageAsync(QueueClient queueClient)
        {
            throw new NotImplementedException();
        }
    }


    class NewsArticle
    {
        public string Headline { get; set; }
        public string Location { get; set; }
    }


    enum QueueOperation
    {
        SendMessage,
        PeekMessage,
        ReceiveMessage
    }

}
