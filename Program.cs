using System;

namespace caio
{
    class Program
    {
        static void Main(string[] args)
        {
            string initial = "<<.<<..>><>><.>.>.<<.>.<.>>>><>><>>";
            ///<<>><<><>>>><>><>>
             ///>>>>
            initial = initial.Replace(".", "");
            int cont = 0;
            string diamond = "<>";
            Console.WriteLine("quantidade de diamantes : " + cont + " \t | Estado atual : " + initial);
            while (initial.Contains(diamond))
            {
                
                int x = initial.IndexOf(diamond, 0);
                initial = initial.Remove(x, 2);
                cont++;

                Console.WriteLine("localizaçao do diamante : "+x +" \t | quantidade de diamantes : "+ cont +" \t | Estado atual : "+initial);
            }




           
            Console.ReadKey();
        }
    }
}
