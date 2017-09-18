﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOPPractice
{
    class Good : Music
    {
        public string InstrumentType { get; set; }

        public override void Cost(int price)
        {
            Console.WriteLine($"This song costs ${price}.");
            Price = price;
        }

        public override void HasMusicVideo()
        {
            Console.WriteLine("This song has a music video!");
        }

        public void HasGoodBeat()
        {
            Console.WriteLine("You better believe this song will make you move.");
        }
    }
}
