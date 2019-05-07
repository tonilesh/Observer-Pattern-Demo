using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cricket;
using System.Threading;

namespace CricketApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program Starts...");
            CricketScorePublisher publisher = new CricketScorePublisher();
            CricketFan s1 = new CricketFan();
            RecordKeeper s2 = new RecordKeeper();
            CricketAnalyst s3 = new CricketAnalyst();


            Console.WriteLine("Starting publisher...");
            publisher.Start();
            Console.WriteLine("Sleeping for 5 seconds...");
            Thread.Sleep(5000);

            Console.WriteLine("Cricket Fan and Record keeper joins...");
            publisher.Subscribe(s1);
            publisher.Subscribe(s2);

            Console.WriteLine("Sleeping for another 5 seconds...");
            Thread.Sleep(5000);

            Console.WriteLine("Cricket Fan leaves; Cricket Analyst Joins...");
            publisher.Subscribe(s3);
            publisher.UnSubscribe(s1);
            Console.WriteLine("Sleeping for another 5 seconds...");
            Thread.Sleep(5000);


            Console.WriteLine("Cricket Fan joins back...");
            publisher.Subscribe(s1);
            Console.WriteLine("Sleeping for another 5 seconds...");
            Thread.Sleep(5000);

            publisher.Stop();
        }
    }
}
