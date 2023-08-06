using System;
using Escape;

namespace Escape
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your hero name: ");
            string userName = Console.ReadLine();
            var room = new Room(userName);
            room.UserName();
            room.TreeRoom();
            
        }
    }
}
