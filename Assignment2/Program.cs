using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Assignment2
{
    class Program
    {
        public static int Choice;

        public static int athleteChoice;    //Value for choosing an athlete
        public static int eventChoice;      //Value for choosing an event
        public static int swimChoice;       //Value for choosing a swimming event
        public static int trackChoice;      //Value for choosing a track event
        public static int venueChoice;      //Value for choosing a venue

        public static Athlete[] athletes = new Athlete[3];                  //Array for the athletes, with a size of 3
        public static Venue[] venues = new Venue[2];                        //Array for venues, with a size of 2
        public static SwimmingEvent[] swimevents = new SwimmingEvent[2];    //Array for swimming events, with a size of 2
        public static TrackEvent[] trackevents = new TrackEvent[2];         //Array for track events, with a size of 2

        public static void displayMenu()    //Method for displaying the menu
        {
            Console.Clear();    //Clears the console

            Console.WriteLine("Athletics Program");     //Displays the menu and the choicse available
            Console.WriteLine("--------------------");
            Console.WriteLine("1.   Add Athletes");
            Console.WriteLine("2.   Display Athletes");
            Console.WriteLine("3.   Add Venue");
            Console.WriteLine("4.   Display Venue");
            Console.WriteLine("5.   Add Track Event");
            Console.WriteLine("6.   Display Track Event");
            Console.WriteLine("7.   Add Swimming Event");
            Console.WriteLine("8.   Display Swimming Event");
            Console.WriteLine("9.   Add Athlete to Event");
            Console.WriteLine("10.  Display Athlete Event Data");
            Console.WriteLine("11.  Add Event to Venue");
            Console.WriteLine("12.  Display Venue Event Data");
            Console.WriteLine("13.  Exit");
            try     //Try for exception, incase the user enters something unable to be converted to integer
            {
                Choice = Convert.ToInt32(Console.ReadLine());   //User input for the choice variable for selecting an option
            }

            catch (Exception e)     //Displays the error message
            {
                Console.Clear();
                Console.WriteLine("ERROR");
                Console.WriteLine(e.Message);   //Dislays the exception
                Console.WriteLine("Enter a valid selection, press enter to continue");
                Console.ReadLine();             //Pauses for input
            }
        }
        
        public static void addAthlete()     //Method for adding the athletes to the array
        {
            Console.Clear();    //Clears the consoles

            Console.WriteLine("-Add three athletes-");
            Console.WriteLine();

            for (int i = 0; i < athletes.Length; i++)   //For loop, loops the the size of the athletes array
            {

                athletes[i] = new Athlete();                //New entry in the array
                
                Console.WriteLine("Enter First Name");
                athletes[i].AFName = Console.ReadLine();    //User input for the athlete's first name
                
                Console.WriteLine("Enter Last Name");
                athletes[i].ALName = Console.ReadLine();    //User input for the athlete's last name
                
                Console.WriteLine("Enter Address");
                athletes[i].AAddress = Console.ReadLine();  //User input for the athlete's address
                
                Console.WriteLine("Enter Phone number");
                athletes[i].APhonenumber = Console.ReadLine();  //User input for the athlete's phonenumber
                /*  Input for obsolete data
                Console.WriteLine("Enter the event participating in");
                athletes[i].AParticipate = Console.ReadLine();  //User input for the athlete's event they are participating
                */
                Console.WriteLine("-Athlete Added, press enter to continue-");
                Console.ReadLine(); //Pause for input

                Console.Clear();    //Clears the console
            }
        }
        
        public static void displayAthlete() //Method for displaying the athletes entered into the array
        {
            Console.Clear();    //Clears the console

            for (int i = 0; i < athletes.Length; i++)   //For loop, loops the the size of the athletes array
            {
                try //Tries for exception, incase the user runs the method while the array is empty
                {
                    Console.WriteLine("Number: " + (i + 1));
                    Console.WriteLine("First Name: " + athletes[i].AFName);
                    Console.WriteLine("Last Name: " + athletes[i].ALName);
                    Console.WriteLine("Address: " + athletes[i].AAddress);
                    Console.WriteLine("Phone number: " + athletes[i].APhonenumber);
                    //Console.WriteLine("Event: " + athletes[i].AParticipate);  Output for obsolete data
                    Console.WriteLine();
                }

                catch (Exception e) //Displays the error message
                {
                    Console.Clear();
                    Console.WriteLine("ERROR");
                    Console.WriteLine(e.Message);   //Displays the exception
                    Console.WriteLine("Press Enter to return to the menu");
                    Console.WriteLine();
                }
            }
            Console.ReadLine();
        }
        
        public static void addVenue()       //Method for adding venues to the array
        {
            Console.Clear();

            Console.WriteLine("-Add two venues-");
            Console.WriteLine();

            for (int i = 0; i < venues.Length; i++)
            {
                venues[i] = new Venue(); //New entry in the array

                Console.WriteLine("Enter Venue Name");
                venues[i].VName = Console.ReadLine();       //User input for the venue's name

                Console.WriteLine("Enter Venue Address");
                venues[i].VAddress = Console.ReadLine();    //User input for the venue's address

                Console.WriteLine("-Venue Added, press enter to continue-");
                Console.ReadLine();
                Console.Clear();
            }
        }
        
        public static void displayVenue()   //Method for displaying the venues entered into the array
        {
            Console.Clear();

            for (int i = 0; i < venues.Length; i++) //For loop, loops the the size of the venue's array
            {
                try     //Try for exceptions incase the user runs the method while the array is empty
                {
                    Console.WriteLine("Venue Name: " + venues[i].VName);
                    Console.WriteLine("Enter Venue Address: " + venues[i].VAddress);
                    Console.WriteLine();
                }

                catch (Exception e)     //Displays the error message in case of exception
                {
                    Console.Clear();
                    Console.WriteLine("ERROR");
                    Console.WriteLine(e.Message);   //Displays the exception
                    Console.WriteLine("Press Enter to return to the menu");
                    Console.WriteLine();
                }
            }
            

            
            Console.ReadLine();
        }
        
        public static void addTrackEvent()  //Method for adding track events to the array
        {
            Console.Clear();

            Console.WriteLine("-Add two track events-");
            Console.WriteLine();

            for (int i = 0; i < trackevents.Length; i++)    //For loop, loops the the size of the track events array
            {
                trackevents[i] = new TrackEvent(); //New entry in the array

                Console.WriteLine("Enter Name");
                trackevents[i].EName = Console.ReadLine();          //User input for the event's name

                Console.WriteLine("Enter Date and Time");
                trackevents[i].EDateAndTime = Console.ReadLine();   //User input for the event's Date and Time

                try     //Try for exception, in case the user enters a fee in an invalid format
                {
                    Console.WriteLine("Enter Fee");
                    trackevents[i].EFee = Convert.ToDouble(Console.ReadLine()); //User input for the event's fee
                }

                catch (Exception e)     //Displays the error message
                {
                    Console.Clear();
                    Console.WriteLine("ERROR");
                    Console.WriteLine(e.Message);   //Displays the exception
                    Console.WriteLine("Press Enter to continue");
                    Console.WriteLine();
                }
                /*  Input for obsolete data
                Console.WriteLine("Enter Venue");
                trackevents[i].EVenue = Console.ReadLine();     //User input for the event's venue
                */
                Console.WriteLine("Enter Distance");
                trackevents[i].TDistance = Console.ReadLine();  //User input for the event's distance

                Console.WriteLine("Enter Indoor or Outdoor");
                trackevents[i].TInOrOut = Console.ReadLine();   //User input for whether the evvent is indoors or outdoors

                Console.WriteLine("-Track Event Added, press enter to continue-");
                Console.ReadLine();

                Console.Clear();
            }
        }

        public static void displayTrackEvent()  //Method for displaying the track events entered into the array
        {
            Console.Clear();

            for (int i = 0; i < trackevents.Length; i++) //For loop, loops the the size of the track event array
            {
                try     //Try for exception, in case the user runs the method while the array is empty
                {
                    Console.WriteLine("Name: " + trackevents[i].EName);
                    Console.WriteLine("Date and Time: " + trackevents[i].EDateAndTime);
                    Console.WriteLine("Fee: " + trackevents[i].EFee);
                    //Console.WriteLine("Venue: " + trackevents[i].EVenue); Output for obsolete data
                    Console.WriteLine("Distance: " + trackevents[i].TDistance);
                    Console.WriteLine("Indoor or Outdoor: " + trackevents[i].TInOrOut);
                    Console.WriteLine();
                }

                catch (Exception e) //Displays the error message
                {
                    Console.Clear();
                    Console.WriteLine("ERROR");
                    Console.WriteLine(e.Message);   //Displays the exception
                    Console.WriteLine("Press Enter to return to the menu");
                    Console.WriteLine();
                }
            }
            Console.ReadLine();
        }
        
        public static void addSwimEvent()   //Method for adding the swimming events to the array
        {
            Console.Clear();

            Console.WriteLine("-Add two swimming events-");
            Console.WriteLine();

            for (int i = 0; i < swimevents.Length; i++) //For loop, loops the the size of the swimming event array
            {

                swimevents[i] = new SwimmingEvent();    //New entry in the array

                Console.WriteLine("Enter Name");
                swimevents[i].EName = Console.ReadLine(); //User input for the events name

                Console.WriteLine("Enter Date and Time");
                swimevents[i].EDateAndTime = Console.ReadLine();    //User input for the events date and time
                
                try     //Try for exception in case the user enters the fee in an invalid format
                {
                    Console.WriteLine("Enter Fee");
                    swimevents[i].EFee = Convert.ToDouble(Console.ReadLine());  //User input for event fee
                }

                catch (Exception e) //Displays error message
                {
                    Console.Clear();
                    Console.WriteLine("ERROR");
                    Console.WriteLine(e.Message);   //Displays the exception
                    Console.WriteLine("Press Enter to continue");
                    Console.WriteLine();
                }
                /*  Input for obsolete data
                Console.WriteLine("Enter Venue");
                swimevents[i].EVenue = Console.ReadLine();  //User input for the events venue
                */
                Console.WriteLine("Enter Distance");
                swimevents[i].SDistance = Console.ReadLine();   //User input for the events distance

                Console.WriteLine("-Swimming Event Added, press enter to continue-");
                Console.ReadLine();

                Console.Clear();
            }
        }

        public static void displaySwimEvent()   //Method for display the swimming events entered into the array
        {
            Console.Clear();

            for (int i = 0; i < swimevents.Length; i++) //For loop, loops the the size of the swimming event array
            {
                try     //Try for exception in case the user runs the method while the array is empty
                {
                    Console.WriteLine("Name: " + swimevents[i].EName);
                    Console.WriteLine("Date and Time: " + swimevents[i].EDateAndTime);
                    Console.WriteLine("Fee: " + swimevents[i].EFee);
                    //Console.WriteLine("Venue: " + swimevents[i].EVenue);  Output for obsolete data
                    Console.WriteLine("Distance: " + swimevents[i].SDistance);
                    Console.WriteLine();
                }

                catch (Exception e) //displays error message
                {
                    Console.Clear();
                    Console.WriteLine("ERROR");
                    Console.WriteLine(e.Message);   //Displays the exception
                    Console.WriteLine("Press Enter to return to the menu");
                    Console.WriteLine();
                }
            }

            Console.ReadLine();

        }
        
        public static void addAthleteEvent()    //Method for adding an athlete to a list for an event
        {
            Console.Clear();

            Console.WriteLine("-Add an athlete to a list of events-");
            Console.WriteLine();

            for (int i = 0; i < athletes.Length; i++)  //For loop, loops the the size of the athlete array
            {
                try //Try for exception in case the user runs the method while the athlete array is empty
                {
                    Console.WriteLine("Number = " + i);
                    Console.WriteLine("First Name: " + athletes[i].AFName);
                    Console.WriteLine("Last Name: " + athletes[i].ALName);
                    Console.WriteLine();
                }

                catch (Exception e) //Displays the error
                {
                    Console.WriteLine();
                    Console.WriteLine("ERROR");
                    Console.WriteLine(e.Message);
                    Console.WriteLine();
                }

            }

            Console.WriteLine("Choose an Athlete");

            try     //Try for exception in case the user enters their choice in the wrong format
            {
                athleteChoice = Convert.ToInt32(Console.ReadLine()); //User input for choosing an athlete
            }

            catch (Exception e) //Displays the error
            {
                Console.WriteLine();
                Console.WriteLine("ERROR");
                Console.WriteLine(e.Message);
                Console.WriteLine();
            }

            Console.WriteLine("Choose what type of event");
            Console.WriteLine("1. Swimming Event");
            Console.WriteLine("2. Track Event");
            
            try     //Try for exception in case the user enters their choice in the wrong format
            {
                eventChoice = Convert.ToInt32(Console.ReadLine());  //User input for choosing the event type
            }

            catch (Exception e) //Displays the error
            {
                Console.WriteLine();
                Console.WriteLine("ERROR");
                Console.WriteLine(e.Message);
                Console.WriteLine();
            }

            if (eventChoice == 1)   //If the user chooses Swimming event
            {
                for (int i = 0; i < swimevents.Length; i++) //For loop, loops the the size of the swimming event array
                {
                    try     //Try for exception in case the user makes the choice while the array is empty
                    {
                        Console.WriteLine("Number = " + i);
                        Console.WriteLine("Name: " + swimevents[i].EName);
                        Console.WriteLine("Date and Time: " + swimevents[i].EDateAndTime);
                    }

                    catch (Exception e) //Displays the error message
                    {
                        Console.WriteLine();
                        Console.WriteLine("ERROR");
                        Console.WriteLine(e.Message);
                        Console.WriteLine();
                    }
                }

                try     //Try for exception in case the user makes their choice in the wrong format
                {
                    swimChoice = Convert.ToInt32(Console.ReadLine());   //User input for choosing the swimming event
                    swimevents[swimChoice].addAthletes(athletes[athleteChoice]); //Adds the chosen athlete to the list of athletes for the chosen event
                }

                catch (Exception e)     //Displays the error
                {
                    Console.Clear();
                    Console.WriteLine("ERROR");
                    Console.WriteLine(e.Message);
                    Console.ReadLine();
                }

                
            }

            else if (eventChoice == 2) //If the user chooses track events
            {
                for (int i = 0; i < trackevents.Length; i++) //For loop, loops the the size of the swimming event array
                {
                    try     //try for exception if the user makes the choice while the array is empty
                    {
                        Console.WriteLine("Number = " + i);
                        Console.WriteLine("Name: " + trackevents[i].EName);
                        Console.WriteLine("Date and Time: " + trackevents[i].EDateAndTime);
                    }

                    catch (Exception e) //Displays the error
                    {
                        Console.WriteLine();
                        Console.WriteLine("ERROR");
                        Console.WriteLine(e.Message);
                        Console.WriteLine();
                    }

                }

                try     //Try for exception in case the user enters their choice in the wrong format
                {
                    trackChoice = Convert.ToInt32(Console.ReadLine()); //User input for choosing a Track event
                    trackevents[trackChoice].addAthletes(athletes[athleteChoice]); //Adds the chosen athlete to the list of athletes for the chosen event
                    Console.WriteLine("Athlete added to list");
                }

                catch (Exception e) //Displays the error
                {
                    Console.Clear();
                    Console.WriteLine("ERROR");
                    Console.WriteLine(e.Message);
                }

                
            }
            
            Console.ReadLine();
        }

        public static void displayAthleteEvent()    //Method for display the athletes added to the list for each event
        {
            Console.Clear();

            Console.WriteLine("Track Events");

            try //Try for exception in case the user runs the method while the list or array is empty
            {
                for (int i = 0; i < trackevents.Length; i++) //For loop, loops the the size of the track event array
                {
                    trackevents[i].displayAthletes(); //Displays the athletes list for the track events
                    Console.WriteLine();
                }
            }

            catch (Exception e) //Displays the error
            {
                Console.WriteLine();
                Console.WriteLine("ERROR");
                Console.WriteLine(e.Message);
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Swimming Events");

            try //Try for exception in case the user runs the method while the list or array is empty
            {
                for (int i = 0; i < swimevents.Length; i++) //For loop, loops the the size of the swimming event array
                {
                    swimevents[i].displayAthletes(); //Displays the athletes list for the swimming events
                    Console.WriteLine();
                }

            }
            
            catch (Exception e) //Display error
            {
                Console.WriteLine();
                Console.WriteLine("ERROR");
                Console.WriteLine(e.Message);                
                Console.WriteLine();
            }

            Console.ReadLine();
        }
        
        public static void addVenueEvent()  //Method for adding an event to a list for a venue
        {
            Console.Clear();

            Console.WriteLine("-Add an event to a list of venues-");
            Console.WriteLine();

            for (int i = 0; i < venues.Length; i++) //For loop, loops the the size of the venue array
            {
                try     //Try for exception in case the user runs the method while the array is empty
                {
                    Console.WriteLine("Number = " + i);
                    Console.WriteLine("Venue Name: " + venues[i].VName);
                    Console.WriteLine("Venue Address: " + venues[i].VAddress);
                    Console.WriteLine();
                }

                catch (Exception e) //Displays error
                {
                    Console.WriteLine();
                    Console.WriteLine("ERROR");
                    Console.WriteLine(e.Message);
                    Console.WriteLine();
                }

            }

            try //Try for exception in case the user enters a choice in an invalid format
            {
                Console.WriteLine("Choose a Venue");
                venueChoice = Convert.ToInt32(Console.ReadLine()); //user input for venue
            }
            catch (Exception e) //Displays error
            {
                Console.WriteLine();
                Console.WriteLine("ERROR");
                Console.WriteLine(e.Message);
                Console.WriteLine();
            }

            Console.WriteLine("Choose what type of event");
            Console.WriteLine("1. Swimming Event");
            Console.WriteLine("2. Track Event");

            try //Try for exception in case the user enters a choice in an invalid format
            {
                eventChoice = Convert.ToInt32(Console.ReadLine()); //User input for choice of type of event
            }

            catch (Exception e) //Displays Error
            {
                Console.WriteLine();
                Console.WriteLine("ERROR");
                Console.WriteLine(e.Message);
                Console.WriteLine();
            }

            if (eventChoice == 1) //If the user chooses swimming event
            {
                for (int i = 0; i < swimevents.Length; i++) //For loop, loops the the size of the swimming event array
                {
                    try //Try for exception in case the user makes the choice while the array is empty
                    {
                        Console.WriteLine("Number = " + i);
                        Console.WriteLine("Name: " + swimevents[i].EName);
                        Console.WriteLine("Date and Time: " + swimevents[i].EDateAndTime);
                    }

                    catch (Exception e) //Display error
                    {
                        Console.WriteLine();
                        Console.WriteLine("ERROR");
                        Console.WriteLine(e.Message);
                        Console.WriteLine();
                    }

                }

                try //Try for exception in case the user enters a choice in an invalid format
                {
                    swimChoice = Convert.ToInt32(Console.ReadLine());   //User input for swimming event choice
                }

                catch (Exception e) //Display error
                {
                    Console.WriteLine("ERROR");
                    Console.WriteLine(e.Message);
                }

                venues[venueChoice].addEvent(swimevents[swimChoice]); //Adds the chosen event to the list of events for the chosen venue

            }

            else if (eventChoice == 2) //If the user chooses track event
            {
                for (int i = 0; i < trackevents.Length; i++)    //For loop, loops the the size of the track event array
                {
                    try     //Try for exception in case the user makes the choice while the array is empty
                    {
                        Console.WriteLine("Number = " + i);
                        Console.WriteLine("Name: " + trackevents[i].EName);
                        Console.WriteLine("Date and Time: " + trackevents[i].EDateAndTime);
                    }

                    catch (Exception e) //Display error
                    {
                        Console.WriteLine();
                        Console.WriteLine("ERROR");
                        Console.WriteLine(e.Message);
                        Console.WriteLine();
                    }

                }

                try     //try for exception in case the user enters a choice in an invalid format
                {
                    trackChoice = Convert.ToInt32(Console.ReadLine()); //User input for track even choice
                }

                catch (Exception e)
                {
                    Console.WriteLine("ERROR");
                    Console.WriteLine(e.Message);
                }
                venues[venueChoice].addEvent(trackevents[trackChoice]); //Adds the chosen event to the list of events for the chosen venue
            }
        }

        public static void displayVenueEvent()  //Method for displaying the events added to the list for each venue
        {
            Console.Clear();

            try     //Try for exception in case the user runs the method while the list is empty
            {
                for (int i = 0; i < venues.Length; i++) //Loops for the legnth of the venues array
                {
                    venues[i].displayEvent();   //Displays the events list for the venue
                    Console.WriteLine();
                }
            }

            catch (Exception e) //Display error message
            {
                Console.WriteLine();
                Console.WriteLine("ERROR");
                Console.WriteLine(e.Message);
                Console.WriteLine();
            }

            Console.ReadLine();

        }
        
        static void Main(string[] args)
        {
            do //Loops
            {
                displayMenu(); //Displays the menu method

                if (Choice == 1)    //If the user chooses option 1
                {
                    addAthlete(); //Runs the method for adding the athletes
                }

                if (Choice == 2) //If the user chooses option 2

                {
                    displayAthlete(); //Runs the method for displaying the athletes
                }

                if (Choice == 3) //If the user chooses option 3
                {
                    addVenue(); //Runs the method for adding the venues
                }

                if (Choice == 4) //If the user chooses option 4
                {
                    displayVenue(); //Runs the method for displaying the venues
                }

                if (Choice == 5) //If the user chooses option 5
                {
                    addTrackEvent(); //Runs the method for adding the track events
                }

                if (Choice == 6) //If the user chooses option 6
                {
                    displayTrackEvent(); //Runs the method for displaying the track events
                }

                if (Choice == 7) //If the user chooses option 7
                {
                    addSwimEvent(); //Runs the method for adding a swimming event
                }

                if (Choice == 8) //If the user chooses option 8
                {
                    displaySwimEvent(); //Runs the method for displaying t he swimming events
                }

                if (Choice == 9) //If the user chooses option 9
                {
                    addAthleteEvent(); //Runs the method for adding an athlete to a list
                }

                if (Choice == 10) //If the user chooses option 10
                {
                    displayAthleteEvent(); //Runs the method for displaying the athletes added to a list
                }

                if (Choice == 11) //If the user chooses option 11
                {
                    addVenueEvent(); //Runs the method for adding an event to a list
                }

                if (Choice == 12) //If the user chooses option 12
                {
                    displayVenueEvent(); //Runs the method for displaying the events added to a list
                }

            } while (Choice != 13); //Loops until the user chooses option 13             
        }   
    }
}
