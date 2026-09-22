using NUnit.Framework;
using KaotikusAllatklinika;

namespace KaotikusAllatklinika.Tesztek
{
    [TestFixture]
    public class KlinikaTesztek
    {
        [Test]
        public void Kisallat_AlapértelmezettAggodalomÉsNevValidacio()
        {
            var allat = new Kisallat("", -5, 50);

            Assert.That(allat.Nev, Is.EqualTo("Névtelen Páciens"));
            Assert.That(allat.Kor, Is.EqualTo(0));
            Assert.That(allat.AggodalomSzint, Is.EqualTo(20));
            Assert.That(allat.Veszelyes, Is.False);
        }

        [Test]
        public void Kisallat_EgeszsegSzint_KorlatokKozottMarad()
        {
            var allat = new Kisallat("Cézár", 5, 120);
            Assert.That(allat.EgeszsegSzint, Is.EqualTo(100));

            allat.EgeszsegSzint = -10;
            Assert.That(allat.EgeszsegSzint, Is.EqualTo(0));
        }

        [Test]
        public void Kisallat_VeszelyesAllapot_AkkorTrueHaAggodalom_legalabb_80()
        {
            var allat = new Kisallat("Rex", 3, 50);
            allat.AggodalomSzint = 79;
            Assert.That(allat.Veszelyes, Is.False);

            allat.AggodalomSzint = 80;
            Assert.That(allat.Veszelyes, Is.True);
        }

        [Test]
        public void KiborgKutya_HangotAd_AkkumulatorCsokken()
        {
            var kutya = new KiborgKutya("Rintintin Bot", 4, 80, 20);

            kutya.HangotAd();

            Assert.That(kutya.AkkumulatorToltottseg, Is.EqualTo(15));
        }
        /*
[Test]
public void KiborgKutya_KezelesKapot_OsEsSajatLogikaIsLefut()
{
    var kutya = new KiborgKutya("Rintintin Bot", 4, 50, 50);

    kutya.KezelesKapot(20);

    Assert.That(kutya.EgeszsegSzint, Is.EqualTo(70)); // 50 + 20 (base)
    Assert.That(kutya.AggodalomSzint, Is.EqualTo(10)); // 20 - 10 (base)
    Assert.That(kutya.AkkumulatorToltottseg, Is.EqualTo(70)); // 50 + 20 (extra)
}

[Test]
public void HipnoMacska_KezelesKapot_GyogyitasCsokkenEsAggodalomNo()
{
    var macska = new HipnoMacska("Cirmos", 2, 40, 3); // HipnoEro = 3

    macska.KezelesKapot(15);

    // Gyógyulás = 15 - 3 = 12 -> Új egészség = 40 + 12 = 52
    Assert.That(macska.EgeszsegSzint, Is.EqualTo(52));
    // Aggodalom nõ 5-tel: 20 + 5 = 25
    Assert.That(macska.AggodalomSzint, Is.EqualTo(25));
}

[Test]
public void PapagajVarazslo_VarazsolGyogyitast_ElegendoManaEsetenGyogyit()
{
    var papagaj = new PapagajVarazslo("Hahota", 1, 30, 20);

    papagaj.VarázsolGyogyitast();

    Assert.That(papagaj.EgeszsegSzint, Is.EqualTo(50)); // 30 + 20
    Assert.That(papagaj.ManaSzint, Is.EqualTo(5)); // 20 - 15
}

[Test]
public void Klinika_CsoportosKezeles_VeszelyesAllatotKihagy()
{
    var klinika = new Klinika();
    var szelidKutya = new KiborgKutya("Bobi", 3, 50, 50);
    var veszelyesMacska = new HipnoMacska("Mefisztó", 5, 50, 4);
    veszelyesMacska.AggodalomSzint = 85; // Veszélyessé tesszük

    klinika.BetegFelvétele(szelidKutya);
    klinika.BetegFelvétele(veszelyesMacska);

    klinika.CsoportosKezeles(20);

    // A szelíd kutya meggyógyult
    Assert.That(szelidKutya.EgeszsegSzint, Is.EqualTo(70));
    // A veszélyes macska nem kapott kezelést, maradt 50
    Assert.That(veszelyesMacska.EgeszsegSzint, Is.EqualTo(50));
}

[Test]
public void Klinika_CsoportosKezeles_PapagajVarazslatLefutCastinggal()
{
    var klinika = new Klinika();
    var papagaj = new PapagajVarazslo("Merlin", 2, 40, 30);

    klinika.BetegFelvétele(papagaj);
    klinika.CsoportosKezeles(10);

    // 1. Alap kezelés: 40 + 10 = 50
    // 2. Típusvizsgálat után varázslat: 50 + 20 = 70
    Assert.That(papagaj.EgeszsegSzint, Is.EqualTo(70));
    Assert.That(papagaj.ManaSzint, Is.EqualTo(15)); // 30 - 15
}*/
    }
}