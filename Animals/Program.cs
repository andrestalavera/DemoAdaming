using System;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Chat chat0 = new Chat(); // 0x00001
            chat0.Chasser("Souris");
            Console.WriteLine(chat0.GetHashCode());

            Chat chat1 = new Chat(); // 0x00002
            chat1.Chasser("Taupe");
            Console.WriteLine(chat1.GetHashCode());
            chat1.Chasser(3);
        }
    }
}
