using System;

namespace KaotikusAllatklinika
{
    public class KiborgKutya : Kisallat
    {
        private int akkumlatorToltottseg;
        public KiborgKutya(string nev, int kor, int egeszsegSzint, int akku) : base(nev, kor, egeszsegSzint)
        {
            AkkumulatorToltottseg = akku;
        }

        public int AkkumulatorToltottseg
        {
            get { return akkumlatorToltottseg; }
            set
            {
                akkumlatorToltottseg = Math.Clamp(value, 0, 100);
            }
        }

        public override void HangotAd()
        {
            if (AkkumulatorToltottseg > 10)
            {
                Console.WriteLine($"{Nev}: BARK! BARK!");
            }
            else
            {
                Console.WriteLine($"{Nev}: lemerült");
            }
        }


    }
}