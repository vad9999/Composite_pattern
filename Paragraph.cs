using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_pattern
{
    public class Paragraph : IDocumentComponent
    {
        private string text;

        public Paragraph(string text)
        {
            this.text = text;
        }

        public void Add(IDocumentComponent component)
        {
            throw new NotImplementedException("Cannot add to a paragraph.");
        }

        public void Remove(IDocumentComponent component)
        {
            throw new NotImplementedException("Cannot remove from a paragraph.");
        }

        public void Display(int indent)
        {
            Console.WriteLine(new string(' ', indent) + text);
        }
    }
}
