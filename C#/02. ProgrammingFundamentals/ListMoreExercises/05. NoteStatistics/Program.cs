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
            var counter = 0;
            var sumNaturals = 0.0;
            var sumSharps = 0.0;
            var frequencies = new List<double>();
            {
                frequencies.Add(261.63);
                frequencies.Add(277.18);
                frequencies.Add(293.66);
                frequencies.Add(311.13);
                frequencies.Add(329.63);
                frequencies.Add(349.23);
                frequencies.Add(369.99);
                frequencies.Add(392.00);
                frequencies.Add(415.30);
                frequencies.Add(440.00);
                frequencies.Add(466.16);
                frequencies.Add(493.88);
            }
            var frequenciesSharps = new List<double>();
            {
                frequenciesSharps.Add(277.18);
                frequenciesSharps.Add(311.13);
                frequenciesSharps.Add(369.99);
                frequenciesSharps.Add(415.30);
                frequenciesSharps.Add(466.16);
            }

            var frequenciesNatural = new List<double>();
            {
                frequenciesNatural.Add(261.63);
                frequenciesNatural.Add(293.66);
                frequenciesNatural.Add(329.63);
                frequenciesNatural.Add(349.23);
                frequenciesNatural.Add(392.00);
                frequenciesNatural.Add(440.00);
                frequenciesNatural.Add(493.88);
            }

            var notes = new List<string>();
            {
                notes.Add("C");
                notes.Add("C#");
                notes.Add("D");
                notes.Add("D#");
                notes.Add("E");                
                notes.Add("F");
                notes.Add("F#");
                notes.Add("G");
                notes.Add("G#");
                notes.Add("A");
                notes.Add("A#");
                notes.Add("B");                
            }

            var naturals = new List<string>();
            {
                naturals.Add("C");
                naturals.Add("D");
                naturals.Add("E");
                naturals.Add("F");
                naturals.Add("G");
                naturals.Add("A");
                naturals.Add("B");
            }
            var sharps = new List<string>();
            {
                sharps.Add("C#");
                sharps.Add("D#");
                sharps.Add("F#");
                sharps.Add("G#");
                sharps.Add("A#");
            }

            var newListFriquencies = Console.ReadLine().
            Split(new[] { ' ' }).Select(double.Parse).ToList();

            Console.Write("Notes: ");

            for (int i = 0; i < newListFriquencies.Count; i++)
            {
                for (int j = 0; j < frequencies.Count; j++)
                {
                    if (newListFriquencies[i] == frequencies[j])
                    {
                        Console.Write(notes[j] + " ");
                    }
                }

            }

            Console.WriteLine();
            Console.Write("Naturals: ");
            for (int i = 0; i < newListFriquencies.Count; i++)
            {
                for (int j = 0; j < frequenciesNatural.Count; j++)
                {
                    if (newListFriquencies[i] == frequenciesNatural[j])
                    {
                        counter++;
                        if (counter > 1)
                        {
                            Console.Write(", ");
                        }

                        Console.Write(naturals[j]);
                        sumNaturals = sumNaturals + frequenciesNatural[j];
                    }
                }

            }
            counter = 0;
            Console.WriteLine();
            Console.Write("Sharps: ");
            for (int i = 0; i < newListFriquencies.Count; i++)
            {
                for (int j = 0; j < frequenciesSharps.Count; j++)
                {
                    if (newListFriquencies[i] == frequenciesSharps[j])
                    {
                        counter++;
                        if(counter > 1)
                        {
                            Console.Write(", ");
                        }
                        Console.Write(sharps[j]);
                        sumSharps = sumSharps + frequenciesSharps[j];
                    }
                }

            }
            Console.WriteLine();
            Console.WriteLine("Naturals sum: {0:f}", sumNaturals);
            Console.WriteLine("Sharps sum: {0:f}", sumSharps);
        }
    }
}
