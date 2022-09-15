
namespace Prototype
{
    public class ContextMenu
    {
        private Timeline timeline;

        public ContextMenu(Timeline timeline)
        {
            this.timeline = timeline;
        }

        public void duplicate(IComponent component)
        {
            var newComponent = component.Duplicate();
            timeline.add(newComponent);
        }

        public void Play() 
        {
            foreach (var c in timeline.GetComponents()) 
            {
                Console.WriteLine(c.GetContent());
            }
        }
    }
}
