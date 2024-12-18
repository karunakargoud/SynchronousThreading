using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace SynchronousThreading
{
    internal class Program
    {
        static void Main(string[] args)
        {
           ParameterizedThreadStart tr1=new ParameterizedThreadStart(MyLib.ShowMessage);
           Thread t1=new Thread(tr1);
           Thread t2 = new Thread(tr1);

            string m1 = "Hyderabad is known as the City of Pearls, " +
                "as it had once flourished as a global center for" +
                " trade of rare diamonds, emeralds as well as natural pearls." +
                " Mecca Masjid, Charminar, Golconda fort, QutubShahi tombs, Paigah " +
                "tombs are some of the historic structures" +
                " Hyderabad is the capital of Telangana state" +
                " and is located on the Musi River in the Deccan Plateau";
            string m2 = "It is one of eleven cities in the country to have" +
                " been chosen for the Heritage City Development and Augmentation " +
                "Yojana scheme by the Government of India.[7] It was also selected as a " +
                "smart city in the \"fast-track competition\", which makes it eligible for" +
                " additional investment to improve urban infrastructure and industrial opportunities " +
                "under the Smart Cities Mission.[8]\r\n\r\nThe three urban cities: Kazipet, Hanamkonda " +
                "and Warangal are together known as Warangal Tri-City. The three cities are connected by " +
                "the National Highway 163 (Hyderabad–Bhuvanagiri–Warangal–Bhopalpatnam). The major stations" +
                " are Kazipet Junction railway station and Warangal railway station";
            t1.Start(m1);
            t2.Start(m2);
        }


    }
}
