using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cricket;
using Patterns.Observer;

namespace CricketApp
{
    public class CricketAnalyst:ISubscriber<CricketScore>
    {

        

        public void GetUpdate(CricketScore score)
        {
            string message = "Wait and Watch";
            if (score.RunRate > 6 && (score.Wickets < 4 || score.Balls > 38 * 6))
                message = "Winning combo";
            else if (score.RunRate < 5 && (score.Wickets > 6 || score.Balls > 35 * 6))
                message = "Switch off TV";


            Console.WriteLine("Cricket Analyst:"+message);
        }

        
    }
}
