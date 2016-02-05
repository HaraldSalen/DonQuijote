using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace Spel
{
    class Event
    {
        public string name;
        public string question;
        public string answer1 = " ";
        public string eventName1;
        public string answer2 = " ";
        public string eventName2;
        public string answer3 = " ";
        public string eventName3;

        // constructor som skapar ett object av denna klass:
        public Event(
            string name,
            string question,
            string answer1,
            string eventName1,
            string answer2,
            string eventName2,
            string answer3,
            string eventName3)
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
            string eventName2)
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
            string eventName1)
        {
            this.name = name;
            this.question = question;
            this.answer1 = answer1;
            this.eventName1 = eventName1;
        }

        public string getNextEvent(string answer)
        {
            if (answer == getAnswer1Number())
            {
                return eventName1;
            }
            if (answer == getAnswer2Number())
            {
                return eventName2;
            }
            if (answer == getAnswer3Number())
            {
                return eventName3;
            }
            return "hittade inget event";
        }

        public string toString()
        {
            string text = fixLength(question) + "\n" + "\n" + answer1 + "\n";
            if (!String.IsNullOrEmpty(answer2))
            {
                text += answer2 + "\n";
            }
            if (!String.IsNullOrEmpty(answer3))
            {
                text += answer3 + "\n";
            }
            return text;
        }


        private int maxLength = 65;
        private string fixLength(string text)
        {
            string textLeft = text;
            string fixedText = "\t";
            while (textLeft.Length > 0)
            {
                string firstLine = getFirstLine(textLeft) + "\n";
                fixedText += firstLine;
                if (textLeft.Length > maxLength)
                {
                    textLeft = textLeft.Substring(firstLine.Length);
                }
                else
                {
                    break;
                }
            }
            return fixedText.Replace("\n", "\n\t");

        }

        private string getFirstLine(string text)
        {
            if (text.Length > maxLength)
            {
                string firstLine = "";

                string tempString = text.Substring(0, maxLength);
                int lastSpacePos = tempString.LastIndexOf(" ");
                firstLine = text.Substring(0, lastSpacePos);
                return firstLine;
            }
            return text;
            


        }
        public string getAnswer1Number()
        {
            return answer1.Substring(0, 1);

        }
        public string getAnswer2Number()
        {
            return answer2.Substring(0, 1);

        }
        public string getAnswer3Number()
        {
            return answer3.Substring(0, 1);

        }
    }
}