using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cricket
{
    public class CricketScore
    {
        

        private int _runs;
        public int Runs
        {
            get { return _runs; }

        }

        private int _balls;
        public int Balls
        {
            get { return _balls; }

          
        }


        private int _wickets;
        public int Wickets
        {
            get { return _wickets; }

           
        }

        public double RunRate
        {
            get
            {
                return Runs / (Balls / 6.0);
            }
        }

        public override string ToString()
        {
            return string.Format("{0}/{1} {2}.{3}overs ({4} rr)",
                                Runs, Wickets,
                                Balls / 6, Balls % 6, RunRate);
        }

        private CricketScore()
        {

        }


        public static CricketScore GetLatestScore()
        {
            CricketScore score = new CricketScore();
            Random r=new Random();
            score._balls = r.Next(30, 270);
            double rr = r.NextDouble() * 4 + 3;
            score._runs = (int)((score._balls / 6) * rr);
            score._wickets = r.Next(0, 10);

            return score;
            
        }
			
    }
}
