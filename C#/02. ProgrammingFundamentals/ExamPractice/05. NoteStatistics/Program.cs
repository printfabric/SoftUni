using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.NoteStatistics
{
    class Program
    {
        static void Main(string[] args)
        {
            var frequencies = new Dictionary<double, string>();
            frequencies[261.63] = "C";
            frequencies[277.18] = "C#";
            frequencies[293.66] = "D";
            frequencies[311.13] = "D#";
            frequencies[329.63] = "E";
            frequencies[349.23] = "F";
            frequencies[369.99] = "F#";
            frequencies[392.00] = "G";
            frequencies[415.30] = "G#";
            frequencies[440.00] = "A";
            frequencies[466.16] = "A#";
            frequencies[493.88] = "B";

            var frequenciesNatural = new Dictionary<double, string>();
            frequenciesNatural[261.63] = "C";
            frequenciesNatural[293.66] = "D";
            frequenciesNatural[329.63] = "E";
            frequenciesNatural[349.23] = "F";
            frequenciesNatural[392.00] = "G";
            frequenciesNatural[440.00] = "A";
            frequenciesNatural[493.88] = "B";

            var frequenciesSharp = new Dictionary<double, string>();
            frequenciesSharp[277.18] = "C#";
            frequenciesSharp[311.13] = "D#";
            frequenciesSharp[369.99] = "F#";
            frequenciesSharp[415.30] = "G#";
            frequenciesSharp[466.16] = "A#";

            var listNatural = new List<string>();
            var listSharp = new List<string>();
            var naturalSum = 0.0;
            var sharpSum = 0.0;
             
            var frequenciesInput = Console.ReadLine().Split(new[] { ' ' }).Select(double.Parse).ToList();

            Console.Write("Notes: ");
            for (int i = 0; i < frequenciesInput.Count; i++)
            {
                Console.Write(frequencies[frequenciesInput[i]] + " ");
            }

            Console.WriteLine();
            Console.Write("Naturals: ");
            for (int i = 0; i < frequenciesInput.Count; i++)
            {
                if(frequenciesNatural.ContainsKey(frequenciesInput[i]))
                {
                    listNatural.Add(frequenciesNatural[frequenciesInput[i]]);
                    naturalSum += frequenciesInput[i];
                }
            }
            Console.WriteLine(string.Join(", ", listNatural));

            Console.Write("Sharps: ");
            for (int i = 0; i < frequenciesInput.Count; i++)
            {
                if (frequenciesSharp.ContainsKey(frequenciesInput[i]))
                {
                    listSharp.Add(frequenciesSharp[frequenciesInput[i]]);
                    sharpSum += frequenciesInput[i];

                }
            }
            Console.WriteLine(string.Join(", ", listSharp));

            Console.WriteLine($"Naturals sum: {naturalSum}");
            Console.WriteLine($"Sharps sum: {sharpSum}");
        }
    }
}
