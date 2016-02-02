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
               "1, 1"); //eventname2
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
                //               "Alonso kommer fram till ett värdshus där han ber värdhusherren dubba honom till riddare, han går med på att dubba dig och alla i värdhuset spelar med, även två flickor som Alonso tror är adeldamer.\n\n\n\nEn riddare som du behöver ha en dam att  beundra på avstånd, det är till denna dams ära du utför dina bedrifter. Du väljer Dulcinea från den närliggande byn El Tobso.\n\n\n\nEfter dubbningsritualen sätter du dig på din häst och begär dig iväg ut i världen, denna gång som en riddare. Du rider iväg i galopp mot den närliggande byn… ",//question
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
              "Du kommer hem och blir välkommnad av din hushållerska och din systerdotter, du får även höra att Rosiante är väbehållen hemma i stallet.\n\n\n\nDu bestämmer dig för att rida iväg på en till resa men du behöver hjälp av någonsom kan följa med på dina äventyr.",//question
              "1. Leta efter en väpnare.", //svar1
              "LetaVäpnare"); //eventname1
            allEvents.Add("tillbakaHem", ev);

            ev = new Event(
              "Hembyn", //name
              "Du frågar du din snälla granne Sancho om han vill vara din väpnare och följa med under nästa resa. Han svarar att han gärna vill hjälpa till för en mindre ersättning: en egen ö.\n\n\n\nSancho är enfaldig och tror på ditt löfte och lovar att följa med som din väpnare under dina resor.",//question
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
        
            
            ev = new Event(
              "Hemma", //name
              "Med hjälmen i din hand och klädd i din rustning betraktar du dig själv framför spegeln. “Tänka sig. Jag, Alonso Quijana, en riddare.” Du ser dig själv resandes över världens alla landskap, utför kungens hjältemodiga uppdrag, slåss mot vedervärdiga monster och räddar den stackars prinsessa som sitter fast i tornet på slottet som ligger blott i fjärran. Allt med din väpnare vid din sida. Men vänta lite nu. Väpnare? Just det, en riddare behöver en väpnare.",//question
              "1. Gå vidare", //svar1
              "1, 1, 1");//eventname1
            allEvents.Add("1, 1", ev);
    
        
            ev = new Event(
              "Trädgården", //name
              "Du lämnar ditt hushåll och stöter genast på din granne Sancho Panza. En vanlig landsbonde som för tillfället, precis som varje måndag, fraktar sin gödselvagn med hjälp av sin trogne åsna Rucio. Sancho får syn på dig och hälsar omedelbart.\n\n“God dagens Herr Quijana! Vad leder dig ut i en sådan prydlig utstyrsel.\n\n“Ja du käre granne, låt mig fråga dig. När var senast du såg en riddare bekämpa de faror som hotar vårt land?”\n\n“Nu ska vi se”, mumlar Sancho. tyst för sig självt. “För närvarande så befinner sig landets soldater lite överallt för att bekämpa Moriskerna, jag har hört rykten om uvisning men…”.\n\n“Nej!” avbryter Alonso. “Jag talar om jättar, chupacabra’s…”\n\n“Chupacabra’s?” frågar Sancho.\n\n“...drakar, harpyor...” Fortsätter Alonso.\n\nSancho avbryter, “Jag måste be om förlåtelse herr Quijana, men jag förstår inte riktigt…”\n\nAlonso är för inne i sina egna ord att han inte hör vad Sancho har att säga utan fortsätter.\n\n“Det är en sådan person jag talar om! Det är dags för mig att träda fram. Jag ska ut i världen och skydda den från dessa varelser och för detta behöver jag dig!”\n\nHäpnad hoppar Sancho av gödselkärran och tittar ner på marken framför Alonso. En vanlig person, hade sett igenom Alonsos besynnerliga tal. Men inte Sancho. Sancho tittar upp på Alonso igen, och med ett glatt leende och raska steg går han fram till Alonso. “Säg mig hern, vad behöver jag göra?”\n\n“Du behöver ett färdmedel. Visa mig ditt finaste städ!”\n\n“Frukta inte! Jag har min åsna Rucio, det trognaste djuret på fyra hovar.” Antyder Sancho.\n\n“Aldrig.” Yttrar Alonso. “Du får endast resa vid min sida när du funnit ett äkta städ!”\n\nLeendet försvinner från Sanchos mun. “Ett äkta städ!?” Utbrast Sancho. “En sådan oförnäm man såg jag ej i dig Quijana. Förbise att jag någonsin har kallat dig förr herr. Lycka till med att vandra på dessa vägar ensam.” Säger Sancho medans han hastigt vänder sig om och går tillbaka till vagnen, stampandes i marken.\n\nHäpnad står Alonso kvar med ett tomt ansikte. “Sade jag något dumt?” Frågade han sig själv när han tittar på Sancho som slår på åsnans häck med en pinne för att kvickt komma därifrån. Alonso ser Sancho snegla mot honom innan han vänder huvudet framåt och rider därifrån.\n\nAlonso sätter sig ned på trappstegen till hans hus och funderar på vad han ska göra härnäst.", //question
              "1. Gå in i huset och sätt dig i fåtöljen.", //svar1
              "1, 1, 1, 1",//eventname1
              "2. Rid efter Sancho.",   //svar2
              "1, 1, 1, 2", //eventname2
              "3. Sök efter någon annan som kan bli din väpnare.",
              "1, 1, 1, 3");
            allEvents.Add("1, 1, 1", ev);

            ev = new Event(
              "Hemma", //name
              "Alonso går in i sitt hushåll, tillbaka in i samlingssalen, sätter sig i fåtöljen och började tänka. “Vad var det jag sa som gjorde honom så upprörd? Är det här vem jag verkligen är som person? Jag kanske inte är menad att vara en riddare.”",//question
              "1. Ge upp.", //svar1
              "1, 1, 1, 1, 1",//eventname1
              "2. Rid efter Sancho.",    //svar2
              "1, 1, 1, 1, 2",//eventname2
              "3. Sök efter någon annan som kan bli din väpnare.",   //svar3
              "1, 1, 1, 1, 3"); //eventname3
            allEvents.Add("1, 1, 1, 1", ev);
        
            ev = new Event(
              "Hemma", //name
              "Alonso reser sig hastigt. “Jag kan inte låta denna beklagliga händelse komma åt mig. Jag får helt enkelt hitta någon annan som kan bli min väpnare! Jag kan inte jaga efter Sancho, det finns inte en chans att han kommer förlåta mig.” Tänker Alonso för sig självt medans han går till stallet och gör i ordning sin häst. “Jag har inte ridigt dig på länge, men nog ska jag dig allt kunna tygla!”\n\nHan rider iväg. Och för varje person han stöter på, vare det en handelsman, en bonde eller till och med en präst så håller han sitt tal, likt en predikan, för att övertyga dessa människor att följa med honom på sin resa. Men blir han inte endast nekad så blir han ignorerad, svuren åt eller till och med spottad på. 3 timmar har gått och Alonso börjar känna sig eländig ända in i själen.",//question
              "1. Rid tillbaka hem.", //svar1
              "1, 1, 1, 1, 3, 1",//eventname1
              "2. Rid hem till Sancho",   //svar2
              "1, 1, 1, 1, 3, 2"); //eventname2
            allEvents.Add("1, 1, 1, 1, 3", ev);

            ev = new Event(
              "Sanchos gård", //name
              "Alonso kvicknar till. “Jag kan inte låta det ta slut här. Ger en äkta riddare någonsin upp, oavsett vilken situation den är i?”. Alonso ger hans häst en spark, hästen ger ut ett stort gnägg innan den sätter fart mot Sanchos bondgård.\n\nSolen rör redan vid horisonten när han är framme vid Sanchos gård. Sancho själv, som ständigt arbetar med plantaget ser honom, ställer sig upp och avvaktar lutandes mot sin spade.",//question
              "1. Hoppa av din häst, gå försiktigt över plantaget fram till Sancho och be om förlåtelse.", //svar1
              "1, 1, 1, 1, 3, 2, 1",//eventname1
              "2. Hoppa av, klampa över det nyplanterade vetet och fråga Sancho om han har en häst redo.",   //svar2
              "1, 1, 1, 1, 3, 2, 2"); //eventname2
            allEvents.Add("1, 1, 1, 1, 3, 2", ev);

            ev = new Event(
              "Sanchos gård", //name
              "Alonso går fram till bonden och ställer sig ned på knä med ansiktet ned. “Jag ber om ursäkt, Sancho. Jag var ytterst oförskämd och skulle inte ha yttrat det jag yttrat. Kan jag med ditt tillstånd få en ny chans att be dig följa med mig ut i…”\n\nSancho avbryter honom. “Säg inget mer.”. Alonso tittar upp. Det breda leendet på Sanchos mun är tillbaka. “Där är mannen jag kallar herr.” fortsätter Sancho. Alonso reser sig upp, putsar av sin rustning och harklar sig. “Förbered Rucio, vi ska påbörja vår resa omedelbart!”\n\n“Självfallet Herr Quijana!” Svarar Sancho medans han börjar titta underligt på Alonso. “Säg mig Herr Quijana, vad heter din häst?”. \n\n“Hon…” Alonso avbryter sig själv, “Jag har än inte givit henne något namn.”. Alonso vänder sig mot hästen i fråga och tänker. “Rocín...Ante...där har vi det, Rosinante! Och för mig själv…”\n\n“Dig själv?” Frågar Sancho underligt.\n\n“För att bli riddare så behöver jag gå vid en riddares namn! Alonso Quijana är inte ridderligt nog.”. Efter en tids tänkande så har Alonso bestämt sig. “Don Quijote får det bli. Don Quijote av La Mancha!”.\n\n“Ett fint namn på en vacker häst och ett ståtligt namn för en modig riddare.” Antyder Sancho medans han bugar för Alonso. “Vart planerar du att färdas Sir. Quijote?”.\n\nDen självkrönte riddaren ler glatt till hans nya titel.",//question
              "1. “Låt oss rida till mitt hushåll, jag måste säga farväl till de som har tagit hand om mig i alla dessa år.”", //svar1
              "1, 1, 1, 1, 3, 2, 1, 1",//eventname1
              "2. “Se till att du får med dig allt du behöver. Vi låter stigen leda oss",   //svar2
              "1, 1, 1, 1, 3, 2, 1, 2"); //eventname2
            allEvents.Add("1, 1, 1, 1, 3, 2, 1", ev);

            ev = new Event(
              "Ridandes", //name
              "De två rider mot Don Quijotes hushåll. Väl där överlåter han huset och hans ägodelar att tas hand av gårdsdrängen medans han är borta, han säger farväl till gårdsdrängen, hans systerdotter och hushållerskan innan han gör sig redo för att bege sig iväg. Med sig tar han den sköld och den lans som samlat damm på vinden tillsammans med ett exalterat sinne.\n\n“Låt oss rida iväg.” Säger han till Sancho med huvudet högt upp i skyn medans de två lämnar deras liv bakom sig för att ge sig ut..\n\nHär börjar riddaren och hans väpnares livs resa.\n\n>> Slut <<",//question
              "1. Avsluta.", //svar1
              "Slut"); //eventname1
            allEvents.Add("1, 1, 1, 1,, 3, 2, 1, 1", ev);

            ev = new Event(
              "Ridandes", //name
              "De båda beger sig iväg mot solnedgången med deras huvuden högt upp i skyn.\n\nHär börjar riddaren och hans väpnares livs resa.\n\n>> Slut <<",//question
              "1. Avsluta.", //svar1
              "Slut"); //eventname1
            allEvents.Add("1, 1, 1, 1, 3, 2, 1, 2", ev);

            ev = new Event(
              "Sanchos gård", //name
              "Sanchos stela ansikte blir mer ilsket för varje steg Alonso tar.\n\n“Har du ändrat dig?” frågar Alonso med en prydlig röst som får Sanchos ansikte att bli röd av ilska.\n\n“Lämna min gård.” Yttrar Sancho som försöker hålla lugnet.\n\n“Jag tror inte att du förstår, jag behöver en väpnare.” Säger Alonso, återigen med en prydlig röst.\n\nSancho lyfter sin spade. “Jag tror inte att du förstår, jag vill inte ha någonting att göra med dig och din resa. Vänd dig om, ta din häst och lämna min åsyn.” \n\nAlonso vänder sig om. “Det är iallafall en häst, du kan väl skicka ett brev när du har skaffat dig ett riktigt städ.”\n\nAlonso hinner endast ta sitt första steg innan han hör Sanchos spade vissla genom luften. Med ett sista andetag sipprar livet ur Alonso medans blodet göder det nyplanterade vetet.\n\n>> Slut <<",//question
              "1. Avsluta.", //svar1
              "Slut"); //eventname1
            allEvents.Add("1, 1, 1, 1, 3, 2, 2", ev);

            ev = new Event(
              "Ridandes", //name
              "Alonso vänder på sin häst och börjar trava hem. Nedlåten som han nu är så tar han sig inte an att tala med folket som han möter utan tillbringar sin tid i tankarnas värld tills han har nått sitt stall. Där låter han hushållets dräng ta hand om hästen medans han går in i huset och sätter sig i sin fåtölj. Alonso börjar snegla ut mot fönstret där solen börjar närma sin nedgång.",//question
              "1. Ge upp.", //svar1
              "1, 1, 1, 1, 3, 1, 1",//eventname1
              "2. Rid hem till Sancho",   //svar2
              "1, 1, 1, 1, 3, 1, 2"); //eventname2
            allEvents.Add("1, 1, 1, 1, 3, 1", ev);

            ev = new Event(
              "Hemma", //name
              "Den å så tappre riddaren sjunker ner i sin fåtölj. “Nåväl, jag har iallafall mina riddarromaner.” Suckar Alonso Quijana, mannen som fick leva som riddare för en dag.\n\n>> Slut <<",//question
              "1. Avsluta.", //svar1
              "Slut"); //eventname1
            allEvents.Add("1, 1, 1, 1, 3, 1, 1", ev);
        
            ev = new Event(
              "Hemma", //name
              "Alonso kvicknar till. “Jag kan inte låta det ta slut här. Ger en äkta riddare någonsin upp, oavsett vilken situation den är i?”. Alonso kastar sig upp och tar, med sina snabbaste fotsteg, sig ut ur sitt hus och mot stallet som gårdsdrängen precis ska lämna. “Bind lös hästen dräng, jag ska iväg på min livs resa!”. Gårdsdrängen slår hakan mot bröstet och går in i stallet igen. När vår riddare sitter på hästen så ger han ingen tvekan innan han rider iväg. “Det är inte över än!” Tänker Alonso högt i sitt huvud.\n\nSolen rör redan vid horisonten när han är framme vid Sanchos gård. Sancho själv, som ständigt arbetar med plantaget ser honom, ställer sig upp och avvaktar lutandes mot sin spade.",//question
              "1. Hoppa av din häst, gå försiktigt över plantaget fram till Sancho och be om förlåtelse.", //svar1
              "1, 1, 1, 1, 3, 1, 2, 1",//eventname1
              "2. Hoppa av, klampa över det nyplanterade vetet och fråga Sancho om han har en häst redo.",   //svar2
              "1, 1, 1, 1, 3, 1, 2, 2"); //eventname2
            allEvents.Add("1, 1, 1, 1, 3, 1, 2", ev);

            ev = new Event(
              "Hemma", //name
              "Alonso sjunker ner i sin fåtölj. “Nåväl, jag har iallafall mina riddarromaner.” Suckar han och öppnar nästa bok som står i hans hylla.\n\n>> Slut <<",//question
              "1. Avsluta.", //svar1
              "Slut"); //eventname1
            allEvents.Add("1, 1, 1, 1, 1", ev);

            ev = new Event(
              "Hemma", //name
              "Alonso kvicknar till. “Jag kan inte låta det ta slut här. Ger en äkta riddare någonsin upp, oavsett vilken situation den är i?”. Alonso kastar sig upp och tar, med sina snabbaste fotsteg, sig ut ur sitt hus och mot stallet som gårdsdrängen precis ska lämna. “Bind lös hästen dräng, jag ska iväg på min livs resa!”. Gårdsdrängen lyder Alonsos order och tar ut hästen ur stallet. “Det är inte över än!” Tänker Alonso högt i sitt huvud.\n\nAldrig har vår riddare ridigt så här snabbt innan, han lyckas möta Sancho halvvägs till hans bondgård och ber honom att stanna.\n\nSancho tittar på Alonso med ett känslolöst ansiktsuttryck och avvaktar vad Alonso har att säga.",//question
              "1. Be Sancho om förlåtelse.", //svar1
              "1, 1, 1, 1, 2, 1",//eventname1
              "2. Påminn Sancho om att hästen ska vara vit.",   //svar2
              "1, 1, 1, 1, 2, 2"); //eventname2
            allEvents.Add("1, 1, 1, 1, 2", ev);

            ev = new Event(
              "På vägen till Sanchos gård", //name
              "Alonso hoppar av sin häst och ställer sig på knä framför Sancho. “Tusen och återigen tusen tack för att du valt att lyssna. Det är med dåligt samvete jag har kommit för att be om ursäkt för det jag sade. Om du någonsin skulle ändra…”\n\nSancho avbryter honom. “Där har vi den Herr Quijana jag känner igen”. Återigen så finner Sanchos breda leende en plats på hans mun. “Jag antar att Rucio duger fint?”\n\n“Självklart!” Säger Alonso medans han reser sig upp och putsar av sin rustning. “Då så! Förbered Rucio, vi ska påbörja vår resa omedelbart!”\n\n“Självfallet Herr Quijana!” Svarar Sancho medans han börjar titta underligt på Alonso. “Säg mig Herr Quijana, vad heter din häst?”.\n\n“Hon…” Alonso avbryter sig själv, “Jag har än inte givit henne något namn.”. Alonso vänder sig mot hästen i fråga och tänker. “Rocín...Ante...där har vi det, Rosinante! Och för mig själv…”\n\n“Dig själv?” Frågar Sancho underligt.\n\n“För att bli riddare så behöver jag gå vid en riddares namn! Alonso Quijana är inte ridderligt nog.”. Efter en tids tänkande så har Alonso bestämt sig. “Don Quijote får det bli. Don Quijote av La Mancha!”.\n\n“Ett fint namn på en vacker häst och ett ståtligt namn för en modig riddare.” Antyder Sancho medans han bugar för Alonso. “Vart planerar du att färdas Sir. Quijote?”.\n\nDen självkrönte riddaren ler glatt till hans nya titel.",//question
              "1. “Låt oss rida till mitt hushåll, jag måste säga farväl till de som har tagit hand om mig i alla dessa år.”", //svar1
              "1, 1, 1, 1, 2, 1, 1",//eventname1
              "2. “Se till att du får med dig allt du behöver. Vi låter stigen leda oss.”",   //svar2
              "1, 1, 1, 1, 2, 1, 2"); //eventname2
            allEvents.Add("1, 1, 1, 1, 2, 1", ev);

            ev = new Event(
              "På vägen till Sanchos gård", //name
              "“Tack för att du stannade kära granne. Jag glömde att tala om för dig att jag föredrar att du rider på en vit häst. Tack för gott samtyckande”.\n\nSancho, med ett lika känslolöst ansikte, hoppar av sin vagn och går mot Alonso. Alonso börjar ana oråd och hinner inte reagera när Sancho sliter ner honom från hästen. \n\n“Gott samtyckande!?” Skriker Sancho rakt ut medans hans känslolösa ansikte ersätts av ilska. Sancho tar tag i Alonsos rustning, sliter av hans hjälm och slår Alonso i ansiktet oräkneliga gånger tills Alonso ligger blodig och knappt vid medvetande. “Du ska få se på gott samtyckande”, säger Sancho medans han plockar upp en sten stor som hans hand och avslutar Alonso med en sväng på hans arm.\n\nDet var de sista orden Alonso någonsin kommer att höra.\n\n>> Slut <<",//question
              "1. Avsluta.", //svar1
              "Slut"); //eventname1
            allEvents.Add("1, 1, 1, 1, 2, 2", ev);

            ev = new Event(
              "Ridandes", //name
              "De två rider mot Don Quijotes hushåll. Väl där överlåter han huset och hans ägodelar att tas hand av gårdsdrängen medans han är borta, han säger farväl till gårdsdrängen, hans systerdotter och hushållerskan innan han gör sig redo för att bege sig iväg. Med sig tar han den sköld och den lans som samlat damm på vinden tillsammans med ett exalterat sinne.\n\n“Låt oss rida iväg.” Säger han till Sancho med huvudet högt upp i skyn medans de två lämnar deras liv bakom sig för att ge sig ut..\n\nHär börjar riddaren och hans väpnares livs resa.\n\n>> Slut <<",//question
              "1. Avsluta.", //svar1
              "Slut"); //eventname1
            allEvents.Add("1, 1, 1, 1, 2, 1, 1", ev);

            ev = new Event(
              "Sanchos gård", //name
              "“Allt jag behöver är min åsna Rucio tillsammans med ett glatt humör.” antyder Sancho.\n\nDe båda beger sig iväg mot solnedgången med deras huvuden högt upp i skyn.\n\nHär börjar riddaren och hans väpnares livs resa.\n\n>> Slut <<",//question
              "1. Avsluta.", //svar1
              "Slut"); //eventname1
            allEvents.Add("1, 1, 1, 1, 2, 1, 2", ev);

            ev = new Event(
              "Hemma", //name
              "Alonso reser sig hastigt. “Jag kan inte låta denna beklagliga händelse komma åt mig. Jag får helt enkelt hitta någon annan som kan bli min väpnare! Jag kan inte jaga efter Sancho, det finns inte en chans att han kommer förlåta mig.” Tänker Sancho för sig självt medans han går till stallet och gör i ordning sin häst. “Jag har inte ridigt dig på länge, men nog ska jag dig allt kunna tygla!”\n\nHan rider iväg. Och för varje person han stöter på, vare det en handelsman, en bonde eller till och med en präst så håller han sitt tal, likt en predikan, för att övertyga dessa människor att följa med honom på sin resa. Men blir han inte endast nekad så blir han ignorerad, svuren åt eller till och med spottad på. 3 timmar har gått och Alonso börjar känna sig eländig ända in i själen.",//question
              "1. Rid tillbaka hem.", //svar1
              "1, 1, 1, 1, 1, 3, 1",//eventname1
              "2. Rid hem till Sancho",   //svar2
              "1, 1, 1, 1, 1, 3, 2"); //eventname2
            allEvents.Add("1, 1, 1, 1, 1, 3", ev);
        
            ev = new Event(
              "Ridandes", //name
              "Alonso vänder på sin häst och börjar trava hem. Nedlåten som han nu är så tar han sig inte an att tala med folket som han möter utan tillbringar sin tid i tankarnas värld tills han har nått sitt stall. Där låter han hushållets dräng ta hand om hästen medans han går in i huset och sätter sig i sin fåtölj. Alonso börjar snegla ut mot fönstret där solen börjar närma sin nedgång.",//question
              "1. Ge upp.", //svar1
              "1, 1, 1, 1, 1, 3, 1, 1",//eventname1
              "2. Rid hem till Sancho",   //svar2
              "1, 1, 1, 1, 1, 3, 1, 2"); //eventname2
            allEvents.Add("1, 1, 1, 1, 1, 3, 1", ev);

            ev = new Event(
              "Ridandes", //name
              "Alonso kvicknar till. “Jag kan inte låta det ta slut här. Ger en äkta riddare någonsin upp, oavsett vilken situation den är i?”. Alonso ger hans häst en spark, hästen ger ut ett stort gnägg innan den sätter fart mot Sanchos bondgård.\n\nSolen rör redan vid horisonten när han är framme vid Sanchos gård. Sancho själv, som ständigt arbetar med plantaget ser honom, ställer sig upp och avvaktar lutandes mot sin spade.",//question
              "1. Hoppa av din häst, gå försiktigt över plantaget fram till Sancho och be om förlåtelse.", //svar1
              "1, 1, 1, 1, 1, 3, 2, 1",//eventname1
              "2. Hoppa av, klampa över det nyplanterade vetet och fråga Sancho om han har en häst redo",   //svar2
              "1, 1, 1, 1, 1, 3, 2, 2"); //eventname2
            allEvents.Add("1, 1, 1, 1, 1, 3, 2", ev);

            ev = new Event(
              "Sanchos gård", //name
              "Alonso går fram till bonden och ställer sig ned på knä med ansiktet ned. “Jag ber om ursäkt, Sancho. Jag var ytterst oförskämd och skulle inte ha yttrat det jag yttrat. Kan jag med ditt tillstånd få en ny chans att be dig följa med mig ut i…”\n\nSancho avbryter honom. “Säg inget mer.”. Alonso tittar upp. Det breda leendet på Sanchos mun är tillbaka. “Där är mannen jag kallar herr.” fortsätter Sancho. Alonso reser sig upp, putsar av sin rustning och harklar sig. “Förbered Rucio, vi ska påbörja vår resa omedelbart!”\n\n“Självfallet Herr Quijana!” Svarar Sancho medans han börjar titta underligt på Alonso. “Säg mig Herr Quijana, vad heter din häst?”.\n\n“Hon…” Alonso avbryter sig själv, “Jag har än inte givit henne något namn.”. Alonso vänder sig mot hästen i fråga och tänker. “Rocín...Ante...där har vi det, Rosinante! Och för mig själv…”\n\n“Dig själv?” Frågar Sancho underligt.\n\n“För att bli riddare så behöver jag gå vid en riddares namn! Alonso Quijana är inte ridderligt nog.”. Efter en tids tänkande så har Alonso bestämt sig. “Don Quijote får det bli. Don Quijote av La Mancha!”.\n\n“Ett fint namn på en vacker häst och ett ståtligt namn för en modig riddare.” Antyder Sancho medans han bugar för Alonso. “Vart planerar du att färdas Sir. Quijote?”.\n\nDen självkrönte riddaren ler glatt till hans nya titel.",//question
              "1. “Låt oss rida till mitt hushåll, jag måste säga farväl till de som har tagit hand om mig i alla dessa år.”", //svar1
              "1, 1, 1, 1, 1, 3, 2, 1, 1",//eventname1
              "2. “Se till att du får med dig allt du behöver. Vi låter stigen leda oss.”",   //svar2
              "1, 1, 1, 1, 1, 3, 2, 1, 2"); //eventname2
            allEvents.Add("1, 1, 1, 1, 1, 3, 2, 1", ev);

            ev = new Event(
              "Hemma", //name
              "Den å så tappre riddaren sjunker ner i sin fåtölj. “Nåväl, jag har iallafall mina riddarromaner.” Suckar Alonso Quijana, mannen som fick leva som riddare för en dag.\n\n>> Slut <<",//question
              "1. Avsluta.", //svar1
              "Slut"); //eventname1
            allEvents.Add("1, 1, 1, 1, 1, 3, 1, 1", ev);
        
            ev = new Event(
              "Hemma", //name
              "Alonso kvicknar till. “Jag kan inte låta det ta slut här. Ger en äkta riddare någonsin upp, oavsett vilken situation den är i?”. Alonso kastar sig upp och tar, med sina snabbaste fotsteg, sig ut ur sitt hus och mot stallet som gårdsdrängen precis ska lämna. “Bind lös hästen dräng, jag ska iväg på min livs resa!”. Gårdsdrängen slår hakan mot bröstet och går in i stallet igen. När vår riddare sitter på hästen så ger han ingen tvekan innan han rider iväg. “Det är inte över än!” Tänker Alonso högt i sitt huvud.\n\nSolen rör redan vid horisonten när han är framme vid Sanchos gård. Sancho själv, som ständigt arbetar med plantaget ser honom, ställer sig upp och avvaktar lutandes mot sin spade.",//question
              "1. Hoppa av din häst, gå försiktigt över plantaget fram till Sancho och be om förlåtelse.", //svar1
              "1, 1, 1, 1, 1, 3, 1, 2, 1",//eventname1
              "2. Hoppa av, klampa över de nyplanterade vetet och fråga Sancho om han har en häst redo.",   //svar2
              "1, 1,1 ,1 , 1, 3, 1, 2, 2"); //eventname2
            allEvents.Add("1, 1, 1, 1, 1, 3, 1, 2", ev);

            ev = new Event(
              "Sanchos gård", //name
              "Sanchos stela ansikte blir mer ilsket för varje steg Alonso tar.\n\n“Har du ändrat dig?” frågar frågar Alonso med en prydlig röst som får Sanchos ansikte att bli röd av ilska.\n\n“Lämna min gård.” Yttrar Sancho som försöker hålla lugnet.\n\n“Jag tror inte att du förstår, jag behöver en väpnare.” Säger Alonso, återigen med en prydlig röst.\n\nSancho lyfter sin spade. “Jag tror inte att du förstår, jag vill inte ha någonting att göra med dig och din resa. Vänd dig om, ta din häst och lämna min åsyn.” \n\nAlonso vänder sig om. “Det är iallafall en häst, du kan väl skicka ett brev när du har skaffat dig ett riktigt städ.”\n\nAlonso hinner endast ta sitt första steg innan han hör Sanchos spade vissla genom luften. Med ett sista andetag sipprar livet ur Alonso medans blodet göder de nyplanterade vetet.\n\n>> Slut <<",//question
              "1. Avsluta.", //svar1
              "Slut"); //eventname1
            allEvents.Add("1, 1, 1, 1, 3, 1, 2, 2", ev);

            ev = new Event(
              "Sanchos gård", //name
              "Alonso går fram till bonden och ställer sig ned på knä med ansiktet ned. “Jag ber om ursäkt, Sancho. Jag var ytterst oförskämd och skulle inte ha yttrat det jag yttrat. Kan jag med ditt tillstånd få en ny chans att be dig följa med mig ut i…”\n\nSancho avbryter honom. “Säg inget mer.”. Alonso tittar upp. Det breda leendet på Sanchos mun är tillbaka. “Där är mannen jag kallar herr.” fortsätter Sancho. Alonso reser sig upp, putsar av sin rustning och harklar sig. “Förbered Rucio, vi ska påbörja vår resa omedelbart!”\n\n“Självfallet Herr Quijana!” Svarar Sancho medans han börjar titta underligt på Alonso. “Säg mig Herr Quijana, vad heter din häst?”. \n\n“Hon…” Alonso avbryter sig själv, “Jag har än inte givit henne något namn.”. Alonso vänder sig mot hästen i fråga och tänker. “Rocín...Ante...där har vi det, Rosinante! Och för mig själv…”\n\n“Dig själv?” Frågar Sancho underligt.\n\n“För att bli riddare så behöver jag gå vid en riddares namn! Alonso Quijana är inte ridderligt nog.”. Efter en tids tänkande så har Alonso bestämt sig. “Don Quijote får det bli. Don Quijote av La Mancha!”.\n\n“Ett fint namn på en vacker häst och ett ståtligt namn för en modig riddare.” Antyder Sancho medans han bugar för Alonso. “Vart planerar du att färdas Sir. Quijote?”.\n\nDen självkrönte riddaren ler glatt till hans nya titel.",//question
              "1. “Låt oss rida till mitt hushåll, jag måste säga farväl till de som har tagit hand om mig i alla dessa år.”", //svar1
              "1, 1, 1, 1, 3, 1, 2, 1, 1",//eventname1
              "2. “Se till att du får med dig allt du behöver. Vi låter stigen leda oss.”",   //svar2
              "1, 1, 1, 1, 3, 1, 2, 1, 2"); //eventname2
            allEvents.Add("1, 1, 1, 1, 3, 1, 2, 1", ev);

            ev = new Event(
              "Ridandes", //name
              "De två rider mot Don Quijotes hushåll. Väl där överlåter han huset och hans ägodelar att tas hand av gårdsdrängen medans han är borta, han säger farväl till gårdsdrängen, hans systerdotter och hushållerskan innan han gör sig redo för att bege sig iväg. Med sig tar han den sköld och den lans som samlat damm på vinden tillsammans med ett exalterat sinne.\n\n“Låt oss rida iväg.” Säger han till Sancho med huvudet högt upp i skyn medans de två lämnar deras liv bakom sig för att ge sig ut..\n\nHär börjar riddaren och hans väpnares livs resa.\n\n>> Slut <<",//question
              "1. Avsluta.", //svar1
              "Slut"); //eventname1
            allEvents.Add("1, 1, 1, 1, 3, 1, 2, 1, 1", ev);

            ev = new Event(
              "Ridandes", //name
              "De båda beger sig iväg mot solnedgången med deras huvuden högt upp i skyn.\n\nHär börjar riddaren och hans väpnares livs resa.\n\n>> Slut <<",//question
              "1. Avsluta", //svar1
              "Slut"); //eventname1
            allEvents.Add("1, 1, 1, 1, 3, 1, 2, 1, 2", ev);

            ev = new Event(
              "Hemma", //name
              "Alonso kvicknar till. “Jag kan inte låta det ta slut här. Ger en äkta riddare någonsin upp, oavsett vilken situation den är i?”. Alonso kastar sig upp och tar, med sina snabbaste fotsteg, sig ut ur sitt hus och mot stallet som gårdsdrängen precis ska lämna. “Bind lös hästen dräng, jag ska iväg på min livs resa!”. Gårdsdrängen lyder Alonsos order och tar ut hästen ur stallet. “Det är inte över än!” Tänker Alonso högt i sitt huvud.\n\nAldrig har vår riddare ridigt så här snabbt innan, han lyckas möta Sancho halvvägs till hans bondgård och ber honom att stanna.\n\nSancho tittar på Alonso med ett känslolöst ansiktsuttryck och avvaktar vad Alonso har att säga.",//question
              "1. Be Sancho om förlåtelse.", //svar1
              "1, 1, 1, 2, 1",//eventname1
              "2. Påmin Sancho om att hästen ska vara vit.",   //svar2
              "1, 1, 1, 2, 2"); //eventname2
            allEvents.Add("1, 1, 1, 2", ev);
        
            ev = new Event(
              "På vägen till Sanchos gård", //name
              "Alonso hoppar av sin häst och ställer sig på knä framför Sancho. “Tusen och återigen tusen tack för att du valt att lyssna. Det är med dåligt samvete jag har kommit för att be om ursäkt för det jag sade. Om du någonsin skulle ändra…”\n\nSancho avbryter honom. “Där har vi den Herr Quijana jag känner igen”. Återigen så finner Sanchos breda leende en plats på hans mun. “Jag antar att Rucio duger fint?”\n\n“Självklart!” Säger Alonso medans han reser sig upp och putsar av sin rustning. “Då så! Förbered Rucio, vi ska påbörja vår resa omedelbart!”\n\n“Självfallet Herr Quijana!” Svarar Sancho medans han börjar titta underligt på Alonso. “Säg mig Herr Quijana, vad heter din häst?”. \n\n“Hon…” Alonso avbryter sig själv, “Jag har än inte givit henne något namn.”. Alonso vänder sig mot hästen i fråga och tänker. “Rocín...Ante...där har vi det, Rosinante! Och för mig själv…”\n\n“Dig själv?” Frågar Sancho underligt.\n\n“För att bli riddare så behöver jag gå vid en riddares namn! Alonso Quijana är inte ridderligt nog.”. Efter en tids tänkande så har Alonso bestämt sig. “Don Quijote får det bli. Don Quijote av La Mancha!”.\n\n“Ett fint namn på en vacker häst och ett ståtligt namn för en modig riddare.” Antyder Sancho medans han bugar för Alonso. “Vart planerar du att färdas Sir. Quijote?”.\n\nDen självkrönte riddaren ler glatt till hans nya titel.",//question
              "1. “Låt oss rida till mitt hushåll, jag måste säga farväl till de som har tagit hand om mig i alla dessa år.”", //svar1
              "1, 1, 1, 2, 1, 1",//eventname1
              "2. “Se till att du får med dig allt du behöver. Vi låter stigen leda oss.”",   //svar2
              "1, 1, 1, 2, 1, 2"); //eventname2
            allEvents.Add("1, 1, 1, 2, 1", ev);

            ev = new Event(
              "Ridandes", //name
              "De två rider mot Don Quijotes hushåll. Väl där överlåter han huset och hans ägodelar att tas hand av gårdsdrängen medans han är borta, han säger farväl till gårdsdrängen, hans systerdotter och hushållerskan innan han gör sig redo för att bege sig iväg. Med sig tar han den sköld och den lans som samlat damm på vinden tillsammans med ett exalterat sinne.\n\n“Låt oss rida iväg.” Säger han till Sancho med huvudet högt upp i skyn medans de två lämnar deras liv bakom sig för att ge sig ut..\n\nHär börjar riddaren och hans väpnares",//question
              "1. Avsluta.", //svar1
              "Slut"); //eventname1
            allEvents.Add("1, 1, 1, 2, 1, 1", ev);

            ev = new Event(
              "Ridandes", //name
              "“Allt jag behöver är min åsna Rucio tillsammans med ett glatt humör.” antyder Sancho.\n\nDe båda beger sig iväg mot solnedgången med deras huvuden högt upp i skyn.\n\nHär börjar riddaren och hans väpnares livs resa.\n\n>> Slut <<",//question
              "1. Avsluta.", //svar1
              "Slut"); //eventname1
            allEvents.Add("1, 1, 1, 2, 1, 2", ev);

            ev = new Event(
              "På vägen till Sanchos gård.", //name
              "“Tack för att du stannade kära granne. Jag glömde att tala om för dig att jag föredrar att du rider på en vit häst. Tack för gott samtyckande”.\n\nSancho, med ett lika känslolöst ansikte, hoppar av sin vagn och går mot Alonso. Alonso börjar ana oråd och hinner inte reagera när Sancho sliter ner honom från hästen. \n\n“Gott samtyckande!?” Skriker Sancho rakt ut medans hans känslolösa ansikte ersätts av ilska. Sancho tar tag i Alonsos rustning, sliter av hans hjälm och slår Alonso i ansiktet oräkneliga gånger tills Alonso ligger blodig och knappt vid medvetande. “Du ska få se på gott samtyckande”, säger Sancho medans han plockar upp en sten stor som hans hand och avslutar Alonso med en sväng på hans arm.\n\nDet var de sista orden Alonso någonsin kommer att höra.\n\n>> Slut <<",//question
              "1. Avsluta.", //svar1
              "Slut"); //eventname1
            allEvents.Add("1, 1, 1, 2, 2", ev);
        
            ev = new Event(
              "Hemma", //name
              "Alonso reser sig hastigt. “Jag kan inte låta denna beklagliga händelse komma åt mig. Jag får helt enkelt hitta någon annan som kan bli min väpnare! Jag kan inte jaga efter Sancho, det finns inte en chans att han kommer förlåta mig.” Tänker Alonso för sig självt medans han går till stallet och gör i ordning sin häst. “Jag har inte ridigt dig på länge, men nog ska jag dig allt kunna tygla!”\n\nHan rider iväg. Och för varje person han stöter på, vare det en handelsman, en bonde eller till och med en präst så håller han sitt tal, likt en predikan, för att övertyga dessa människor att följa med honom på sin resa. Men blir han inte endast nekad så blir han ignorerad, svuren åt eller till och med spottad på. 3 timmar har gått och Alonso börjar känna sig eländig ända in i själen.",//question
              "1. Rid tillbaka hem.", //svar1
              "1, 1, 1, 3, 1",//eventname1
              "2. Rid hem till Sancho",   //svar2
              "1, 1, 1, 3, 2"); //eventname2
            allEvents.Add("1, 1, 1, 3", ev);

            ev = new Event(
              "Ridandes", //name
              "Alonso vänder på sin häst och börjar trava hem. Nedlåten som han nu är så tar han sig inte an att tala med folket som han möter utan tillbringar sin tid i tankarnas värld tills han har nått sitt stall. Där låter han hushållets dräng ta hand om hästen medans han går in i huset och sätter sig i sin fåtölj. Alonso börjar snegla ut mot fönstret där solen börjar närma sin nedgång.",//question
              "1. Ge upp.", //svar1
              "1, 1, 1, 3, 1, 1",//eventname1
              "2. Rid hem till Sancho.",   //svar2
              "1, 1, 1, 3, 1, 2"); //eventname2
            allEvents.Add("1, 1, 1, 3, 1", ev);

            ev = new Event(
              "Hemma", //name
              "Den å så tappre riddaren sjunker ner i sin fåtölj. “Nåväl, jag har iallafall mina riddarromaner.” Suckar Alonso Quijana, mannen som fick leva som riddare för en dag.\n\n>> Slut <<",//question
              "1. Avsluta.", //svar1
              "Slut"); //eventname1
            allEvents.Add("1, 1, 1, 3, 1, 1", ev);

            ev = new Event(
              "Hemma", //name
              "Alonso kvicknar till. “Jag kan inte låta det ta slut här. Ger en äkta riddare någonsin upp, oavsett vilken situation den är i?”. Alonso kastar sig upp och tar, med sina snabbaste fotsteg, sig ut ur sitt hus och mot stallet som gårdsdrängen precis ska lämna. “Bind lös hästen dräng, jag ska iväg på min livs resa!”. Gårdsdrängen slår hakan mot bröstet och går in i stallet igen. När vår riddare sitter på hästen så ger han ingen tvekan innan han rider iväg. “Det är inte över än!” Tänker Alonso högt i sitt huvud.\n\nSolen rör redan vid horisonten när han är framme vid Sanchos gård. Sancho själv, som ständigt arbetar med plantaget ser honom, ställer sig upp och avvaktar lutandes mot sin spade.",//question
              "1. Hoppa av din häst, gå försiktigt över plantaget fram till Sancho och be om förlåtelse.", //svar1
              "1, 1, 1, 3, 1, 2, 1",//eventname1
              "2. Hoppa av, klampa över de nyplanterade vetet och fråga Sancho om han har en häst redo.",   //svar2
              "1, 1, 1, 3, 1, 2, 2"); //eventname2
            allEvents.Add("1, 1, 1, 3, 1, 2", ev);
       
            ev = new Event(
              "Sanchos gård", //name
              "Alonso går fram till bonden och ställer sig ned på knä med ansiktet ned. “Jag ber om ursäkt, Sancho. Jag var ytterst oförskämd och skulle inte ha yttrat det jag yttrat. Kan jag med ditt tillstånd få en ny chans att be dig följa med mig ut i…”\n\nSancho avbryter honom. “Säg inget mer.”. Alonso tittar upp. Det breda leendet på Sanchos mun är tillbaka. “Där är mannen jag kallar herr.” fortsätter Sancho. Alonso reser sig upp, putsar av sin rustning och harklar sig. “Förbered Rucio, vi ska påbörja vår resa omedelbart!”\n\n“Självfallet Herr Quijana!” Svarar Sancho medans han börjar titta underligt på Alonso. “Säg mig Herr Quijana, vad heter din häst?”.\n\n“Hon…” Alonso avbryter sig själv, “Jag har än inte givit henne något namn.”. Alonso vänder sig mot hästen i fråga och tänker. “Rocín...Ante...där har vi det, Rosinante! Och för mig själv…”\n\n“Dig själv?” Frågar Sancho underligt.\n\n“För att bli riddare så behöver jag gå vid en riddares namn! Alonso Quijana är inte ridderligt nog.”. Efter en tids tänkande så har Alonso bestämt sig. “Don Quijote får det bli. Don Quijote av La Mancha!”.\n\n“Ett fint namn på en vacker häst och ett ståtligt namn för en modig riddare.” Antyder Sancho medans han bugar för Alonso. “Vart planerar du att färdas Sir. Quijote?”.\n\nDen självkrönte riddaren ler glatt till hans nya titel.",//question
              "1. “Låt oss rida till mitt hushåll, jag måste säga farväl till de som har tagit hand om mig i alla dessa år.”", //svar1
              "1, 1, 1, 3, 1, 2, 1, 1",//eventname1
              "2. “Se till att du får med dig allt du behöver. Vi låter stigen leda oss.”",   //svar2
              "1, 1, 1, 3, 1, 2, 1, 2"); //eventname2
            allEvents.Add("1, 1, 1, 3, 1, 2, 1", ev);

            ev = new Event(
              "Ridandes", //name
              "De två rider mot Don Quijotes hushåll. Väl där överlåter han huset och hans ägodelar att tas hand av gårdsdrängen medans han är borta, han säger farväl till gårdsdrängen, hans systerdotter och hushållerskan innan han gör sig redo för att bege sig iväg. Med sig tar han den sköld och den lans som samlat damm på vinden tillsammans med ett exalterat sinne.\n\n“Låt oss rida iväg.” Säger han till Sancho med huvudet högt upp i skyn medans de två lämnar deras liv bakom sig för att ge sig ut..\n\nHär börjar riddaren och hans väpnares livs resa.\n\n>> Slut <<",//question
              "1. Avsluta.", //svar1
              "Slut"); //eventname1
            allEvents.Add("1, 1, 1, 3, 1, 2, 1, 1", ev);

            ev = new Event(
              "Ridandes", //name
              "De båda beger sig iväg mot solnedgången med deras huvuden högt upp i skyn.\n\nHär börjar riddaren och hans väpnares livs resa.\n\n>> Slut <<",//question
              "1. Avsluta.", //svar1
              "Slut"); //eventname1
            allEvents.Add("1, 1, 1, 3, 1, 2, 1, 2", ev);

            ev = new Event(
              "Sanchos gård", //name
              "Sanchos stela ansikte blir mer ilsket för varje steg Alonso tar. “Har du ändrat dig?” frågar frågar Alonso med en prydlig röst som får Sanchos ansikte att bli röd av ilska.\n\n“Lämna min gård.” Yttrar Sancho som försöker hålla lugnet.\n\n“Jag tror inte att du förstår, jag behöver en väpnare.” Säger Alonso, återigen med en prydlig röst.\n\nSancho lyfter sin spade. “Jag tror inte att du förstår, jag vill inte ha någonting att göra med dig och din resa. Vänd dig om, ta din häst och lämna min åsyn.” \n\nAlonso vänder sig om. “Det är iallafall en häst, du kan väl skicka ett brev när du har skaffat dig ett riktigt städ.”\n\nAlonso hinner endast ta sitt första steg innan han hör Sanchos spade vissla genom luften. Med ett sista andetag sipprar livet ur Alonso medans blodet göder de nyplanterade vetet.\n\n>> Slut <<",//question
              "Avsluta.", //svar1
              "Slut"); //eventname1
            allEvents.Add("1, 1, 1, 3, 1, 2, 2", ev);

            ev = new Event(
              "Ridandes", //name
              "Alonso kvicknar till. “Jag kan inte låta det ta slut här. Ger en äkta riddare någonsin upp, oavsett vilken situation den är i?”. Alonso ger hans häst en spark, hästen ger ut ett stort gnägg innan den sätter fart mot Sanchos bondgård.\n\nSolen rör redan vid horisonten när han är framme vid Sanchos gård. Sancho själv, som ständigt arbetar med plantaget ser honom, ställer sig upp och avvaktar lutandes mot sin spade.",//question
              "1. Hoppa av din häst, gå försiktigt över plantaget fram till Sancho och be om förlåtelse.", //svar1
              "1, 1, 1, 3, 2, 1",//eventname1
              "2. Hoppa av, klampa över de nyplanterade vetet och fråga Sancho om han har en häst redo.",   //svar2
              "1, 1, 1, 3, 2, 2"); //eventname2
            allEvents.Add("1, 1, 1, 3, 2", ev);
        
            ev = new Event(
              "Sanchos gård", //name
              "Alonso går fram till bonden och ställer sig ned på knä med ansiktet ned. “Jag ber om ursäkt, Sancho. Jag var ytterst oförskämd och skulle inte ha yttrat det jag yttrat. Kan jag med ditt tillstånd få en ny chans att be dig följa med mig ut i…”\n\nSancho avbryter honom. “Säg inget mer.”. Alonso tittar upp. Det breda leendet på Sanchos mun är tillbaka. “Där är mannen jag kallar herr.” fortsätter Sancho. Alonso reser sig upp, putsar av sin rustning och harklar sig. “Förbered Rucio, vi ska påbörja vår resa omedelbart!”\n\n“Självfallet Herr Quijana!” Svarar Sancho medans han börjar titta underligt på Alonso. “Säg mig Herr Quijana, vad heter din häst?”.\n\n“Hon…” Alonso avbryter sig själv, “Jag har än inte givit henne något namn.”. Alonso vänder sig mot hästen i fråga och tänker. “Rocín...Ante...där har vi det, Rosinante! Och för mig själv…”\n\n“Dig själv?” Frågar Sancho underligt.\n\n“För att bli riddare så behöver jag gå vid en riddares namn! Alonso Quijana är inte ridderligt nog.”. Efter en tids tänkande så har Alonso bestämt sig. “Don Quijote får det bli. Don Quijote av La Mancha!”.\n\n“Ett fint namn på en vacker häst och ett ståtligt namn för en modig riddare.” Antyder Sancho medans han bugar för Alonso. “Vart planerar du att färdas Sir. Quijote?”.\n\nDen självkrönte riddaren ler glatt till hans nya titel.",//question
              "1. “Låt oss rida till mitt hushåll, jag måste säga farväl till de som har tagit hand om mig i alla dessa år.”", //svar1
              "1, 1, 1, 3, 2, 1, 1",//eventname1
              "2. “Se till att du får med dig allt du behöver. Vi låter stigen leda oss.”",   //svar2
              "1, 1, 1, 3, 2, 1, 2"); //eventname2
            allEvents.Add("1, 1, 1, 3, 2, 1", ev);
        
            ev = new Event(
              "Ridandes", //name
              "De två rider mot Don Quijotes hushåll. Väl där överlåter han huset och hans ägodelar att tas hand av gårdsdrängen medans han är borta, han säger farväl till gårdsdrängen, hans systerdotter och hushållerskan innan han gör sig redo för att bege sig iväg. Med sig tar han den sköld och den lans som samlat damm på vinden tillsammans med ett exalterat sinne.\n\n“Låt oss rida iväg.” Säger han till Sancho med huvudet högt upp i skyn medans de två lämnar deras liv bakom sig för att ge sig ut..\n\nHär börjar riddaren och hans väpnares livs resa.\n\n>> Slut <<",//question
              "1. Avsluta.", //svar1
              "Slut"); //eventname1
            allEvents.Add("1, 1, 1, 3, 2, 1, 1", ev);
        
            ev = new Event(
              "Ridandes", //name
              "De båda beger sig iväg mot solnedgången med deras huvuden högt upp i skyn.\n\nHär börjar riddaren och hans väpnares livs resa.\n\n>> Slut <<",//question
              "1. Avsluta.", //svar1
              "Slut"); //eventname1
            allEvents.Add("1, 1, 1, 3, 2, 1, 2", ev);
        
            ev = new Event(
              "Sanchos gård", //name
              "Sanchos stela ansikte blir mer ilsket för varje steg Alonso tar.\n\n“Har du ändrat dig?” frågar Alonso med en prydlig röst som får Sanchos ansikte att bli röd av ilska.\n\n“Lämna min gård.” Yttrar Sancho som försöker hålla lugnet.\n\n“Jag tror inte att du förstår, jag behöver en väpnare.” Säger Alonso, återigen med en prydlig röst.\n\nSancho lyfter sin spade. “Jag tror inte att du förstår, jag vill inte ha någonting att göra med dig och din resa. Vänd dig om, ta din häst och lämna min åsyn.” \n\nAlonso vänder sig om. “Det är iallafall en häst, du kan väl skicka ett brev när du har skaffat dig ett riktigt städ.”\n\nAlonso hinner endast ta sitt första steg innan han hör Sanchos spade vissla genom luften. Med ett sista andetag sipprar livet ur Alonso medans blodet göder de nyplanterade vetet.\n\n>> Slut <<",//question
              "1. Avsluta.", //svar1
              "Slut"); //eventname1
            allEvents.Add("1, 1, 1, 3, 2, 2", ev);

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

