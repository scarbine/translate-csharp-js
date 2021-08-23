using System;


void Main()
{

    // List<List<string>> Tables = new List<List<string>>();
    // Tables.Add(new List<string> Table1 )


for (var guest of Guests)
{
    var table1Occuaptions = Tables.Select(g => g.occupation);
    if (table1Occuaptions.Contains(guest.occupation))
    {
        Tables.Table2.Push(guest);
    }
    else
    {
        Tables.Table1.Push(guest);
    }
}


public class Guest 
{
    public string Name {get; set;}
    public string Occupation {get; set;}
    public string Bio {get; set;}

    public Guest(string name, string occupation, string bio)
    {
        this.Name = name;
        this.Occupation = occupation;
        this.Bio = bio;
    }
}

Guest MarilynMonroe = new Guest (
    "Marilyn Monroe",
    new occupation("entertainer"),
    new bio("(1926 - 1962) American actress, singer, model")
);
Guest AbrahamLincoln = new Guest (
    "Abraham Lincoln",
    new occupation("politician"),
    new bio("(1809 - 1865) US President during American civil war")
);
Guest MartinLutherKing = new Guest (
    "Martian Luther King",
    new occupation("activist"),
    new bio("(1913 - 2005)  American civil rights activist")
);
Guest PeteSellers = new Guest (
    "Pete Sellers",
    new occupation("entertainer"),
    new bio( "(1925 - 1980) British actor and comedian")
);
Guest AlanTuring = new Guest (
    "Alan Turing",
    new occupation("computer scientist"),
    new bio( "(1912 - 1954) - British computing pioneer, Turing machine, algorithms, cryptology, computer architecture, saved the world")
);
Guest AdmiralGraceHopper = new Guest (
    "Admiral Grace Hopper",
    new occupation("computer scientist"),
    new bio( "(1906–1992) - developed early compilers: FLOW-Matic, COBOL; worked on UNIVAC; gave speeches on computer history, where she gave out nano-seconds")
);
Guest IndiraGandhi = new Guest (
    "Indira Gandhi",
    new occupation("politician"),
    new bio( "(1917 - 1984) Prime Minister of India 1966 - 1977")
);


public class Tables
{
    public List<string> Table1 { get; set; }
    public List<string> Table2 { get; set; }

}






};



Main();