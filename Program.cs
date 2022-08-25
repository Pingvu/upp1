using System;
using System.Collections.Generic;
class program
{
    public static void Main(){
        
         List<fordon> fordonList = new List<fordon>();
         fordonList.Add(new fordon ("Alan", 2022,"car"));
         fordonList.Add(new fordon ("Otto", 2020,"bike"));
         fordonList.Add(new fordon ("Ditto", 2021,"Motor"));
       foreach (var fordon in fordonList)
{
    Console.WriteLine("fordon: {0},{1},{2}",fordon.Tillverkare, fordon.Årsmodell, fordon.Modell );
}
    }
    
}
class fordon
{
    private string tillverkare;
    private int årsmodell;
    private string modell;
    public fordon(string tillverkare, int årsmodell, string modell)
    {
        this.tillverkare = tillverkare;
        this.årsmodell = årsmodell;
        this.modell = modell;
    }
    public string Tillverkare
    {
        get { return tillverkare;  }
        set { tillverkare = value; }
    }
  
    public int Årsmodell
    {
        get { return årsmodell; }
        set { årsmodell = value; }
    }
    public string Modell
    {
        get { return modell; }
        set { modell = value; }
    }
}

