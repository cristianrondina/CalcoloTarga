using System;

namespace CalcoloTarga
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string targa, parte1Targa, parte2Targa, parte3Targa, finale;
            double numeri = 0, var = 0, posizioneFinale = 0, posizioneFinaleL = 0, targaFinale = 0;
            int posizione = 0;

            char[] alfabeto = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            Console.WriteLine("Inserisci una targa:");
            targa = Console.ReadLine();
            parte1Targa = targa.Substring(2, 3);
            parte2Targa = targa.Substring(0, 2);
            parte3Targa = targa.Substring(5);
            finale = parte2Targa + parte3Targa;

            for (int i = 0; i < finale.Length; i++)
            {
                posizione = Array.IndexOf(alfabeto, finale[i]);
                posizioneFinale = posizione * Math.Pow(26, i);
                var = posizioneFinale;
                posizioneFinaleL += var;
            }
            for (int i = 0; i < parte1Targa.Length; i++)
            {
                numeri += Convert.ToInt32(parte1Targa[i]) * Math.Pow(10, i);
            }
            targaFinale = numeri + posizioneFinaleL;
            Console.WriteLine($"Il risultato della targa finale è: {targaFinale}");
            Console.ReadLine();
        }
    }
}
