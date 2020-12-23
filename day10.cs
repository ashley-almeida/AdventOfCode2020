using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Collections;

public class day10
{
#pragma warning disable 219
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

        //string sampleString = "16,10,15,5,1,11,7,19,6,12,4"; 
        string sampleString = "28,33,18,42,31,14,46,20,48,47,24,23,49,45,19,38,39,11,1,32,25,35,8,17,7,9,4,2,34,10,3";

        var inputs = inputString.Split(',').ToList();

        var tempList = inputs.Select(int.Parse).ToList();
        var device = tempList.Max() + 3;
        tempList.Add(device);
        tempList.Sort();

        foreach (int x in tempList)
        {
            Console.Write(x + ",");
        }
        //return;

        var blah = new Dictionary<int, long>();

        var currentAdapter = 0;

        Console.WriteLine(NewFork(currentAdapter));

        long NewFork(int currentAdapter)
        {
            var Counter = 0L;
            if (currentAdapter == device)
            {
                Counter++;
            }
            
            var possible = new List<int>(tempList.FindAll(x => x > currentAdapter && GetNextElements(x, currentAdapter)));

            foreach (int adapter in possible)
            {
                if (blah.TryGetValue(adapter, out long x))
                {
                    Counter += x;
                }
                else
                {
                    var y = NewFork(adapter);
                    blah.Add(adapter, y);
                    Counter += y;
                }
            }
            return Counter;
        }
        //Console.WriteLine(Counter);
        Console.WriteLine("start: " + start + " End:" + DateTime.Now.ToString());
    }

    static bool GetNextElements(int element, int currentAdapter)
    {
        return (element - currentAdapter) > 0 && (element - currentAdapter) < 4;
    }
}
