using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {

            var dictShadowmourne = new Dictionary<string, int>();
            var dictValanyr = new Dictionary<string, int>();
            var dictDragonwrath = new Dictionary<string, int>();
            var junkDict = new Dictionary<string, int>();
            string winner = null;
            var loop = 0;

            while (loop < 1)
            {
                var input = Console.ReadLine().ToLower().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToList();

                for (int i = 1; i < input.Count; i += 2)
                {
                    if (input[i] == "shards")
                    {
                        if (!dictShadowmourne.ContainsKey(input[i]))
                        {
                            dictShadowmourne[input[i]] = int.Parse(input[i - 1]);
                        }
                        else
                        {
                            dictShadowmourne[input[i]] += int.Parse(input[i - 1]);
                        }
                        if (dictShadowmourne.Sum(x => x.Value) >= 250)
                        {
                            loop = 2;
                            Console.WriteLine("Shadowmourne obtained!");
                            winner = "dictShadowmourne";

                            if (dictShadowmourne.Sum(x => x.Value) > 250)
                            {
                                if (!junkDict.ContainsKey("shards"))
                                {
                                    junkDict[input[i]] = dictShadowmourne.Sum(x => x.Value) - 250;
                                }
                                else
                                {
                                    junkDict[input[i]] += dictShadowmourne.Sum(x => x.Value);
                                }
                            }
                            break;
                        }
                    }

                    else if (input[i] == "fragments")
                    {
                        if (!dictValanyr.ContainsKey(input[i]))
                        {
                            dictValanyr[input[i]] = int.Parse(input[i - 1]);
                        }
                        else
                        {
                            dictValanyr[input[i]] += int.Parse(input[i - 1]);
                        }
                        if (dictValanyr.Sum(x => x.Value) >= 250)
                        {
                            loop = 2;

                            Console.WriteLine("Valanyr obtained!");
                            winner = "dictValanyr";

                            if (dictValanyr.Sum(ix => ix.Value) > 250)
                            {
                                if (!junkDict.ContainsKey("fragments"))
                                {
                                    junkDict[input[i]] = dictValanyr.Sum(ix => ix.Value) - 250;
                                }
                                else
                                {
                                    junkDict[input[i]] += dictValanyr.Sum(ix => ix.Value);
                                }
                            }
                            break;
                        }
                    }
                    else if (input[i] == "motes")
                    {
                        if (!dictDragonwrath.ContainsKey(input[i]))
                        {
                            dictDragonwrath[input[i]] = int.Parse(input[i - 1]);
                        }
                        else
                        {
                            dictDragonwrath[input[i]] += int.Parse(input[i - 1]);
                        }
                        if (dictDragonwrath.Sum(x => x.Value) >= 250)
                        {
                            loop = 2;
                            Console.WriteLine("Dragonwrath obtained!");

                            winner = "dictDragonwrath";

                            if (dictDragonwrath.Sum(x => x.Value) > 250)
                            {
                                if (!junkDict.ContainsKey("motes"))
                                {
                                    junkDict[input[i]] = dictDragonwrath.Sum(x => x.Value) - 250;
                                }
                                else
                                {
                                    junkDict[input[i]] += dictDragonwrath.Sum(x => x.Value);
                                }
                            }
                            break;
                        }
                    }
                    else
                    {
                        if (!junkDict.ContainsKey(input[i]))
                        {
                            junkDict[input[i]] = int.Parse(input[i - 1]);
                        }
                        else
                        {
                            junkDict[input[i]] += int.Parse(input[i - 1]);
                        }
                    }

                }
            }



            if (winner == "dictShadowmourne")
            {

                foreach (var kvp in dictValanyr)
                {
                    if(!junkDict.ContainsKey(kvp.Key))
                    {
                        junkDict[kvp.Key] = kvp.Value;
                    }
                    else
                    {
                        junkDict[kvp.Key] += kvp.Value;
                    }
                }
                foreach (var kvp in dictDragonwrath)
                {
                    if (!junkDict.ContainsKey(kvp.Key))
                    {
                        junkDict[kvp.Key] = kvp.Value;
                    }
                    else
                    {
                        junkDict[kvp.Key] += kvp.Value;
                    }
                }

            }
            else if (winner == "dictValanyr")
            {
                foreach (var kvp in dictShadowmourne)
                {
                    if (!junkDict.ContainsKey(kvp.Key))
                    {
                        junkDict[kvp.Key] = kvp.Value;
                    }
                    else
                    {
                        junkDict[kvp.Key] += kvp.Value;
                    }
                }
                foreach (var kvp in dictDragonwrath)
                {
                    if (!junkDict.ContainsKey(kvp.Key))
                    {
                        junkDict[kvp.Key] = kvp.Value;
                    }
                    else
                    {
                        junkDict[kvp.Key] += kvp.Value;
                    }
                }
            }
            else if (winner == "dictDragonwrath")
            {
                foreach (var kvp in dictValanyr)
                {
                    if (!junkDict.ContainsKey(kvp.Key))
                    {
                        junkDict[kvp.Key] = kvp.Value;
                    }
                    else
                    {
                        junkDict[kvp.Key] += kvp.Value;
                    }
                }
                foreach (var kvp in dictShadowmourne)
                {
                    if (!junkDict.ContainsKey(kvp.Key))
                    {
                        junkDict[kvp.Key] = kvp.Value;
                    }
                    else
                    {
                        junkDict[kvp.Key] += kvp.Value;
                    }
                }
            }


            //var bottom = junkDict.OrderBy(pair => pair.Key);

            //foreach (var kvp in bottom)
            //{
            //    Console.WriteLine(kvp.Key + " " + kvp.Value);
            //}
            //Console.WriteLine();

           // var rev = junkDict.Reverse();

            foreach (var kvp in junkDict)
            {
                Console.WriteLine(kvp.Key + ": " + kvp.Value);
            }
            //var dictShadowmourne = new Dictionary<string, int>();
            //var dictValanyr = new Dictionary<string, int>();
            //var dictDragonwrath = new Dictionary<string, int>();
            //var junkDict = new Dictionary<string, int>();
        }
    }
}



//var Shadowmourne = 0;
//var Valanyr = 0;
//var Dragonwrath = 0;
//var newDict = new Dictionary<string, int>();
//var dict = new Dictionary<string, int>();

//while (Shadowmourne < 250 && Valanyr < 250 && Dragonwrath < 250)
//{
//    var input = Console.ReadLine().ToLower().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToList();

//    newDict = new Dictionary<string, int>();

//    for (int i = 0; i < input.Count; i += 2)
//    {
//        newDict[input[i + 1]] = int.Parse(input[i]);

//    }
//    foreach (var item in newDict)
//    {
//        if (!dict.ContainsKey(item.Key))
//        {
//            dict[item.Key] = item.Value;
//        }
//        else
//        {
//            dict[item.Key] += item.Value;
//        }
//    }
//    foreach (var item in newDict)
//    {
//        if (item.Key == "shards")
//        {
//            Shadowmourne = Shadowmourne + item.Value;

//            if (Shadowmourne > 250)
//            {
//                newDict[item.Key] = Shadowmourne - 250;
//                Console.WriteLine("Shadowmourne obtained!");
//                break;
//            }
//            else if (Shadowmourne <= 250)
//            {
//                dict.Remove(item.Key);
//            }
//        }
//        else if (item.Key == "fragments")
//        {
//            Valanyr = Valanyr + item.Value;

//            if (Valanyr > 250)
//            {
//                dict[item.Key] = Valanyr - 250;
//                Valanyr = Valanyr - dict[item.Key];
//                Console.WriteLine("Valanyr obtained!");
//                break;
//            }
//            else if (Valanyr <= 250)
//            {
//                dict.Remove(item.Key);
//            }
//        }
//        else if (item.Key == "motes")
//        {
//            Dragonwrath = Dragonwrath + item.Value;

//            if (Dragonwrath > 250)
//            {
//                newDict[item.Key] = Dragonwrath - 250;
//                Console.WriteLine("Dragonwrath obtained!");
//                break;
//            }
//            else if (Dragonwrath <= 250)
//            {
//                dict.Remove(item.Key);
//            }
//        }
//        //else
//        //{
//        //    if(!dict.ContainsKey(item.Key))
//        //    {
//        //        dict[item.Key] = item.Value;

//        //    }
//        //    else
//        //    {
//        //        dict[item.Key] += item.Value;
//        //    }
//        //}
//    }
//}

//foreach (var kvp in dict)
//{
//    Console.WriteLine(kvp.Key + " " + kvp.Value);
//}