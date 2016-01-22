using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace Spel
{
    class Event
    {

        public static int mynt = Globals.guldmynt;
        public string name;
        public string question;
        public string answer1;
        public string eventName1;
        public string answer2;
        public string eventName2;
        public string answer3;
        public string eventName3;
        public string answer4;
        public string eventName4;




        // constructor som skapar ett object av denna klass:
        public Event(
            string name,
            string question,
            string answer1,
            string eventName1,
            string answer2,
            string eventName2,
            string answer3,
            string eventName3
            )
        {
            this.name = name;
            this.question = question;
            this.answer1 = answer1;
            this.eventName1 = eventName1;
            this.answer2 = answer2;
            this.eventName2 = eventName2;
            this.answer3 = answer3;
            this.eventName3 = eventName3;

        }

        public Event(
            string name,
            string question,
            string answer1,
            string eventName1,
            string answer2,
            string eventName2
            )
        {
            this.name = name;
            this.question = question;
            this.answer1 = answer1;
            this.eventName1 = eventName1;
            this.answer2 = answer2;
            this.eventName2 = eventName2;

        }

        public Event(
            string name,
            string question,
            string answer1,
            string eventName1,
            string answer2,
            string eventName2,
            string answer3,
            string eventName3,
            string answer4,
            string eventName4
            )
        {
            this.name = name;
            this.question = question;
            this.answer1 = answer1;
            this.eventName1 = eventName1;
            this.answer2 = answer2;
            this.eventName2 = eventName2;
            this.answer3 = answer3;
            this.eventName3 = eventName3;
            this.answer4 = answer4;
            this.eventName4 = eventName4;
        }
            
        
        public string getNextEvent(string answer)
        {
            if (answer == answer1)
            {
                return eventName1;
            }

            if (answer == answer2)
            {
                return eventName2;
            }
            if (answer == answer3)
            {   
                
                return eventName3;
            }
            
                return "hittade inget event";
            
        }   
    }



    /*

    public ArrayList getAcceptedAnswers() 
    {
        return null;
    }

    public Event getEventFor(string answer)
    {
        if (answer.Equals("Y"))
        {
            return new Event("next");
        }
        return null; // inte klart
    }

    private static void write(string text)
    {
        Console.WriteLine(text);
    }*/
}

