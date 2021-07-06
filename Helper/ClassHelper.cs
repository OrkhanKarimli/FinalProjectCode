using System;

namespace Helper
{
    public class ClassHelper
    {
       
        public static int TryInt(string send)
        {
            again:
            Console.Write($"{send}");
            string gonderilen = Console.ReadLine();
            bool yoxlama = int.TryParse(gonderilen, out int a);

            if (!yoxlama)
            {
                goto again;
            }
            return a;
            
        }
        public static string ReadText(string send,int? minlength)
        {
            again:
            Console.Write(send);

            string input = Console.ReadLine();
            if (minlength.HasValue && input.Length<minlength)
            
                goto again;
            
            
            return input;

        }
    }
}
