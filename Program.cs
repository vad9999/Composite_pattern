using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Document document = new Document();

            Section section1 = new Section("Introduction");
            section1.Add(new Paragraph("This is the introduction paragraph."));
            document.AddSection(section1);

            Section section2 = new Section("Main Content");
            section2.Add(new Paragraph("This is a paragraph in the main section."));

            Section subsection = new Section("Subsection");
            subsection.Add(new Paragraph("This is a paragraph in the subsection."));
            section2.Add(subsection);

            document.AddSection(section2);

            document.Display();

            document.RemoveSection(section1);

            document.Display();

            Document document2 = new Document();

            Section section3 = new Section("Introduction of document №2");
            section3.Add(new Paragraph("This is the introduction paragraph."));
            document2.AddSection(section3);

            Section subsection2 = new Section("Subsection of introduction");
            subsection2.Add(new Paragraph("This is a paragraph in the subsection."));
            section3.Add(subsection2);

            document2.Display();

            Console.Read();
        }
    }
}
