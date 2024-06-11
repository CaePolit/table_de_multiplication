using System;

class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.Write("Sur quel entrier voudrais-vous afficher les tables de multiplication? ");
            string entry = Console.ReadLine();
            int entier = default;
            bool sucess = false;
            while (!(sucess))
            {
                sucess = int.TryParse(entry, out entier);
                if (!(sucess))
                {
                    Console.Write("ERROR: nombre invalide. Veillez mettre un entier: ");
                    entry = Console.ReadLine();
                }
            }
            int n = Math.Abs(entier);
            string[] tables = new string[10];
            int[] resultats = new int[10];
            for (int i = 0; i < 10; i++) 
            {
                int termino = i + 1;
                int resultat = termino * n;
                resultats[i] = resultat;
                string resultado = resultat.ToString();
                string ter = termino.ToString();
                string entero = n.ToString();
                tables[i] = entero + " X " + termino + " = " + resultado;
            }
            foreach (string table in tables)
            {
                Console.WriteLine(table);
            }


        }
    }
}