using System;
using System.Collections.Generic;
using System.Globalization;

class Program {
  public static void Main (string[] args) {

    // I initialized a coninuation flag here
    int cont = 1; // We set it to 1 to build the idea of building virtual cookies within the program
                  // to indicate if they have visited before of if this is their first time visiting.

    // I created a list for the amount of users for each iteration to be stored
    List<string> initialList = new List<string>();

    // I created a list for the amount of sales for each iteration to be stored
    List<int> salesList = new List<int>();

    // I instruct the audience member on the process of how to escape this program if they want   
    Console.WriteLine ("** Please note to end this program enter the letter z, lowercase or uppercase it does not matter. **\n\n");

    // We use a while loop with a continuous flag to keep the program running until the user wants to stop
    while (cont >= 1)
        {

        //So at the beginning of our continuous stack we come up with two greetings for the user
        if (cont == 1)
              // If this is their first time say this
              { Console.WriteLine ("Hello I am a program that records Home Sales. Please Enter The Sales Person's Initial:"); }
        else
              // If this is a return visit from the same player
              { Console.WriteLine ("Thank you. Please Enter The Next Sales Person's Initial:"); }
    
        // We initialize a variable to catch the user input for their initial input    
        string initialInput = Console.ReadLine();

        // We create a sentinel here
        int stop_gap = 0;

        // If we do not enter the correct initial character
        while (initialInput != "d" && initialInput != "D" && initialInput != "e" && initialInput != "E" && initialInput != "f" && initialInput != "F")
            {   // We check to see if they want to break the program and see totals
                if (initialInput == "Z" || initialInput == "z") // If the user enters Z or z
                {   // Terminate this functions lifespan
                    stop_gap = 1;
                    break;
                }
    
                // They did not enter the correct initial
                Console.WriteLine ("Error, Invalid Sales Person, please try again.");
                // Ask them for valid input again
                initialInput = Console.ReadLine();
            }


        if (stop_gap == 1) // If they want to stop the program
            { 
                break; // end the program and get results
            }
        
        // Once they enter a correct value of an iniital
        initialList.Add(initialInput); // They are added to a list of initials 
                                           // for this programs life cycle
    
        // Now we ask them how successful they were in life  
        Console.WriteLine ("Okay Great, now please enter that person's sales:");
    
        // We ask them to input their life's value here
        string salesInput = Console.ReadLine();

        // Now we find out if the user still knows how to follow instruction
        while (int.TryParse(salesInput, out int salesFail) == false)
    
            {

            // Reprimand the individual for not follow instructions
            Console.WriteLine ("I asked for a monetary value.");

            // Record their input here
            salesInput = Console.ReadLine();
    
            } 
    
            // Now we know their first initial and their life's worth
            salesList.Add(int.Parse(salesInput));
    
        cont++; // and this here increments the continuous flag to 
                // indicate that they have visited before
              
        } // And this is where the user interaction ends until they want to exit with a Zzzz


      

    // Now we initialize a variable to store the total amount of sales
    int sum = 0;

    // It will loop through each sale in the salesList
    foreach (int sale in salesList) 
        {
            sum += sale; // each iteration we throw more cash into a total value
        }

    // And our free accountant translate that numer into something the audience might understand
    string formattedAmount = sum.ToString("C0", CultureInfo.CurrentCulture);
    // We are converting the currency into a dollar amount with a us capital symbol and commas

    // And once the calculation is complete we tell our audience the total number of sales
    Console.WriteLine("Grand Total: " + formattedAmount);
    
    // Now we set a variable to pull from the list and act as memory
    int highestValue = 0;

    // Over here we create a variable to pull each price individually submitted
    int associativeIndex = 0;

    int correspondingAssociate = 0;

    // Now we run through the sales list
      foreach ( int sale in salesList)
      { 
        // Your code to process each sale goes here
        // You can access the current sale value using the 'sale' variable
            
          // if the sale we are looking at is the highest
          if (sale > highestValue)
          {
              // Make it the highest sale on record for this program
              highestValue = sale;

              // Create a reference for the highest corresponding sales associate
              correspondingAssociate = associativeIndex;
              
          }
        
          // We prepare to move to the next associat in the list
            associativeIndex++;

        } 


    // Now using the associative index we pulled from the sale we can connect that to
    Console.WriteLine("Highest Sale: " + initialList[correspondingAssociate]);
                                                // the associate that made that sale    

} // We close our main stack
    
} // Porky Pig Appears and in his branded studder tells the audience to please go home