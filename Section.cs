using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_pattern
{
    public class Section : IDocumentComponent
    {
        private string title;
        private List<IDocumentComponent> components = new List<IDocumentComponent>();

        public Section(string title)
        {
            this.title = title;
        }

        public void Add(IDocumentComponent component)
        {
            components.Add(component);
        }

        public void Remove(IDocumentComponent component)
        {
            components.Remove(component);
        }

        public void Display(int indent)
        {
            Console.WriteLine(new string(' ', indent) + title);
            foreach (var component in components)
            {
                component.Display(indent + 2);
            }
        }
    }
}
