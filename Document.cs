using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_pattern
{
    public class Document
    {
        private List<IDocumentComponent> sections = new List<IDocumentComponent>();

        public void AddSection(IDocumentComponent section)
        {
            sections.Add(section);
        }

        public void RemoveSection(IDocumentComponent section)
        {
            sections.Remove(section);
        }

        public void Display()
        {
            foreach (var section in sections)
            {
                section.Display(0);
            }
        }
    }
}
