using System;
using System.Collections.Generic;

Main();


void Main(){

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

int insultsLength = insults.Count();

List<int> indexes = new List<int>();

while (indexes.count < 3)
{
    int candidate = getRandomInt();
    if (!indexes.Contains(candidate))
    {
        indexes.Push(candidate);
    }
};

for ( int i = 0; i<indexes.count; i++)
{
    const index = indexes[i];
    Console.WriteLine(insults[index]);
}

};


void getRandomInt(){
    Random r = new Random();
    int genRan = r.Next(0, (insultsLength -1));
    return genRan
};