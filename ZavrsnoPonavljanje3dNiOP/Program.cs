using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZavrsnoPonavljanje3dNiOP
{
    class Program
    {
        static void Main(string[] args)
        {
            string biranje, sVelika, sMala, sPrvaTri, sZadnjihPet, s8_11, poruka;
            string[] igraci = new string[32];
            int sekunde, broj, zbroj;
            double prosjek;
            int[] Brojevi = new int[5];
            do
            {
                Console.Write("Prvi Drugi Treci Cetvrti Peti Sesti Kraj : ");
                biranje = Console.ReadLine();
                switch (biranje)
                {
                    case ("Prvi"):
                        Console.Write("Upisite poruku: ");
                        poruka = Console.ReadLine();
                        sVelika = poruka.ToUpper();
                        sMala = poruka.ToLower();
                        sPrvaTri = poruka.Substring(0, 3);
                        sZadnjihPet = poruka.Substring(poruka.Length - 5);
                        try { s8_11 = poruka.Substring(8, 3); }
                        catch (Exception e) { s8_11 = "Poruka je pre kratka"; }
                        Console.WriteLine("sVelika = " + sVelika + "\nsMala = " + sMala + "\nsPrvaTri = " + sPrvaTri + "\nsZadnjihPet = " + sZadnjihPet + "\ns8_11 = " + s8_11);
                        break;

                    case ("Drugi"):
                        Console.Write("Upisite sekunde: ");
                        sekunde = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(sekunde + " sekundi je " + sekunde / 60 + " minuta i " + (sekunde - ((sekunde / 60) * 60)) + " sekundi");
                        break;

                    case ("Treci"):
                        Console.Write("Upisite broj: ");
                        broj = Convert.ToInt32(Console.ReadLine());
                        if (broj % 6 == 0)
                        {
                            if (broj % 4 == 0) { Console.WriteLine("Broj je djeljiv sa 4 i sa 6"); }
                            else { Console.WriteLine("Broj je djeljiv sa 6"); }
                        }
                        else
                        {
                            if (broj % 4 == 0) { Console.WriteLine("Broj je djeljiv sa 4"); }
                            else { Console.WriteLine("Broj nije djeljiv sa 4 ni sa 6"); }
                        }
                        break;

                    case ("Cetvrti"):
                        for (int i = 0; i < 32; i++)
                        {
                            Console.Write("Upisite igraca broj " + (i + 1) + ": ");
                            igraci[i] = Console.ReadLine();
                        }
                        for (int i = 0,j = 0; i < 16; i++)
                        {
                            Console.WriteLine("Par broj " + (i + 1) + ": " + igraci[j] + " vs " + igraci[j+1]);
                            j = j + 2;
                        }
                        break;

                    case ("Peti"):
                        for (int i1 = 1; i1 <= 33; i1++)
                        {
                            for (int i2 = i1 + 1; i2 <= 34; i2++)
                            {
                                for (int i3 = i2 + 1; i3 <= 35; i3++)
                                {
                                    for (int i4 = i3 + 1; i4 <= 36; i4++)
                                    {
                                        for (int i5 = i4 + 1; i5 <= 37; i5++)
                                        {
                                            for (int i6 = i5 + 1; i6 <= 38; i6++)
                                            {
                                                for (int i7 = i6 + 1; i7 <= 39; i7++)
                                                {
                                                    Console.WriteLine(i1 + " " + i2 + " " + i3 + " " + i4 + " " + i5 + " " + i6 + " " + i7);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        break;

                    case ("Sesti"):
                        for (int i = 0; i < 5; i++)
                        {
                            Console.Write("Upisite broj " + (i + 1) + " : ");
                            Brojevi[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        KlasaC Objekt = new KlasaC();
                        zbroj = Objekt.Zbroj(Brojevi);
                        prosjek = Objekt.Prosjek(Brojevi);
                        Console.WriteLine("Zbroj brojeva je : " + zbroj + " a prosjek brojeva je : " + prosjek);
                        break;
                }
            } while (biranje != "Kraj");
        }
    }
}
