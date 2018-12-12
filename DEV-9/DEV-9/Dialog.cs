using System;
using System.Collections.Generic;

namespace DEV_9
{
    public class Dialog
    {
        public string sender { get; private set; }
        public int numberOfUnreadMesseges { get; private set; }
        public List<string> messeges;

        public Dialog(string sender, int numberOfUnreadMesseges)
        {
            this.sender = sender;
            this.numberOfUnreadMesseges = numberOfUnreadMesseges;
        }

        public void PrintToConsole()
        {
            Console.WriteLine(sender + "\t");
            foreach (string messege in messeges)
            {
                Console.WriteLine(messege + "\n");
            }
        }
    }

}
