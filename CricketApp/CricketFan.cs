using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cricket;
using Patterns.Observer;

namespace CricketApp
{
    class CricketFan:ISubscriber<CricketScore>
    {

        public void GetUpdate(CricketScore score)
        {
            Console.WriteLine("Cricket Fan:"+score);
        }

        
    }
}
