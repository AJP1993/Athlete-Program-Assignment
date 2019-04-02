using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Event //Class for the values that are shared by both events
{
    private string eventName;           //String for event name
    private string eventDateAndTime;    //String for event date and time
    private double eventFee;            //Double for event fee  
    //private string eventVenue;          Obsolete String for event venue

    private List<Athlete> athletes = new List<Athlete>();   //List of athletes for the event

    public void addAthletes(Athlete a)  //Method for adding an athlete to the list
    {
        athletes.Add(a); //Adds athlete to list
    }

    public void displayAthletes()   //Method for diplaying the athletes in the list
    {
        foreach (Athlete a in athletes)
        {
            Console.WriteLine("First name: " + a.AFName);
            Console.WriteLine("Last name: " + a.ALName);
            Console.WriteLine("Address: " + a.AAddress);
            Console.WriteLine("Phone number: " + a.APhonenumber);
            //Console.WriteLine("Event: " + a.AParticipate); Obsolete data
        }
    }

    public string EName //Property for event's name
    {
        get //Gets the event name
        {
            return eventName;
        }

        set //Sets the event name
        {
            eventName = value;
        }
    }

    public string EDateAndTime  //Property for event's date and time
    {
        get //Gets the event date and time
        {
            return eventDateAndTime;
        }

        set //Sets the event date and time
        {
            eventDateAndTime = value;
        }
    }

    public double EFee  //Property for event's fee
    {
        get //Gets the event fee
        {
            return eventFee;
        }

        set //Sets the event fee
        {
            eventFee = value;
        }
    }
    /*  Obsolete property
    public string EVenue    //Property for the event's venue
    {
        get //Gets the event venue
        {
            return eventVenue;
        }

        set //Sets the event venue
        {
            eventVenue = value;
        }
    }
     */
}
    
