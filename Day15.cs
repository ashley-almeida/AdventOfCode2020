using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Collections;
using System.Numerics;


public class Day15
{
#pragma warning disable 219
    public void DoStuffPartOne()
    {
        string sampleString = "0,3,6";
        string inputString = "9,6,0,10,18,2,1";
        var counterDict = new Dictionary<int, Dictionary<int,int>>();
        var inputs = sampleString.Split(',').Select(int.Parse).ToList();

        var turnNumber = 0;

        for (; turnNumber < inputs.Count; turnNumber++)
        {
            counterDict.Add(inputs[turnNumber], -1);
        }

        var lastNumber = inputs[-1];

        for (int i = inputs.Count; i < 2020; i++)
        {
            if (counterDict.TryGetValue(lastNumber, out int spoken))
            {
                if (spoken == -1)
                {     
                    lastNumber = 0;               
                    if (counterDict.TryGetValue(0, out int zeroSpoken))
                        counterDict[0] = i+1;
                    else
                        counterDict.Add(0, -1);
                }
                else
                {

                }
            }
        }
    }



    public void DoStuffPartTwo()
    {

    }
}
