using System;

namespace numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            string text= "";
            for (int i = 1; i <= 10; i++)
            {

                for (int a = 1; a <= 10; a++)
                {
                    text += a + " ";
                }
                Console.WriteLine(i + ", " + "(" + text + ")");
                text = "";
            }


        }
    }
}
