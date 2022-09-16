using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class ArabianScheduler: Scheduler
    {
        protected override Calendar CreateCalendar()
        {
            return new ArabianCalendar();
        }
    }
}
