using System;
using System.Collections.Generic;
using Linq;

Main();


void Main()
{

    List<int> indexes = new List<int>();
    List<string> insults = new List<string>()
    {
        "You look like what morning breath smells like.",
        "If you tried to give me cpr I would probably throw myself back under water",
        "I am not a fan of you",
        "You think you're so special...and you are. The fact of your existence is nearly impossible to believe",
        "I'd rather walk than be on the same plane as you",
        "If I were given a million dollars to hang out with you...I would, but then I'd have to spend half of it on therapy",
        "Do you have to be so...like that?"
    };

    int insultsLength = insults.Count;


    while (indexes.Count < 3)
    {
        int candidate = getRandomInt();
        if (!indexes.Contains(candidate))
        {
            indexes.Add(candidate);
        }
    }

    for ( int i = 0; i<indexes.Count; i++)
    {
        var index = indexes[i];
        Console.WriteLine(insults[index]);
    }

    int getRandomInt(){
        Random r = new Random();
        int genRan = r.Next(0,insultsLength);
        return genRan;
    };

}


