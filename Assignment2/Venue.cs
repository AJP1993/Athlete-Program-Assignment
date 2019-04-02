using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Venue //Class for venues
{
    private string venueName;       //String for venue name
    private string venueAddress;    //String for venue address

    private List<Event> events = new List<Event>(); //List of events for the venue

    public void addEvent(Event e)   //Method for adding an event to the list
    {
        events.Add(e);  //Adds event to list
    }

    public void displayEvent()      //Method for displaying the events in the list
    {
        foreach (Event e in events)
        {
            Console.WriteLine("Event name: " + e.EName);
            Console.WriteLine("Event Date and time: " + e.EDateAndTime);
            Console.WriteLine("Event fee: " + e.EFee);
            //Console.WriteLine("Event venue: " + e.EVenue);    Obsolete data
        }
    }

    public string VName //Property for venue name
    {
        get //Gets the venue name
        {
            return venueName;
        }

        set //Sets the venue name
        {
            venueName = value;
        }
    }

    public string VAddress  //Property for venue address
    {
        get //Gets venue address
        {
            return venueAddress;
        }

        set //Sets venue address
        {
            venueAddress = value;
        }
    }
}
