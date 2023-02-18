using System;

namespace ConsoleApp_ProcuraCaractere
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Leandro de Azevedo";

            int count = 0;
            foreach (var item in str)
            {
                if (item == 'a' || item == 'A')
                {
                    count++;
                }
            }

            Console.WriteLine(" Foram encontrados " + count +  " caracteres ");

            Console.ReadKey();
        }
    }
}
