﻿using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriManager musteriManager = new MusteriManager();

            musteriManager.MusteriEkle();
            musteriManager.MusteriList();
            musteriManager.MusteriSil();


        }
    }
}
