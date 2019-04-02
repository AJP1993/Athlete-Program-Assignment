using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Athlete   //Class for Athletes
{
    private string athleteFName;    //String for Athlete's first name
    private string athleteLName;    //String for Athlete's last name
    private string athleteAddress;  //String for Athlete's Address
    private string athletePhonenumber;  //String for Athlete's phone number
    //private string athleteParticipate;  Obsolete String for Athlete's Event
    

    public string AFName    //Property for Athlete's first name
    {
        get //Gets the first name
        {
            return athleteFName;
        }

        set //Sets the first name
        {
            athleteFName = value;
        }
    }

    public string ALName    //Property for Athlete's last name
    {
        get //Gets the last name
        {
            return athleteLName;
        }

        set //Sets the last name
        {
            athleteLName = value;
        }
    }

    public string AAddress  //Property for the Athlete's address
    {
        get //Gets the address
        {
            return athleteAddress;
        }

        set //Sets the address
        {
            athleteAddress = value;
        }
    }

    public string APhonenumber  //Property for the Athlete's phone number
    {
        get //Gets the phone number
        {
            return athletePhonenumber;
        }

        set //Sets the phone number
        {
            athletePhonenumber = value;
        }
    }

    /*  Obsolete property
    public string AParticipate  //Property for the Athlete's event
    {
        get //Gets the event
        {
            return athleteParticipate;
        }

        set //Sets the event
        {
            athleteParticipate = value;
        }
    }
     */ 
}

