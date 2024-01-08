namespace Budapest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. feladat:
            List<Kozterulet> kozteruletek = new List<Kozterulet>();
            string[] olvasottSorok = File.ReadAllLines("Source\\bp.csv");

            for (int i = 1; i < olvasottSorok.Length; i++)
            {
                string[] tagok = olvasottSorok[i].Split(';');
                Kozterulet ujKozterulet = new Kozterulet(int.Parse(tagok[0]), tagok[1], tagok[2], tagok[3]);
                kozteruletek.Add(ujKozterulet);
            }

            //2. feladat:
            Console.WriteLine("2. feladat");
            Console.WriteLine($"\tTételek száma: {kozteruletek.Count()}");


            //3. feladat:
            Console.WriteLine("3. feladat");
            int kTeruletekSzama = 0;
            foreach (var i in kozteruletek)
            {
                if (i.Ker == "XIII")
                {
                    kTeruletekSzama += 1;
                }
            }
            Console.WriteLine($"\tKözterületek száma a XIII. kerületben:{kTeruletekSzama}");

            //4. feladat:
            Console.WriteLine("4. feladat");
            Console.Write("Kérek egy irányítószámot! ");
            int kertIRSZ = Convert.ToInt32(Console.ReadLine());


            //5. feladat:
            Console.WriteLine("5. feladat");
            Console.Write("Kérem a közterület nevének kezdetét! ");
            string ktNeve = Convert.ToString(Console.ReadLine());

            foreach (var i in kozteruletek)
            {
                if (i.Nev.Contains(ktNeve))
                {
                    Console.WriteLine($"{i.Nev} - {i.Ker}. kerület");
                }
            }

        }
    }
}