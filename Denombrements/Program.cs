using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denombrements
{
    class Program
    {
        static long Calcul(long num, int fois)
        {
            for (int k = 1; k <= fois; k++)
                num *= fois;
            return num;
        }
        static void Main(string[] args)
        {
            int c = 1;
            while (c != 0)
            {
                Console.WriteLine("Permutation ...................... 1");
                Console.WriteLine("Arrangement ...................... 2");
                Console.WriteLine("Combinaison ...................... 3");
                Console.WriteLine("Quitter .......................... 0");
                Console.Write("Choix :                            ");
                c = int.Parse(Console.ReadLine());

                if (c == 0) { Environment.Exit(0); }

                if (c == 1)
                {
                    Console.Write("nombre total d'éléments à gérer = "); // le nombre d'éléments à gérer
                    int n = int.Parse(Console.ReadLine()); // saisir le nombre
                                                           // calcul de r
                    long r = 1;
                    Console.WriteLine(n + "! = " + Calcul(r, n));
                }
                else
                {
                    if (c == 2)
                    {
                        Console.Write("nombre total d'éléments à gérer = "); // le nombre d'éléments à gérer
                        int t = int.Parse(Console.ReadLine()); // saisir le nombre
                        Console.Write("nombre d'éléments dans le sous ensemble = "); // le sous ensemble
                        int n = int.Parse(Console.ReadLine()); // saisir le nombre
                        // calcul de r
                        long r = 1;
                        int f = t - n + 1;
                        //Console.WriteLine("résultat = " + (r1 / r2));
                        Console.WriteLine("A(" + t + "/" + n + ") = " + Calcul(r, f));
                    }
                    else
                    {
                        Console.Write("nombre total d'éléments à gérer = "); // le nombre d'éléments à gérer
                        int t = int.Parse(Console.ReadLine()); // saisir le nombre
                        Console.Write("nombre d'éléments dans le sous ensemble = "); // le sous ensemble
                        int n = int.Parse(Console.ReadLine()); // saisir le nombre
                        // calcul de r1
                        long r1 = 1;
                        int f = t - n + 1;
                        // calcul de r3
                        //Console.WriteLine("résultat = " + (r1 / r2));
                        Console.WriteLine("C(" + t + "/" + n + ") = " + Calcul(r1, f) / Calcul(r1, n));
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
