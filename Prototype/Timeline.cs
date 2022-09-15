
namespace Prototype
{
    public class Timeline
    {
        private List<IComponent> components = new List<IComponent>();

        public void add(IComponent component)
        {
            components.Add(component);
        }

        public List<IComponent> GetComponents() 
        {
            return components;
        }
    }
}
