using System;

namespace LibreriaArray
{
    public class ClasseArray
    {
            public static void LeggiArray(int[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write("Inserisci l'elemento in posizione: " + i);
                    int valore = int.Parse(Console.ReadLine());
                    array[i] = valore;
                }
            }
            public static void StampaArray(int[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i] + " ");
                }
            }
            public static int[] CopiaArray(int[] array)
            {
                int[] array_2 = new int[array.Length];
                for (int i = 0; i < array.Length; i++)
                {
                    array_2[i] = array[i];
                }
                return array_2;
            }
            public static bool RicercaArray(int[] array, int valore)
            {
                bool ricerca = false;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == valore)
                        ricerca = true;
                }
                return ricerca;
            }
            public static bool SonoUguali(int[] array_1, int[] array_2)
            {
                if (array_1.Length != array_2.Length)
                    return false;
                bool risposta = true;
                for (int i = 0; i < array_1.Length; i++)
                {
                    if (array_1[i] != array_2[i])
                        risposta = false;
                }
                return risposta;
            }
            public static void LeggiArrayDouble(double[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                Console.Write("Inserisci l'elemento in posizione: " + i);
                double valore = double.Parse(Console.ReadLine());
                array[i] = valore;
                }
            }
            public static void StampaArrayDouble(double[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine(array[i]);
                }
            }
            public static double[] CopiaArrayDouble(double[] array)
            {
                double[] array_2 = new double[array.Length];
                for (int i = 0; i < array.Length; i++)
                {
                    array_2[i] = array[i];
                }
                return array_2;
            }
            public static bool RicercaArrayDouble(double[] array, double valore)
            {
                bool ricerca = false;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == valore)
                        ricerca = true;
                }
                return ricerca;
            }
            public static bool SonoUgualiDouble(double[] array_1, double[] array_2)
            {
                if (array_1.Length != array_2.Length)
                    return false;
                bool risposta = true;
                for (int i = 0; i < array_1.Length; i++)
                {
                    if (array_1[i] != array_2[i])
                        risposta = false;
                }
                return risposta;
            }

            public static void LeggiArrayString(string[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine("Inserisci l'elemento in posizione: " + i);
                    array[i] = Console.ReadLine();
                }
            }
            public static void StampaArrayString(string[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine(array[i]);
                }
            }
            public static string[] CopiaArrayString(string[] array)
            {
                string[] array_2 = new string[array.Length];
                for (int i = 0; i < array.Length; i++)
                {
                    array_2[i] = array[i];
                }
                return array_2;
            }
            public static bool RicercaArrayString(string[] array, string valore)
            {
                bool ricerca = false;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == valore)
                        ricerca = true;
                }
                return ricerca;
            }
            public static bool SonoUgualiString(string[] array_1, string[] array_2)
            {
                if (array_1.Length != array_2.Length)
                    return false;
                bool risposta = true;
                for (int i = 0; i < array_1.Length; i++)
                {
                    if (array_1[i] != array_2[i])
                        risposta = false;
                }
                return risposta;
            }
            public static int CercaMax(int[] array)
            {
                int max = int.MinValue;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] > max)
                        max = array[i];
                }
                return max;
            }
            public static int CercaMin(int[] array)
            {
                int min = int.MaxValue;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] < min)
                        min = array[i];
                }
                return min;
            }
            public static bool Crescente(int[] array)
            {
                bool risposta = true;
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] <= array[i - 1])
                        risposta = false;
                }
                return risposta;
            }
            public static bool Decrescente(int[] array)
            {
                bool risposta = true;
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] >= array[i - 1])
                        risposta = false;
                }
                return risposta;
            }
        }
}

