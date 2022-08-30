using System;
using System.Collections.Generic;
using System.Text;
class program
{  
    public static void Main(){
         List<fordon> fordonList = new List<fordon>();
         fordonList.Add(new fordon ("Alan", 2022,"car"));
         fordonList.Add(new fordon ("Otto", 2020,"bike"));
         fordonList.Add(new fordon ("Ditto", 2021,"Motor"));
       
       string newTillverkare;
       string newModell;
       int newÅrsmodell;
       Console.Write("Ange Tillverkare: ");
       newTillverkare= Console.ReadLine();
       Console.Write("Ange Årsmodell: ");
       newÅrsmodell = Convert.ToInt32(Console.ReadLine());
       Console.Write("Ange modell: ");
       newModell = Console.ReadLine();
      fordonList.Add(new fordon(newTillverkare, newÅrsmodell,newModell));
      foreach (var fordon in fordonList)
{
    Console.WriteLine("{0},{1},{2}",fordon.Tillverkare, fordon.Årsmodell, fordon.Modell );
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

