using System;

namespace numeriNegativi
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.MaxValue;
            Console.WriteLine(a);// Con questo comando viene visualizzato come output la variabile a, che ha un valore costante (il valore massimo possibile di un intero)
            if(a==int.MaxValue)
            {
                Console.WriteLine(a + 1);// In output viene visualizzato la variabile a + 1
            }
            int b = -128;// alla variabile b è stato assegnato il valore -128
            int c = -b;
            Console.WriteLine(Convert.ToString(b, 2));
            Console.WriteLine(Convert.ToString(c, 2)); // il valore di b cambia segno e scritto in output a base binaria
            Console.WriteLine("Inserisci un numero intero");
            int value = Convert.ToInt32(Console.ReadLine());
            int somma = value;
            value = ~value + 1; // NOT
            // value = value + 1;
            somma = somma + value;
            Console.WriteLine("In output viene visualizzato il valore della variabile value che cambia segno e la somma della variabile value e della variabile value cambiata di segno");
            Console.WriteLine($"{value} e {somma}");
            long number = 55555;
            Console.WriteLine(Convert.ToString(number, 2));
            short number1 = (short)number;
            Console.WriteLine(number1);
        }
    }
}
