using System;

namespace VerificaBrancaleoni
{
    public class VerificaBrancaleoni
    {
        // esercizio 1 a
        public static void Max()
        {
            Console.WriteLine("inserisci a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("inserisci b");
            int b = int.Parse(Console.ReadLine());
            int Max = Math.Max(a, b);
            Console.ReadLine();
        }
        // esercizio 1 b
        public static void Min()
        {
            Console.WriteLine("inserisci a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("inserisci b");
            int b = int.Parse(Console.ReadLine());
            int Min = Math.Min(a, b);
            Console.ReadLine();
        }
        // esercizio 2 a
        public static void Media()
        {
            Console.WriteLine("inserisci a");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("inserisci b");
            double b = double.Parse(Console.ReadLine());
            double Media = (a + b) / 2;
            Console.WriteLine(Media);
        }
        // esercizio 2 b
        public static void Somma()
        {
            Console.WriteLine("inserisci a");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("inserisci b");
            double b = double.Parse(Console.ReadLine());
            double Somma = a + b;
            Console.ReadLine();
        }
        // esercizio 3 a
        public static void Scambia(ref uint a, ref uint b)
        {
            var c = a;
            a = b;
            b = c;
        }
        // esercizio 3 b
        public static void Scambia(ref short a, ref short b)
        {
            var c = a;
            a = b;
            b = c;
        }
        // esercizio 4 a
        public static int ContaNumeri()
        {
            int c = 0;
            int n;
            do
            {
                n = int.Parse(Console.ReadLine());
                if (n != 0)
                    c++;
            } while (n != 0);
            return c;
        }
        // esercizio 4 b
        public static int ContaSomma()
        {
            int c = 0;
            int n;
            do
            {
                n = int.Parse(Console.ReadLine());
                if (n != 0)
                    c++;
            } while (n != 0);
            return c++;
        }
        // esercizio 5 a
        public static int Somma0(int n)
        {
            if (n == 0)
                return 0;
            return Somma0(n - 1) + n;
        }
        // esercizio 5 b
        public static int Somma1(int n)
        {
            if (n == 1)
                return 1;
            return Somma1(n - 1) + n;
        }
        // esercizio 6 
        public static double Operazioni(double a, char operatore, double b)
        {
            double risultato;
            switch (operatore)
            {
                case '+': risultato = a + b; break;
                case '-': risultato = a - b; break;
                case '*': risultato = a * b; break;
                case '/': risultato = a / b; break;
                default:
                    throw new Exception("operazione non valida");
            }
            return risultato;
        }
        // esercizio 7 
        public static void Calcolatrice()
        {
            char operatore;
            do
            {
                Console.WriteLine("inserisci a");
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine("inserisci b");
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine("inserisci operatore(+,-,*,/,q):");
                operatore = Console.ReadLine()[0];
                if (operatore != 'q')
                {
                    double risultato = Operazioni(a, operatore, b);
                    Console.WriteLine($"{risultato}");
                }
            } while (operatore != 'q');
        }
        // esercizio 8 a
        public static double Sconto(double Prezzo, int Quantita, double Iva)
        {
            double Totale = Prezzo * Quantita;
            double Sconto = 0;
            if (Totale > 100)
                Sconto = 0.15;
            else if (Quantita >= 30)
                Sconto = 0.10;
            Totale -= Totale * Sconto;
            Totale += Totale * Iva;
            return Totale;
        }
        // esercizio 8 b
        public static double Sconto1(double Prezzo, int Quantita, double Iva)
        {
            double Totale = Prezzo * Quantita;
            double Sconto = 0;
            if (Totale > 200)
                Sconto = 0.18;
            else if (Quantita >= 20)
                Sconto = 0.12;
            Totale -= Totale * Sconto;
            Totale += Totale * Iva;
            return Totale;
        }
        // esercizio 9
        public static void StampaFibonacci(int n)
        {
            for (int i = 0; i <= n; i++)
                Console.Write(Fibonacci(i) + "");
            Console.WriteLine();
        }
        public static int Fibonacci(int n)
        {
            if (n == 0 || n == 1)
                return 1;
            return Fibonacci(n - 2) + Fibonacci(n - 1);
        }
    }
}

            












     