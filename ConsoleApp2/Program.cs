namespace Nevekszurese
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("Koleszár Emil");
            list.Add("Kiss István József");
            list.Add("rácrz László");
            list.Add("Farkas1 Aladár");
            list.Add("Pető@Ilona.hu");
            list.Add("Pisti");
            list.Add("12Elemér");
            list.Add("SzekeresKata");
            while (true)
            {
                Console.Clear();
                Console.Write("0 - Kilépés");
                Console.Write("1 - Összes név listázása");
                Console.Write("2 - Csak betűket tartalmazó nevek listázása");
                Console.Write("3 - Nagybetűvel kezdődő nevek listázása");
                Console.Write("4 - Rövid nevek listázása");
                Console.Write("5 - Nagybetűvel kezdődő nevek ahol a többi kicsi" + "és nem tartalmaz számot és speciális jelet");
                string valasztas = Console.ReadLine();
                switch (valasztas)
                {
                    case "0": return; //Kilépés
                    case "1":
                        Console.Clear();
                        int sorszam = 0;
                        foreach (string nev in list)
                        {
                            Console.WriteLine($"{sorszam++}. {nev}");
                        }
                        break;
                    case "2":
                        Console.Clear();
                        sorszam = 0;
                        foreach (string nev in list)
                        {
                            bool jo = true;
                            foreach (char betu in nev)
                            {
                                if (!Char.IsLetter(betu) && betu != ' ')
                                    jo = false;
                            }
                            if (jo)
                                Console.WriteLine($"{sorszam++}: {nev}");
                        }

                        break;


                    case "3":
                        Console.Clear();
                        sorszam = 0;
                        foreach (string nevek in list)
                        {
                            if (char.IsUpper(nevek[0]))
                                Console.WriteLine($"{sorszam++}. {nevek}");
                        }

                        break;
                    case "4":
                        Console.Clear();
                        sorszam = 0;
                        foreach (string nevek in list)
                        {
                            if (nevek.Length < 9)
                                Console.WriteLine($"{sorszam++}. {nevek}");
                        }
                        break;
                    case "5":
                        Console.Clear();
                        sorszam = 0;
                        foreach (string nev in list)
                        {
                            bool jo = true;
                            foreach (char betu in nev)
                            {
                                if (!Char.IsLetter(betu) && betu != ' ')
                                    jo = false;
                            }
                            String[] nevdarabok = nev.Split(' ');
                            foreach (var nevdarab in nevdarabok)
                            {
                                if (!Char.IsUpper(nevdarab[0]))
                                    jo = false;
                                if (nevdarab.Substring(1) != nevdarab.Substring(1).ToLower())
                                    jo = false;
                            }

                            if (jo)
                                Console.WriteLine($"{sorszam++}: {nev}");
                        }

                        break;
                    default: Console.WriteLine("Érvénytelen parancs!"); break;
                }
                Console.ReadKey();

            }
        }
    }
}

