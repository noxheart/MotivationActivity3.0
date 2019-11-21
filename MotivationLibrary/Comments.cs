using System;

namespace MotivationLibrary
{
    public class Comments
    {
        public string PositiveComment()
        {
        string[] positive = new string[5];
        positive[0] = "Du klarar av mer än vad du tror! ";
        positive[1] = "Du är stark och unik! ";
        positive[2] = "Du är fantastisk! ";
        positive[3] = "Bra jobbat! ";
        positive[4] = "Du är så j*vla bra, jag älskar dig! ";

        Random random = new Random();

        int index = random.Next(positive.Length); //GENERERAR ETT SLUPPMÄSSIGT INDEX MINDRE ÄN STORLEKEN PÅ ARRAYEN
        
        return positive[index];
        }
        public string NegativeComment()
        {
        string[] negative = new string[8];
        negative[0] = "Jag vet att du kan bättre... ";
        negative[1] = "Jag vet koma patienter som gör mer än vad du gör... ";
        negative[2] = "Jag blir så besviken...";
        negative[3] = "Din motivation får mig att vilja dö...";
        negative[4] = "Du är inte bara dålig, du är ful också...";
        negative[5] = "Seriöst?...";
        negative[6] = "Okej, en pizza på det?...";
        negative[7] = "Kvist hade gjort detta bättre...";

        Random random = new Random();

        int index = random.Next(negative.Length); //GENERERAR ETT SLUPPMÄSSIGT INDEX MINDRE ÄN STORLEKEN PÅ ARRAYEN
        return negative[index];
        }
    }
}