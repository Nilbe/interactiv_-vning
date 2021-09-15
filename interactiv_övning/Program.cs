using System;

Console.WriteLine("Du har vandrat i skogen i två timmar nu och letar efter en väg tillbaka till skogsbrynet där du gick in. Du hittar en stig och följer den tills den delar på sig. Väljer du att gå till höger eller fortsätter du framåt? skriv ditt svar.");

string höger = Console.ReadLine();
string framåt = Console.ReadLine();

höger = höger.ToLower();
framåt = framåt.ToLower();

if (framåt == "framåt") {
    Console.WriteLine("Du fortsätter framåt och kommer till skogsbrynet och flyr, YAY!");
}
else if (höger == "höger") {
    Console.WriteLine("Du går åt höger och följer denna stig tills du hittar ett hus. Knackar du på? ja eller nej?");
}

