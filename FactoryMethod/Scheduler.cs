using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Scheduler
    {
        private Calendar calendar;

        public Scheduler() 
        {
            this.calendar = CreateCalendar();
        }

        protected virtual Calendar CreateCalendar()
        {
            return new GregorianCalendar();
        }

        public void schedule(Event newEvent) {
            var today = new DateTime();
            calendar.AddEvent(newEvent, today);
        }
    }
}
