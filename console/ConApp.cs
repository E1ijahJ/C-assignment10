namespace console;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;

public class ConApp
{
    public static void DisplayQuarters(List<Quarter> quarters)
    {
        throw new NotImplementedException();
    }

    public static void Main(){
Except except = new Except();
List<Quarter> quarters = new List<Quarter>();
Console.WriteLine("Quarters app");
while(true){
  Console.WriteLine("\nEnter a number between 0 and 1.0");
  string input = Console.ReadLine();

  if(input.ToLower()== "exit"){
    Console.WriteLine("Exiting program");
    break;
  }
  if(double.TryParse(input, out double amount)){
    try{
      Quarter newQuarter = new Quarter(amount);
      DisplayQuarters(quarters);
      Console.WriteLine("\n Do you want to add another quarter yes or no?");
      string nexinput = Console.ReadLine().ToLower();
      if(nexinput != "yes"){
        Console.WriteLine("Exting Program");
        break;
      }
    
    }
    catch(Except message){
      Console.WriteLine($"Error: {amount} is out of range. {message.Message}");
      Console.WriteLine("Exting program");
      break;
    }
  }
  else{
    Console.WriteLine("Invalid Imput");
  }
}
static void DisplayQuarters(List<Quarter> quarters){
  var quartergroup = quarters.GroupBy(q => q.GetQuarter()).OrderBy(g => g.Key);

  Console.WriteLine("\nExisiting Quarters:");
  foreach(var group in quartergroup){
    string range = group.Key switch{
      1 => "[0.0 - 0.25)",
      2 => "[0.25 - 0.5)",
      3 => "[0.5 - 0.75)",
      4 => "[0.75 - 1.0]",
      _ => "Unknown Range"
    };
    Console.WriteLine("S{range}: {string.Join(",", group.Select(q.=> q.Value))}");
  }
}



  }
}
