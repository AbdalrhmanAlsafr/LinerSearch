using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {

        public static void rdiziolustur(int[] dizi, int n)
        {
            Random uretec = new Random();
            for (int i = 0; i < n; i++)
                dizi[i] = uretec.Next(1, 10);
          
        }
        public static int[] dizi = new int[10];
    
        public static bool SeqSearch(int[] arr,int x)
        {
            for (int i = 0; i <arr.Length ; i++)
            {
                if (arr[i] == x)
                { 
                    return true;
                }
            }
            return false;
        }
        public static void dizigoster(int[] dizi)
        {
            int uzn = dizi.Length;
            for (int i = 0; i < uzn; i++)
            {
                Console.Write(dizi[i].ToString() + "\t");
            }
        }

        static void Main(string[] args)
        {

            int[] A = new int[10];
            rdiziolustur(A, 10);

            bool sonuc = SeqSearch(A, 8);
            Console.WriteLine(sonuc.ToString());
         
            Console.ReadLine();
        }








    }
}
