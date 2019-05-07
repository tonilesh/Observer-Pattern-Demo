using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Patterns.Observer;
using System.Threading;

namespace Cricket
{
    public class CricketScorePublisher: Publisher<CricketScore>
    {
        Thread t;
        public CricketScorePublisher()
        {
            t = new Thread(Run);

        }

        bool bRun;
        public void Start()
        {
            bRun = true;
            t.Start();
        }

        private void Run()
        {
            int count = 0;
            while (bRun)
            {
                CricketScore score = CricketScore.GetLatestScore();
                Console.WriteLine("publisher: update #{0} score={1}",++count, score);
                Notify(score);
                Thread.Sleep(1000);
            }
        }

        public void Stop()
        {
            bRun = false;
        }
    }
}
