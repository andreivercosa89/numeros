using System;
namespace numeros
{
    public class Numeros
    {
        public int incrementar()
        {
            int a = 1;
            for (int i = 1; i < 10; i++ ){
                i+=i;
                return i;
            }
            return a;
        }
    }
}
