using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;
public class day8
{
    int changer = 0;

    #pragma warning disable 219
    public static void dostuffPart1()
    {
        string inputString = "jmp +1,acc -18,acc +19,acc +19,jmp +202,acc +15,acc +42,acc +30,acc -7,jmp +535,acc +31,acc +9,jmp +581,nop +501,acc +44,acc +18,acc -4,jmp +545,acc +9,acc +5,nop -2,acc +3,jmp +475,acc -10,acc +14,acc +29,nop +471,jmp +470,acc +2,nop +375,acc +31,acc +6,jmp +420,acc -1,acc +2,nop +185,jmp +490,acc +2,jmp +317,nop +282,jmp +457,acc +37,jmp +254,acc +19,jmp +436,jmp +458,acc -7,acc -2,acc -17,jmp +454,acc +37,jmp +212,acc +6,acc +5,acc -7,jmp +104,acc +5,nop +134,acc +46,jmp +541,acc +4,acc +46,acc +18,jmp -53,acc +10,jmp +285,acc +39,acc +34,nop +109,acc +47,jmp +32,jmp +1,jmp +143,acc +36,jmp +429,acc +45,acc +22,jmp -59,acc +0,acc +23,acc +30,acc -7,jmp -45,acc +46,acc +31,jmp +164,acc +37,acc +34,acc +40,acc -1,jmp +246,nop -46,acc +2,acc +31,jmp +221,nop +413,jmp -51,acc -14,jmp +145,acc +1,nop +77,jmp +131,jmp +370,nop +513,acc +7,jmp +476,acc +22,acc +37,acc +44,jmp +334,acc +9,acc -1,acc +5,acc +27,jmp +351,acc +31,jmp +220,nop -61,acc +34,jmp +504,nop +471,acc +6,acc +48,jmp -17,jmp +217,acc +13,acc +0,acc +25,jmp +144,acc -5,acc +17,nop +341,jmp -26,acc -10,acc +34,jmp +168,nop -16,acc -6,acc -10,acc +38,jmp +30,acc -2,acc -14,jmp +419,acc +40,acc -17,acc +27,acc +8,jmp +101,nop +370,acc +2,acc -10,acc -7,jmp +224,nop +437,acc +42,acc +50,acc +39,jmp +81,jmp +11,jmp +143,acc +6,acc +46,jmp -107,acc +13,jmp -109,acc +5,jmp +1,jmp +467,jmp -159,nop +421,jmp +243,acc +44,nop +412,acc -6,acc +13,jmp +56,acc -12,acc +18,jmp +313,nop +151,acc +5,acc +49,jmp +120,acc +46,acc +23,nop -122,acc +21,jmp -55,acc -15,jmp -115,acc +19,nop +116,acc +32,acc +21,jmp +16,acc +27,acc +32,jmp +359,acc +16,acc +18,acc +15,jmp +54,nop +182,acc +4,jmp +361,acc +4,acc +38,acc +49,jmp -94,jmp +428,acc +0,acc +9,jmp +224,jmp +82,nop +57,acc +6,jmp +1,jmp +144,jmp +20,jmp +265,jmp +402,nop +114,acc -12,acc -11,acc +1,jmp +412,nop -163,acc +50,acc +1,acc -9,jmp -20,acc +10,acc +6,jmp +323,acc +10,jmp +1,acc +42,jmp +46,acc +35,acc +31,jmp -139,jmp +129,jmp -193,acc -4,nop +247,nop -163,acc +25,jmp -26,acc +34,acc +26,acc +40,jmp +220,acc -6,acc +6,jmp +311,acc +0,acc +14,acc +41,acc +6,jmp +284,acc +32,jmp -13,nop +157,acc -4,acc +47,jmp -146,acc +34,acc +6,nop +196,acc +5,jmp +268,acc -8,jmp -176,acc +34,acc +17,jmp +1,jmp +114,acc +32,acc +39,nop +313,acc +38,jmp -237,jmp -273,acc +21,acc +26,acc +31,jmp -231,acc +17,jmp -105,nop +333,nop +17,jmp +11,acc -9,acc +2,jmp -162,acc +3,acc +0,nop +318,jmp +215,acc +14,acc +32,jmp -196,jmp +33,acc -6,acc +45,acc +27,jmp -166,acc -1,jmp -25,acc +0,acc +4,acc -14,acc +0,jmp -115,nop +118,acc +28,nop +175,acc +45,jmp -97,jmp +78,jmp -284,acc +35,nop -248,acc -18,acc -6,jmp -308,jmp -95,acc -2,acc +0,jmp +255,acc +7,jmp -24,acc +17,acc +20,jmp -220,jmp +172,acc +40,acc +39,acc +19,jmp -238,nop +44,nop -99,nop +238,jmp +195,acc -14,acc +36,acc +40,acc -11,jmp -65,nop -54,nop +47,acc -11,jmp +18,jmp +98,jmp +252,nop -1,acc +1,acc +10,jmp -4,jmp -319,jmp -46,acc -8,acc +50,acc +43,jmp -174,acc +22,acc +4,acc +32,acc -6,jmp +73,acc +8,jmp -31,acc +16,nop +11,acc +26,jmp -98,acc -11,acc +40,jmp +101,acc +28,acc +30,acc -16,acc +7,jmp +239,jmp -179,acc +47,acc +15,acc +42,acc +26,jmp +30,acc +17,acc +3,acc -5,nop -98,jmp -236,acc +2,jmp +196,acc +39,acc -14,acc +36,acc +49,jmp +189,jmp +235,acc +27,acc -2,acc +16,acc +40,jmp -81,acc -5,acc +17,acc -1,jmp +1,jmp -129,nop -171,acc +47,jmp +169,acc -16,acc -5,jmp +172,nop -84,acc +8,acc +40,acc +43,jmp -33,acc +39,nop -12,jmp +53,acc +36,jmp -270,acc +17,acc -1,jmp -255,acc +0,acc -12,jmp -371,jmp -216,acc +45,acc -18,acc +23,acc -17,jmp -37,jmp -386,nop -302,acc -19,acc -16,jmp -297,acc -18,acc -7,acc +17,acc +17,jmp -173,jmp +114,acc +4,acc +19,nop -296,jmp -36,acc -18,acc -14,acc +6,nop -27,jmp -101,acc +15,nop -407,jmp +44,acc -18,acc -6,acc +33,acc +36,jmp +80,acc +43,jmp +73,acc -2,acc +7,acc +4,jmp -10,acc +46,nop -49,acc +7,jmp +65,acc +24,jmp +144,acc +13,acc +26,jmp -351,jmp +1,acc +34,nop +62,jmp -363,acc -4,acc -5,jmp +23,jmp +82,acc -7,acc -7,acc +15,jmp -468,acc +7,nop -423,jmp -178,nop -425,acc +23,jmp -181,acc +6,acc -11,jmp -321,acc +3,jmp -122,acc +12,jmp +44,acc -5,acc -16,acc +16,jmp -281,acc +33,acc -4,acc +15,jmp +9,jmp +63,acc +35,nop -12,acc +25,acc -10,jmp -452,acc +1,jmp -148,acc +8,acc +40,acc +48,jmp +2,jmp -315,nop -325,acc -4,acc +16,acc -4,jmp -369,acc +21,acc +3,jmp -153,nop -25,acc +0,jmp -84,acc +32,jmp +19,acc -18,acc -1,jmp -385,jmp +1,jmp -357,acc -13,acc -13,jmp -360,jmp -393,acc +4,nop -102,jmp -316,jmp -248,acc +4,nop -487,jmp -339,acc +3,jmp -190,acc +24,acc +31,jmp -166,jmp -482,acc +22,acc +32,jmp -290,acc +22,acc +48,acc +5,acc -6,jmp -330,nop -203,acc +7,acc +1,jmp -287,acc +15,acc +3,jmp -230,acc +37,nop -162,jmp +33,jmp -147,acc +16,acc +39,acc +49,jmp -560,acc +26,jmp +26,jmp -283,jmp -486,acc -9,jmp +1,acc +25,acc +1,jmp -514,acc +46,jmp -166,acc -5,acc +35,nop -204,jmp -175,nop -30,nop +11,jmp -400,acc +15,acc -7,acc -1,jmp +18,acc +31,acc +16,acc +43,acc +33,jmp -260,acc +1,acc +23,acc +25,acc -1,jmp -200,acc -15,jmp -314,jmp -238,jmp -75,jmp -192,acc +30,jmp -525,acc -14,jmp +17,acc +7,acc +9,acc -6,nop -312,jmp -559,acc +28,jmp -305,jmp -239,acc +0,acc -5,acc +9,jmp -471,nop -327,acc -5,acc -19,jmp -496,acc +17,jmp +1,jmp +1,acc +29,jmp +1";

        string sampleString = "nop +0,acc +1,jmp +4,acc +3,jmp -3,acc -99,acc +1,jmp -4,acc +6";

        var inputs = inputString.Split(',').ToList();

        int accumilator = 0;

        for (int i = 0; i < inputs.Count(); i++)
        {            
            if (inputs[i] != "DONE")
            {
                //Console.WriteLine(inputs[i]);
                var ruleParts = inputs[i].Split(' ').ToList();
                switch (ruleParts[0])
                {
                    case "nop":
                        {
                            inputs[i] = "DONE";
                            break;
                        }
                    case "acc":
                        {
                            accumilator += Int32.Parse(ruleParts[1]);
                            inputs[i] = "DONE";
                            break;
                        }
                    case "jmp":
                        {
                            var j = i + Int32.Parse(ruleParts[1]) - 1;
                            inputs[i] = "DONE";
                            i = j;
                            break;
                        }
                }
            }
            else
            {
                break;
            }
        }

        Console.WriteLine(accumilator);
    }
    public void dostuffPart2()
    {
        string inputString = "jmp +1,acc -18,acc +19,acc +19,jmp +202,acc +15,acc +42,acc +30,acc -7,jmp +535,acc +31,acc +9,jmp +581,nop +501,acc +44,acc +18,acc -4,jmp +545,acc +9,acc +5,nop -2,acc +3,jmp +475,acc -10,acc +14,acc +29,nop +471,jmp +470,acc +2,nop +375,acc +31,acc +6,jmp +420,acc -1,acc +2,nop +185,jmp +490,acc +2,jmp +317,nop +282,jmp +457,acc +37,jmp +254,acc +19,jmp +436,jmp +458,acc -7,acc -2,acc -17,jmp +454,acc +37,jmp +212,acc +6,acc +5,acc -7,jmp +104,acc +5,nop +134,acc +46,jmp +541,acc +4,acc +46,acc +18,jmp -53,acc +10,jmp +285,acc +39,acc +34,nop +109,acc +47,jmp +32,jmp +1,jmp +143,acc +36,jmp +429,acc +45,acc +22,jmp -59,acc +0,acc +23,acc +30,acc -7,jmp -45,acc +46,acc +31,jmp +164,acc +37,acc +34,acc +40,acc -1,jmp +246,nop -46,acc +2,acc +31,jmp +221,nop +413,jmp -51,acc -14,jmp +145,acc +1,nop +77,jmp +131,jmp +370,nop +513,acc +7,jmp +476,acc +22,acc +37,acc +44,jmp +334,acc +9,acc -1,acc +5,acc +27,jmp +351,acc +31,jmp +220,nop -61,acc +34,jmp +504,nop +471,acc +6,acc +48,jmp -17,jmp +217,acc +13,acc +0,acc +25,jmp +144,acc -5,acc +17,nop +341,jmp -26,acc -10,acc +34,jmp +168,nop -16,acc -6,acc -10,acc +38,jmp +30,acc -2,acc -14,jmp +419,acc +40,acc -17,acc +27,acc +8,jmp +101,nop +370,acc +2,acc -10,acc -7,jmp +224,nop +437,acc +42,acc +50,acc +39,jmp +81,jmp +11,jmp +143,acc +6,acc +46,jmp -107,acc +13,jmp -109,acc +5,jmp +1,jmp +467,jmp -159,nop +421,jmp +243,acc +44,nop +412,acc -6,acc +13,jmp +56,acc -12,acc +18,jmp +313,nop +151,acc +5,acc +49,jmp +120,acc +46,acc +23,nop -122,acc +21,jmp -55,acc -15,jmp -115,acc +19,nop +116,acc +32,acc +21,jmp +16,acc +27,acc +32,jmp +359,acc +16,acc +18,acc +15,jmp +54,nop +182,acc +4,jmp +361,acc +4,acc +38,acc +49,jmp -94,jmp +428,acc +0,acc +9,jmp +224,jmp +82,nop +57,acc +6,jmp +1,jmp +144,jmp +20,jmp +265,jmp +402,nop +114,acc -12,acc -11,acc +1,jmp +412,nop -163,acc +50,acc +1,acc -9,jmp -20,acc +10,acc +6,jmp +323,acc +10,jmp +1,acc +42,jmp +46,acc +35,acc +31,jmp -139,jmp +129,jmp -193,acc -4,nop +247,nop -163,acc +25,jmp -26,acc +34,acc +26,acc +40,jmp +220,acc -6,acc +6,jmp +311,acc +0,acc +14,acc +41,acc +6,jmp +284,acc +32,jmp -13,nop +157,acc -4,acc +47,jmp -146,acc +34,acc +6,nop +196,acc +5,jmp +268,acc -8,jmp -176,acc +34,acc +17,jmp +1,jmp +114,acc +32,acc +39,nop +313,acc +38,jmp -237,jmp -273,acc +21,acc +26,acc +31,jmp -231,acc +17,jmp -105,nop +333,nop +17,jmp +11,acc -9,acc +2,jmp -162,acc +3,acc +0,nop +318,jmp +215,acc +14,acc +32,jmp -196,jmp +33,acc -6,acc +45,acc +27,jmp -166,acc -1,jmp -25,acc +0,acc +4,acc -14,acc +0,jmp -115,nop +118,acc +28,nop +175,acc +45,jmp -97,jmp +78,jmp -284,acc +35,nop -248,acc -18,acc -6,jmp -308,jmp -95,acc -2,acc +0,jmp +255,acc +7,jmp -24,acc +17,acc +20,jmp -220,jmp +172,acc +40,acc +39,acc +19,jmp -238,nop +44,nop -99,nop +238,jmp +195,acc -14,acc +36,acc +40,acc -11,jmp -65,nop -54,nop +47,acc -11,jmp +18,jmp +98,jmp +252,nop -1,acc +1,acc +10,jmp -4,jmp -319,jmp -46,acc -8,acc +50,acc +43,jmp -174,acc +22,acc +4,acc +32,acc -6,jmp +73,acc +8,jmp -31,acc +16,nop +11,acc +26,jmp -98,acc -11,acc +40,jmp +101,acc +28,acc +30,acc -16,acc +7,jmp +239,jmp -179,acc +47,acc +15,acc +42,acc +26,jmp +30,acc +17,acc +3,acc -5,nop -98,jmp -236,acc +2,jmp +196,acc +39,acc -14,acc +36,acc +49,jmp +189,jmp +235,acc +27,acc -2,acc +16,acc +40,jmp -81,acc -5,acc +17,acc -1,jmp +1,jmp -129,nop -171,acc +47,jmp +169,acc -16,acc -5,jmp +172,nop -84,acc +8,acc +40,acc +43,jmp -33,acc +39,nop -12,jmp +53,acc +36,jmp -270,acc +17,acc -1,jmp -255,acc +0,acc -12,jmp -371,jmp -216,acc +45,acc -18,acc +23,acc -17,jmp -37,jmp -386,nop -302,acc -19,acc -16,jmp -297,acc -18,acc -7,acc +17,acc +17,jmp -173,jmp +114,acc +4,acc +19,nop -296,jmp -36,acc -18,acc -14,acc +6,nop -27,jmp -101,acc +15,nop -407,jmp +44,acc -18,acc -6,acc +33,acc +36,jmp +80,acc +43,jmp +73,acc -2,acc +7,acc +4,jmp -10,acc +46,nop -49,acc +7,jmp +65,acc +24,jmp +144,acc +13,acc +26,jmp -351,jmp +1,acc +34,nop +62,jmp -363,acc -4,acc -5,jmp +23,jmp +82,acc -7,acc -7,acc +15,jmp -468,acc +7,nop -423,jmp -178,nop -425,acc +23,jmp -181,acc +6,acc -11,jmp -321,acc +3,jmp -122,acc +12,jmp +44,acc -5,acc -16,acc +16,jmp -281,acc +33,acc -4,acc +15,jmp +9,jmp +63,acc +35,nop -12,acc +25,acc -10,jmp -452,acc +1,jmp -148,acc +8,acc +40,acc +48,jmp +2,jmp -315,nop -325,acc -4,acc +16,acc -4,jmp -369,acc +21,acc +3,jmp -153,nop -25,acc +0,jmp -84,acc +32,jmp +19,acc -18,acc -1,jmp -385,jmp +1,jmp -357,acc -13,acc -13,jmp -360,jmp -393,acc +4,nop -102,jmp -316,jmp -248,acc +4,nop -487,jmp -339,acc +3,jmp -190,acc +24,acc +31,jmp -166,jmp -482,acc +22,acc +32,jmp -290,acc +22,acc +48,acc +5,acc -6,jmp -330,nop -203,acc +7,acc +1,jmp -287,acc +15,acc +3,jmp -230,acc +37,nop -162,jmp +33,jmp -147,acc +16,acc +39,acc +49,jmp -560,acc +26,jmp +26,jmp -283,jmp -486,acc -9,jmp +1,acc +25,acc +1,jmp -514,acc +46,jmp -166,acc -5,acc +35,nop -204,jmp -175,nop -30,nop +11,jmp -400,acc +15,acc -7,acc -1,jmp +18,acc +31,acc +16,acc +43,acc +33,jmp -260,acc +1,acc +23,acc +25,acc -1,jmp -200,acc -15,jmp -314,jmp -238,jmp -75,jmp -192,acc +30,jmp -525,acc -14,jmp +17,acc +7,acc +9,acc -6,nop -312,jmp -559,acc +28,jmp -305,jmp -239,acc +0,acc -5,acc +9,jmp -471,nop -327,acc -5,acc -19,jmp -496,acc +17,jmp +1,jmp +1,acc +29,jmp +1";

        string sampleString = "nop +0,acc +1,jmp +4,acc +3,jmp -3,acc -99,acc +1,jmp -4,acc +6";

        var inputs = inputString.Split(',').ToList();

        int accumilator = 0;

        var original = inputs.ToList();
        var modified = inputs.ToList();

        accumilator = sequenceFinder(inputs, modified);


        Console.WriteLine(accumilator);
    }

    public int sequenceFinder(List<string> originalInputs, List<string> modified)
    {
        var tempStore = modified.ToList();
        var accumilator = 0;
        for (int i = 0; i < tempStore.Count(); i++)
        {
            if (tempStore[i] != "DONE")
            {               
                var ruleParts = tempStore[i].Split(' ').ToList();
                switch (ruleParts[0])
                {
                    case "nop":
                        {
                            tempStore[i] = "DONE";
                            break;
                        }
                    case "acc":
                        {
                            accumilator += Int32.Parse(ruleParts[1]);
                            tempStore[i] = "DONE";
                            break;
                        }
                    case "jmp":
                        {
                            var j = i + Int32.Parse(ruleParts[1]) - 1;
                            tempStore[i] = "DONE";
                            i = j;
                            break;
                        }
                }
            }
            else
            {
                var newModified = originalInputs.ToList(); 

                for (int j = changer; j < newModified.Count(); j++)
                {
                    var ruleParts = newModified[j].Split(' ').ToList();
                    bool found = false;
                    switch (ruleParts[0])
                    {
                        case "nop":
                            newModified[j] = "jmp " + ruleParts[1];
                            found = true;
                            break;
                        case "jmp":
                            newModified[j] = "nop " + ruleParts[1];
                            found = true;
                            break;
                        default:
                            break;
                    }

                    if (found)
                    {
                        changer = j + 1;                        
                        break;
                    }
                }
                accumilator = sequenceFinder(originalInputs, newModified);
                break;
            }
        }
        return accumilator;
    }
}
