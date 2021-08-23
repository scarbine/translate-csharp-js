using System;
using System.Collections.Generic;


namespace wordFrequency
{
    class Program
    {
        static void Main(string[] args)
        {
                    // Vars

                    string Text = getText();
                    // string Text = getText().replaceAll("/[^A-Za-z0-9]/", "");
                    var Words = Text.Split(" ");
                    // var freqCounts = {};

                    foreach (var word in Words){
                        Console.WriteLine(word);
                    //     if(word.Trim() == "")
                    //     {
                    //         continue;
                    //     }
                        
                    //     if(freqCounts)
                    //     {
                    //         freqCounts[word] += 1;
                    //     }
                    //     else
                    //     {
                    //         {
                    //             freqCounts[word] = 1;
                    //         }
                    //     }
                    // }
                    }
                    // Console.WriteLine(freqCounts);

                    string getText() 
                    {
                        return "Hi! This is Sam. This is a great day!";
                    }
       
        }

    }
}

    
       
