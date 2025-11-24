using System;
using System.ComponentModel;

namespace MyApp
{
    internal class Program
    {
        
        static void Main(string[] args)
        {

            List<string> lista = new List<string>();
            lista.Add("Deak Csaba");
            lista.Add("Kiss István József");
            lista.Add("Nagy István Elemér");
            lista.Add("Farkas1 Aladár");
            lista.Add("Pető@Ilona.hu");
            lista.Add("Pisti");
            lista.Add("12Elemér");
            lista.Add("SzekeresKata");


            while (true) 
            {
                Console.Clear();
                Console.WriteLine("0 - Kilépés");
                Console.WriteLine("1 - Összes név listázása");
                Console.WriteLine("2 - Csak betűt tartalamzaó nevek listázása");
                Console.WriteLine("3 - Nagybetűvel kezdődő nevek listázása");
                Console.WriteLine("4 - Rövid nevek listázása");
                Console.WriteLine("5 - Nagybetűvel kezdődő nevek ahol a többi kicsi"+"és nem tartalmaz számot és speciális jelet");
                string valasztas = Console.ReadLine();
                switch (valasztas) 
                {
                    case "0":return;//kilepes
                    case "1":
                        Console.Clear();
                        int sorszam = 0;
                        foreach(string nev in lista) Console.WriteLine($"{sorszam++}. { nev}");
                        break;
                        


                    case "2":
                        Console.Clear();
                        sorszam = 0;
                        foreach (string nev in lista)
                        {
                            bool jo = true;
                            foreach (char betu in nev)
                            {
                                if (!Char.IsLetter(betu) && betu == ' ')
                                    jo = true;
                            }
                            if (jo)
                                Console.WriteLine($"{sorszam++}. {nev}");
                        }
                        
                        
                        
                        
                        
                        break;

                    case "3": break;
                    case "4": break;
                    case "5": break;
                    default: Console.WriteLine("Rossz parancs");break;
                }
                Console.ReadKey();
                
            }
        }
    }
}