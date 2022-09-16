using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class GregorianCalendar: Calendar
    {
        public override void AddEvent(Event newEvent, DateTime date)
        {
            Console.WriteLine("Adding an event on the given date to Gregorian calendar.");
        }
    }
}
