using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Spel
{
    // av Harald Salén och Theodor Brandt
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
                if (nextEvent == null)
                {
                    continue;
                }
                currentEvent = eventHandler.getEventWithThisName(nextEvent);
                Console.Clear();
            }
        }

        private static string getAnswerFromQuestion()
        {
            string answer;
            do
            {
                
                Console.Clear();
             
                writeS("\n********************************************************************************");
                writeS("\n\tPlats: " + currentEvent.name + "\n");
                writeS(currentEvent.toString());

                writeS("\n********************************************************************************\n ");
                answer = Console.ReadLine();
            } while (!isCorrectAnswer(answer));
            return answer;
        }

        private static bool isCorrectAnswer(string answer)
        {
            if (answer == currentEvent.getAnswer1Number())
            {
                
                return true;
            }
            if (answer == currentEvent.getAnswer2Number())
            {
                return true;
            }
            if (answer == currentEvent.getAnswer3Number())
            {
                return true;
            }
            Console.WriteLine("isCorrectAnswer: ERROR");
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

