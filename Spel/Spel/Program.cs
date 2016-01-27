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



        static void Main(string[] args)
        {

            Console.WriteLine("###### START");
            currentEvent = eventHandler.getEventWithThisName("start");
            while (true)
            {
                
                
                string answer = getAnswerFromQuestion();
                string nextEvent = currentEvent.getNextEvent(answer);
                currentEvent = eventHandler.getEventWithThisName(nextEvent);
                Console.Clear();
                Globals.guldmynt++;

            }
        }

        private static string getAnswerFromQuestion()
        {
            string answer;
            do
            {
                
                if (currentEvent == null)
                {
                    writeS("current event == null");
                }
                Console.Clear();
                writeS("\n********************************************************************************");
                writeS("\n\t Plats: " + currentEvent.name + "\t Antal guldmynt: " + Globals.guldmynt + "\n");
                
                writeS("\n " + currentEvent.question);
                writeS("\n********************************************************************************\n ");
                answer = Console.ReadLine();
            } while (!isCorrectAnswer(answer));
            return answer;
        }

        private static bool isCorrectAnswer(string answer)
        {
            if (answer == currentEvent.answer1)
            {
                return true;
            }
            if (answer == currentEvent.answer2)
            {
                return true;
            }
            if (answer == currentEvent.answer3)
            {
                return true;
            }
            if (answer == currentEvent.answer4)
            {
                return true;
            }

            return false;

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

