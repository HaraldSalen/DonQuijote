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
               "Välkommen riddare! Det är dags att börja ditt äventyr som Don Quijote, välj din karaktär...",//question
               "1. Harald",    //svar1
               "Harald",//eventname1
               "2. Theodor",   //svar2
               "Theodor"); //eventname2
            allEvents.Add("start", ev);

            ev = new Event(
                "Start", //name
                "Efter timmtals läsande och sömnlösa nätter inser du att du vill bli en riddare. Med din nya kunskap och djupa insikter måste du bege dig ut i världen för att skipa rättvisa eftersom du ju är en riddare. Du utrustar dig med en gammal rostig rustning, lans, svärd samt en rund liten träsköld. ",//question
                "1. Fortsätt",    //answer1
                "Första resan");//eventname1
            allEvents.Add("Harald", ev);

            ev = new Event(
                 "Första resan", //name
                 "Du sadlar din magra och eländiga häst Rosiante och beger dig ut i världen, i smyg så att din hushållerska och systerdotter inte skall kunna hindra dig. Innan du kan åta dig några ridderliga bedrifter är du tvungen att dubbas till riddare. Du beger dig mot borgen i ytterkanten av byn, där skall du be borgsherren dubba dig till riddare.",//question
                 "1. Fortsätt",    //answer1
                 "Värdshus");//eventName1
            allEvents.Add("Första resan", ev);

            ev = new Event(
               "Värdshuset", //name
               "Alonso kommer fram till ett värdshus där han ber värdshusherren dubba honom till riddare. Han går med på att dubba dig och alla i värdshuset spelar med, även två flickor som Alonso tror är adelsdamer. \nEn riddare som du behöver en dam att beundra på avstånd, det är till denna dams ära du utför dina bedrifter. Du väljer flickan Dulcinea från den närliggande byn El Tobso. \nEfter dubbningsritualen sätter du dig på din häst och beger dig ut i världen, denna gång som riddare! Du rider iväg i galopp mot den närliggande byn... ",
                //               "Alonso kommer fram till ett värdshus där han ber värdhusherren dubba honom till riddare, han går med på att dubba dig och alla i värdhuset spelar med, även två flickor som Alonso tror är adeldamer.\nEn riddare som du behöver ha en dam att  beundra på avstånd, det är till denna dams ära du utför dina bedrifter. Du väljer Dulcinea från den närliggande byn El Tobso.\nEfter dubbningsritualen sätter du dig på din häst och begär dig iväg ut i världen, denna gång som en riddare. Du rider iväg i galopp mot den närliggande byn… ",//question
               "1. Lapíce",    //svar1
               "Lapíce",//eventname1
               "2. Montiel",   //svar2
               "Montiel"); //eventname2
            allEvents.Add("Värdshus", ev);

            ev = new Event(
              "Lapíce", //name
              "Du ser en ung pojke fastbunden vid ett träd som blir piskad av sin husbonde. Du vill rädda pojken så du går närmare och pratar med husbonden. Han förklarar att vallpojken har struntat sin plikt att vakta fåren och dessutom hade modet att be om sin lön. Du väljer att:",//question
              "1. Betala bonden för att släppa pojken.",    //svar1
              "Lapíce1",//eventname1
              "2. Prata förnuft med bonden.",   //svar2
              "Lapíce2",//eventname2
              "3. Konfrontera bonden med hot av våld.",//svar3
              "Lapíce3"); //eventname3
            allEvents.Add("Lapíce", ev);


            ev = new Event(
              "Lapíce", //name
              "Du gav bonden några guldmynt, sedan släppte han pojken fri. Nöjd och belåten efter händelsen rider du vidare mot hembyn.",//question
              "1. Fortsätt", //svar1
              "Hembyn");//eventname1
            allEvents.Add("Lapíce1", ev);

            ev = new Event(
              "Lapíce", //name
              "Du berättar för honom att det inte är hövligt att ge sig på en som inte kan försvara sig. Bonden lossar sedan repen. Du vänder ryggen till och kliver upp hästen, bonden fortsätter sedan att ge sig på pojken utan din vetskap. Nöjd och belåten efter händelsen rider du vidare mot hembyn.",//question
               "1. Fortsätt", //svar1
              "Hembyn");//eventname1
            allEvents.Add("Lapíce2", ev);

            ev = new Event(
              "Lapíce", //name
              "Du konfronterar bonden och hotar med att använda ditt svärd emot honom. Bonden är förnuftig och släpper pojken, dessutom ger han dig några guldmynt och lovar att inte vara till något besvär i framtiden. Nöjd och belåten efter händelsen rider du vidare mot hembyn.",//question
               "1. Fortsätt", //svar1
              "Hembyn");//eventname1
            allEvents.Add("Lapíce3", ev);

            ev = new Event(
              "Montiel", //name
              "Du kommer fram till en liten by med inte mer än några hundra invånare. Det verkar inte som om denna by är i något behov av hjälp från någon modig och heroisk riddare som du. Du beger dig hemåt igen.",//question
              "1. Fortsätt ", //svar1
              "Vägskäl"); //eventname1
            allEvents.Add("Montiel", ev);

            ev = new Event(
              "Vägskäl", //name
              "Du stöter på ett vägskäl med två vägar, den ena leder tillbaka till hembyn. En riddare väljer alltid rätt väg, det gör du naturligtvis också. Du tänker på alla berättelser där riddarna stannar för att välja den rätta vägen - den som leder dom vidare i äventyret. Vad gör du?",//question
              "1. Du chansar och väljer en väg som du tror leder dig hem.", //svar1
              "Lapíce",//eventname1
              "2. Du släpper tyglarna och låter Rosiante välja vägen åt dig, i hopp om att hon galoperar iväg hem till stallet.",   //svar2
              "Hembyn"); //eventname2
            allEvents.Add("Vägskäl", ev);

            ev = new Event(
              "Hembyn", //name
              "Du möter tre affärsmen som inte erkänner Dulcineas gudomliga skönhet. Du blir rasande och väljer att:",//question
              "1. Slåss mot dem.", //svar1
              "SanchoPanza",//eventname1
              "2. Gå därifrån med rask takt hemåt.",//svar2
              "tillbakaHem"); //eventname2
            allEvents.Add("Hembyn", ev);

            ev = new Event(
              "Hemma hos Sancho Panza", //name
              "Du blir hårt slagen av affärsmännen och tvingas ta hjälp av en granne Sancho Panza. Du rider hem på hans åsna där du får återhämta dig. Medan du återhämtar sig tvingas han du på när din hushållerska och stadens präst bränner upp alla dina böcker som du har läst om riddarlighet, i hopp om att avskräcka dig om ditt uppdrag om att visa din riddarlighet. Detta gör dig bara mer fastställd på ditt uppdrag.",//question
              "1. Leta efter en väpnare.", //svar1
              "LetaVäpnare"); //eventname1
            allEvents.Add("SanchoPanza", ev);

            ev = new Event(
              "Hemma", //name
              "Du kommer hem och blir välkommnad av din hushållerska och din systerdotter, du får även höra att Rosiante är väbehållen hemma i stallet.\nDu bestämmer dig för att rida iväg på en till resa men du behöver hjälp av någonsom kan följa med på dina äventyr.",//question
              "1. Leta efter en väpnare.", //svar1
              "LetaVäpnare"); //eventname1
            allEvents.Add("tillbakaHem", ev);

            ev = new Event(
              "Hembyn", //name
              "Du frågar du din snälla granne Sancho om han vill vara din väpnare och följa med under nästa resa. Han svarar att han gärna vill hjälpa till för en mindre ersättning: en egen ö.\nSancho är enfaldig och tror på ditt löfte och lovar att följa med som din väpnare under dina resor.",//question
              "1. Sadla upp på hästen och bege dig ut på nästa resa tillsammans med din nya väpnare Sancho.", //svar1
              "resa2"); //eventname1
            allEvents.Add("LetaVäpnare", ev);

            ev = new Event(
              "Striden mot väderkvarnarna", //name
              "Du har inte hunnit långt innan du ser ditt nästa hinder, du kan knappt tro dina ögon hur stora dem är, Sancho förstår inte vad du menar när du skriker “Det är minst trettio av dem där framme!”, “Trettio av vad?”, svarar Sancho. “Jättar så klart”, säger du. Sancho påpekar att det inte ser ut att vara jättar utan väderkvarnar.",//question
              "1.Du väljer att galoppera mot väderkvarna i full fart bakom din trösköld med lansen stödd.", //svar1
              "strid1",//eventname1
              "2. Du inser att fienderna är för många och vänder hemåt istället.",   //svar2
              "strid2"); //eventname2
            allEvents.Add("resa2", ev);

            ev = new Event(
              "Striden mot väderkvarnarna", //name
              "Du blir spetsad av vingen och flyger genom luften och landar svårt skadad, för att inte tala om Rosiante som tog det mesta av träffen",//question
              "1. Fortsätt", //svar1
              "Slut"); //eventname1
            allEvents.Add("strid1", ev);

            ev = new Event(
              "Striden mot väderkvarnarna", //name
              "Du inser att riddarlivet kanske inte var för dig och rider hemåt.",//question
              "1. Fortsätt", //svar1
              "Slut"); //eventname1
            allEvents.Add("strid2", ev);


            ev = new Event(
              "Slut", //name
              "Tack för att du spelade tappra riddare!",//question
              "", //svar1
              ""); //eventname1
            allEvents.Add("Slut", ev);
        }
        /*
            ev = new Event(
              "", //name
              "",//question
              "1. ", //svar1
              ""); //eventname1
            allEvents.Add("", ev);

            ev = new Event(
              "", //name
              "",//question
              "1. ", //svar1
              "",//eventname1
              "2. ",   //svar2
              ""); //eventname2
            allEvents.Add("", ev);

            ev = new Event(
              "", //name
              "",//question
              "1. ", //svar1
              "",//eventname1
              "2. ",    //svar2
              "",//eventname2
              "3. ",   //svar3
              ""); //eventname3
            allEvents.Add("", ev);

            ev = new Event(
               "Namn på eventet", //name
               "text + fråga",//question
               "1. Svarsalternativ 1",    //svar1
               "Event som svar1 leder till",//eventname1
               "2. Svarsalternativ 2",   //svar2
               "Event som svar2 leder till"); //eventname2
            allEvents.Add("Namn på eventet", ev);
            
        }*/
         
        
        //find event with this name
        public Event getEventWithThisName(string name)
        {
            Event e = (Event)allEvents[name];
            if (e == null)
            {
                writeS("Found no event with name"+name);
            }
            //Console.WriteLine("ev=" + e);
            return e;
        } 
        private static void writeS(string text)
        {
            Console.WriteLine(text);
        }
    }

}

