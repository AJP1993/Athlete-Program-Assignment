using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class TrackEvent:Event  //Class for track events, inherits the Event class
{
    private string trackDistance;           //String for track event distance
    private string trackIndoorOrOutdoor;    //String for whether the track event is indoors or outdoors

    public string TDistance //Property for track event distance
    {
        get //Gets the event distance
        {
            return trackDistance;
        }

        set //Sets the event distance
        {
            trackDistance = value;
        }
    }

    public string TInOrOut  //Property for indoors or outdoors
    {
        get //Gets indoors or outdoors
        {
            return trackIndoorOrOutdoor;
        }

        set //Sets indoors or outdoors
        {
            trackIndoorOrOutdoor = value;
        }
    }
    
}

