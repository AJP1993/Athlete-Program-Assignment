using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class SwimmingEvent:Event   //Class for swimming events, inherits the Event class
{
    private string swimDistance;    //String for swimming event distance

    public string SDistance //Property for swimming event distance
    {
        get //Gets the event distance
        {
            return swimDistance;
        }

        set //Sets the event distance
        {
            swimDistance = value;
        }
    }
}
