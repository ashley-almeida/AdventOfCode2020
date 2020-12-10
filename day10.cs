using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Collections;

public class day10
{

    public static void dostuffPart1()
    {
        string inputString = "97,62,23,32,51,19,98,26,90,134,73,151,116,76,6,94,113,127,119,44,115,50,143,150,86,91,36,104,131,101,38,66,46,96,54,70,8,30,1,108,69,139,24,29,77,124,107,14,137,16,140,80,68,25,31,59,45,126,148,67,13,125,53,57,41,47,35,145,120,12,37,5,110,138,130,2,63,83,22,79,52,7,95,58,149,123,89,109,15,144,114,9,78";

        string sampleString = "16,10,15,5,1,11,7,19,6,12,4"; //"28,33,18,42,31,14,46,20,48,47,24,23,49,45,19,38,39,11,1,32,25,35,8,17,7,9,4,2,34,10,3";

        var inputs = inputString.Split(',').ToList();

        int ThreeCount = 0, OneCount = 0, twoCount = 0;
        var tempList = inputs.Select(int.Parse).ToList();
        var device = tempList.Max() + 3;
        tempList.Add(device);
        tempList.Sort();
        var currentAdapter = 0;
        foreach (int adapter in tempList)
        {
            var diff = adapter - currentAdapter;
            currentAdapter = adapter;
            switch (diff)
            {
                case 1:
                    OneCount++;
                    break;
                case 2:
                    twoCount++;
                    break;
                case 3:
                    ThreeCount++;
                    break;
                default:
                    Console.WriteLine("too much differnece: " + diff);
                    break;
            }
        }

        Console.WriteLine("One: " + OneCount + " Two: " + twoCount + "Three: " + ThreeCount + " One*Three: " + (OneCount * ThreeCount));

    }
    public static void dostuffPart2()
    {

        var start = DateTime.Now.ToString();

        string inputString = "97,62,23,32,51,19,98,26,90,134,73,151,116,76,6,94,113,127,119,44,115,50,143,150,86,91,36,104,131,101,38,66,46,96,54,70,8,30,1,108,69,139,24,29,77,124,107,14,137,16,140,80,68,25,31,59,45,126,148,67,13,125,53,57,41,47,35,145,120,12,37,5,110,138,130,2,63,83,22,79,52,7,95,58,149,123,89,109,15,144,114,9,78";

        string sampleString = "16,10,15,5,1,11,7,19,6,12,4";
        //string sampleString = "28,33,18,42,31,14,46,20,48,47,24,23,49,45,19,38,39,11,1,32,25,35,8,17,7,9,4,2,34,10,3";

        var inputs = sampleString.Split(',').ToList();

        var tempList = inputs.Select(int.Parse).ToList();
        var device = tempList.Max() + 3;
        tempList.Add(device);
        tempList.Add(0);
        tempList.Sort();

        foreach (int x in tempList)
        {
            Console.Write(x + ",");
        }
        Console.WriteLine();
        //return;

        var Counter = 0;

        var currentAdapter = 0;

        // NewFork(currentAdapter);

        // int NewFork(int currentAdapter)
        // {            
        //     // if (currentAdapter == device)
        //     // {
        //     //     Counter++;
        //     //     //return 0;
        //     // }
        //     Console.WriteLine("Fork at " + currentAdapter + " Counter: " + Counter);
        //     var possible = new List<int>(tempList.FindAll(x => x > currentAdapter && GetNextElements(x, currentAdapter)));

        //     return possible.Count();

        //     // foreach (int adapter in possible)
        //     // {
        //     //     NewFork(adapter);
        //     // }
        // }

        long Paths = 0;

        string expression = "";

        var ForkDictionary = new Dictionary<int, int>();

        foreach (int adapter in tempList)
        {
            ForkDictionary.Add(adapter, FindForx(adapter));
            Console.WriteLine(adapter + "-" + FindForx(adapter));
        }

        for (int adapter = 0; adapter < tempList.Count(); adapter++)
        {
            switch (ForkDictionary.GetValueOrDefault(tempList[adapter]))
            {
                case 3:
                    Paths += ForkDictionary.GetValueOrDefault(tempList[adapter + 3]) +
                    ForkDictionary.GetValueOrDefault(tempList[adapter + 2]) +
                    ForkDictionary.GetValueOrDefault(tempList[adapter + 1]);
                    break;
                case 2:
                    Paths += ForkDictionary.GetValueOrDefault(tempList[adapter + 2]) +
                    ForkDictionary.GetValueOrDefault(tempList[adapter + 1]);
                    break;
                case 1:
                    Paths += ForkDictionary.GetValueOrDefault(tempList[adapter + 1]);
                    break;
                case 0:
                    return;
            }
        }

        Console.WriteLine(Paths);

        int FindForx(int currentAdapter)
        {
            return new List<int>(tempList.FindAll(x => x > currentAdapter && GetNextElements(x, currentAdapter))).Count();
        }
    }

    static bool GetNextElements(int element, int currentAdapter)
    {
        return (element - currentAdapter) > 0 && (element - currentAdapter) < 4;
    }
}
