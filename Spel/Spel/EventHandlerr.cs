using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Spel
{
    class EventHandlerr
    {

        Hashtable allEvents = new Hashtable();


        public EventHandlerr()
        {
            createAllEvents();
        }

        public void createAllEvents()
        {
            Event ev = null;

            ev = new Event(
                "start", //name
                "Du står vid en grotta vad gör du?\n1. Går in\n2. Spring till flygplatsen",
                "1",    //svar1
                "Grottan",
                "2",   //svar2
                "flygplatsen");
            allEvents.Add("start", ev);

            ev = new Event(
               "flygplatsen", //name
               "Du står vid en flygplats vad gör du?\n1. Går in\n2. Stanna\n3. <Gå tillbaka>", //question
               "1", //option1
               "flygplanet", //event1
               "2", //option 2
               "Utanfor flygplatsen", //event2
               "3", //option 3
               "start"); //event 3
            allEvents.Add("flygplatsen", ev);

            ev = new Event(
               "Utanfor flygplatsen", //name
               "Du står utanför en flygplats vad gör du?\n1. Går in\n2. Stanna\n3. Springa", //question
               "1", //option1
               "flygplanet", //event1
               "2", //option 2
               "Utanför flygplatsen", //event2
               "3", //option 3
               "Havet"); //event 3
            allEvents.Add("Utanfor flygplatsen", ev);

            ev = new Event(
               "Havet", //name
               "Du är mitt i öppna havet vad gör du?\n1. Simmar\n2. Stanna\n3. Springa\n4. <gå tillbaka>", //question
               "1", //option1
               "Öde ö", //event1
               "2", //option 2
               "Drunkna", //event2
               "3", //option 3
               "Sjunka", //event3
               "4", //option 4
               "start"); //event 4

            allEvents.Add("Havet", ev);
        }
        
        
        //find event with this name
        public Event getEventWithThisName(string name)
        {
            Event e = (Event)allEvents[name];
            //Console.WriteLine("ev=" + e);
            return e;
        }


    }

}

