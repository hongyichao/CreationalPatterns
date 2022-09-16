
namespace FactoryMethod
{
    public class Calendar
    {
        public virtual void AddEvent(Event newEvent, DateTime date) 
        {
            Console.WriteLine("Adding an event on the given date."); 
        }
    }
}
