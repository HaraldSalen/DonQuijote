using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Spel
{
    class Program
    {
        public static EventHandlerr eventHandler = new EventHandlerr();
        public static Event currentEvent = eventHandler.getEventWithThisName("start");

        public static int mynt = Globals.guldmynt;
       


        static void Main(string[] args)
        {
            
            Console.WriteLine("###### START");
            currentEvent = eventHandler.getEventWithThisName("start");
            while (true)
            {
                writeS("Antal guldmynt: " + mynt);
                writeS("\n"+currentEvent.question);
                string answer = Console.ReadLine();
                string nextEvent = currentEvent.getNextEvent(answer);
                currentEvent = eventHandler.getEventWithThisName(nextEvent);
                
                mynt++;
                
            }
        }
        private static void writeS(string text)
        {
            Console.WriteLine(text);
        }
        private static void writeI(int tal)
        {
            Console.WriteLine(tal);
        }

        
    }
}

