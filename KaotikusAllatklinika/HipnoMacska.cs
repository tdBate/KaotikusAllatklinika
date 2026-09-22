using System;
using System.Diagnostics.Tracing;

namespace KaotikusAllatklinika
{
    public class HipnoMacska : Kisallat
    {
        private int hipnoEro;
        public HipnoMacska(string nev, int kor, int egeszsegSzint, int hipnoEro) : base(nev, kor, egeszsegSzint)
        {
            HipnoEro = hipnoEro;
        }

        public int HipnoEro
        {

            get
            {
                return hipnoEro;
            }
            set
            {
                hipnoEro = Math.Clamp(value, 1, 10);
            }

        }

        public override void KezelesKapott(int gyogyitasMerteke)
        {
            int tenylegesGyogyotas = gyogyitasMerteke - HipnoEro;
            EgeszsegSzint += tenylegesGyogyotas;
            AggodalomSzint += 5;
        }
    }
}