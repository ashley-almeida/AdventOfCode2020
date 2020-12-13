using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Collections;
using System.Numerics;

public class Day13
{
    int placements = 0;
    public void DoStuffPartOne()
    {
        int timestamp = 1000511;
        string inputString = "29,37,409,17,13,19,23,353,41";
        var inputs = inputString.Split(',').Select(int.Parse).ToList();
        int startMod = timestamp % inputs[0];
        int minBus = inputs[0] - (timestamp % inputs[0]);
        foreach (int bus in inputs)
        {
            var time = bus - (timestamp % bus);
            if (time < startMod)
            {
                minBus = bus;
                startMod = time;
            }

            Console.WriteLine($"mod {time} bus {bus}");
        }
        Console.WriteLine($"mod {startMod} bus {minBus} - {startMod * minBus} ");
    }



    public void DoStuffPartTwo()
    {

        string inputString = "29,x,x,x,x,x,x,x,x,x,x,x,x,x,x,x,x,x,x,x,x,x,x,37,x,x,x,x,x,409,x,x,x,x,x,x,x,x,x,x,x,x,x,x,x,x,17,13,19,x,x,x,23,x,x,x,x,x,x,x,353,x,x,x,x,x,x,x,x,x,x,x,x,x,x,x,x,x,x,x,x,x,x,x,x,x,x,x,x,x,x,x,x,x,x,x,x,x,x,x,x,41";
        var inputs = inputString.Split(',').ToList();
        var busTimes = new Dictionary<int, int>();
        var maxTimeDiff = 0;

        for (int timeDiff = 0; timeDiff < inputs.Count; timeDiff++)
        {
            if (inputs[timeDiff] == "x")
            {

            }
            else
            {
                busTimes.Add(int.Parse(inputs[timeDiff]), timeDiff);
                Console.WriteLine($"Bus {inputs[timeDiff]} - time {timeDiff}");
            }
        }

        BigInteger timestamp = 0L;
        //return;
        bool found = false;

        long idMult = 1;

        foreach (var busTime in busTimes)
        {
            while (((timestamp + busTime.Value) % busTime.Key) != 0)
            {
                timestamp += idMult;
            }
            idMult *= busTime.Key;
        }

        Console.WriteLine(timestamp);
    }
}
