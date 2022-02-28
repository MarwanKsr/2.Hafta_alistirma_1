using System;
namespace alistirma
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1000000,b=0;
            int[] asal = new int[n];
            int a = 0;
            for (int i = 2; i <= n; i++)
            {
                if (i == 2 || i == 3 || i == 5 || i == 7 )
                {
                    asal[a] = i;
                    a++;
                }
                else if (i%2 != 0 && i%3 != 0 && i%5 != 0 && i%7 != 0)
                {
                    asal[a] = i;
                    a++;
                    b=i;
                }
                
            }
            
                 foreach (var sayi in asal)
                 {
                
                     Console.Write(sayi);
                     if (sayi == b)
                     break;
                     Console.Write(", ");
                }
        }
    }
}