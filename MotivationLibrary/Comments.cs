using System;

namespace MotivationLibrary
{
    class Comments
    {
        public string PositiveComment()
        {
        string[] positive = new string[5];
        positive[0] = "Du klarar av mer än vad du tror! ";
        positive[1] = "Du är stark och unik! ";
        positive[2] = "Du är fantastisk! ";
        positive[3] = "Bra jobbat! ";
        positive[4] = "asdqweq wqeqe";

        Random random = new Random();

        int index = random.Next(positive.Length); //GENERERAR ETT SLUPPMÄSSIGT INDEX MINDRE ÄN STORLEKEN PÅ ARRAYEN
        
        return positive[index];
        }
        public void NegativeComment()
        {
        string[] negative = new string[5];
        negative[0] = "asd";
        negative[1] = "asd";
        negative[2] = "asd";
        negative[3] = "asd";
        negative[4] = "asd";

        Random random = new Random();

        int index = random.Next(negative.Length); //GENERERAR ETT SLUPPMÄSSIGT INDEX MINDRE ÄN STORLEKEN PÅ ARRAYEN
        }
    }
}