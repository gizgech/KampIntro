﻿using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Gizem";
            int yas = 36;

            Kurs kurs1= new Kurs(); //tipi kurs
            kurs1.KursAdi = "Java";
            kurs1.Eğitmen = "Kerem Varış";
            kurs1.IzlenmeOrani = 64;

            Kurs kurs2 = new Kurs(); //tipi kurs
            kurs2.KursAdi = "Python";
            kurs2.Eğitmen = "Berkay Bilgin";
            kurs2.IzlenmeOrani = 80;

            Kurs kurs3 = new Kurs(); //tipi kurs
            kurs3.KursAdi = "C#";
            kurs3.Eğitmen = "Engin Demiroğ";
            kurs3.IzlenmeOrani = 68;

            // Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Eğitmen); 

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3};
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Eğitmen);
            }

        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Eğitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
