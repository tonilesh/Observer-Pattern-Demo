using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cricket;
using Patterns.Observer;

namespace CricketApp
{
    public class RecordKeeper:ISubscriber<CricketScore>
    {
        List<CricketScore> record = new List<CricketScore>();

        

        public void GetUpdate(CricketScore state)
        {
            record.Add(state);
            Console.WriteLine("Record Keeper:I have {0} records",record.Count);
        }

        
    }
}
