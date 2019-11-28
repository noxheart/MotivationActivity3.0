using System;

namespace MotivationLibrary
{
    public class Comments
    {
        public string PositiveComment()
        {
        string[] positive = new string[11];
        positive[0] = "Du klarar av mer än vad du tror! ";
        positive[1] = "Du är stark och unik! ";
        positive[2] = "Du är fantastisk! ";
        positive[3] = "Bra jobbat! ";
        positive[4] = "Du är så j*vla bra, jag älskar dig! ";
        positive[5] = "Du är bättre än The ROCK! ";
        positive[6] = "Jag skulle vilja bada i all svett din vackra kropp utpumpat idag!";
        positive[7] = "Push it real good!";
        positive[8] = "Du är inte bara bäst, du är snygg också!";
        positive[9] = "DJUUUR!";
        positive[10] = "Vill du gifta dig med mig?";

        Random random = new Random();

        int index = random.Next(positive.Length); //GENERERAR ETT SLUPPMÄSSIGT INDEX MINDRE ÄN STORLEKEN PÅ ARRAYEN
        
        return positive[index];
        }
        public string NegativeComment()
        {
        string[] negative = new string[10];
        negative[0] = "Jag vet att du kan bättre... ";
        negative[1] = "Jag vet komapatienter som gör mer än vad du gör... ";
        negative[2] = "Jag blir så besviken...";
        negative[3] = "Din motivation får mig att vilja dö...";
        negative[4] = "Du är inte bara dålig, du är ful också...";
        negative[5] = "Seriöst?...";
        negative[6] = "Okej, en pizza på det?...";
        negative[7] = "Kvist hade gjort detta bättre...";
        negative[8] = "Nein! Nein! Nein!!!!";
        negative[9] = "Jag vill skilljas...";

        Random random = new Random();

        int index = random.Next(negative.Length); //GENERERAR ETT SLUPPMÄSSIGT INDEX MINDRE ÄN STORLEKEN PÅ ARRAYEN
        return negative[index];
        }
    }
}