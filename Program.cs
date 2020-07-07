using System;

namespace ChooseYourOwnAdventure
{
  class Program
  {
      static void Main(string[] args)
    {
      /* THE MYSTERIOUS NOISE */

      // Start by asking for the user's name:
      Console.Write("What is your name?: ");
      string name = Console.ReadLine();
      Console.WriteLine($"Hello, {name}! Welcome to our story.");
      Console.WriteLine("It begins on a cold rainy night. You're sitting in your room and hear a noise coming from down the hall. Do you investigate?");
      Console.WriteLine("Type YES or NO:");
      string noiseChoice = Console.ReadLine();
      string choice1 = noiseChoice.ToUpper();    
      if (choice1 == "NO")
      {
        Console.WriteLine("Not much of an adventure if you ain't gonna leave the room, nerd!");
        Console.WriteLine("I'll have some balls and pick YES for you!\nYES!");
        Console.WriteLine("You walk into the hallway and see a light coming from under a door down the hall. You walk towards it. Do you open it or knock? "); 
      }
     
      else if (choice1 == "YES")
    {
      Console.WriteLine("You walk into the hallway and see a light coming from under a door down the hall. You walk towards it. Do you open it or knock? ");
    }
     
    Console.WriteLine("Do you OPEN or KNOCK?");
    string doorChoice = Console.ReadLine();
    string choice2 = doorChoice.ToUpper();
   
    if (choice2 == "KNOCK")
    {
      Console.WriteLine("A voice behind the door speaks. It says, \nAnswer this riddle: \nPoor people have it.\nRich people need it. \nIf you eat it you die. \nWhat is it?");

      Console.WriteLine("Type your answer:");
      string riddleAnswer = Console.ReadLine();
      string riddle1 = riddleAnswer.ToUpper();
      if (riddle1 == "NOTHING")
      {
        Console.WriteLine("The door opens and NOTHING is there.\nYou turn off the light and run back to your room and lock the door.\nTHE END.");
      }
      else if (riddle1 != "NOTHING")
      {
        Console.WriteLine("You answered incorrectly. The door doesn't open.\nTHE END.");
      }


    }
    else if (choice2 == "OPEN")
    {
      Console.WriteLine("The door is locked! See if one of your three keys will open it.");
      Console.WriteLine("Enter a number (1-3:)");
      string keyChoice = Console.ReadLine();
      
      switch (keyChoice)
      {
      case "1":
      Console.WriteLine("You choose the first key. Lucky choice!\nThe door opens and NOTHING is there. Strange...\nTHE END.");
      break;
      
      case "2":
      Console.WriteLine("You choose the second key. The door doesn't open.\nTHE END.");
      break;
     
      case "3":
      Console.WriteLine("You choose the third key. The door doesn't open.\nTHE END.");
      break;
      }
    }


     



     
    }
  }
}



