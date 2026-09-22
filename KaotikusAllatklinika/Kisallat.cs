using System;
using System.Globalization;

namespace KaotikusAllatklinika
{
    public class Kisallat
    {
        private string nev;
        private int kor;
        private int egeszsegSzint;
        private int aggodalomSzint;

        public Kisallat(string nev, int kor, int egeszsegSzint)
        {
            Nev = nev;
            Kor = kor;
            EgeszsegSzint = egeszsegSzint;
            AggodalomSzint = 20;

        }

        //private bool veszelyes;

        public string Nev
        {
            get { return nev; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    nev = "Névtelen Páciens";
                }
                else
                {
                    nev = value;
                }
            }
        }

        public int Kor
        {
            get
            {
                return kor;
            }
            set
            {
                if (value < 0)
                {
                    kor = 0;
                }
                else if (value > 30)
                {
                    kor = 30;
                }
                else
                {
                    kor = value;
                }
            }
        }

        public int EgeszsegSzint
        {
            get { return egeszsegSzint; }
            set
            {
                if (value < 0)
                {
                    egeszsegSzint = 0;
                }
                else if (value > 100)
                {
                    egeszsegSzint = 100;
                }
                else
                {
                    egeszsegSzint = value;
                }
            }

        }

        public int AggodalomSzint
        {
            get { return aggodalomSzint; }
            set
            {
                aggodalomSzint = Math.Clamp(value, 0, 100);
            }

        }

        public bool Veszelyes
        {
            get
            {
                return (AggodalomSzint >= 80);
            }
        }



    }
}