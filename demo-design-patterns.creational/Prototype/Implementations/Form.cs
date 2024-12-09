using demo_design_patterns.creational.Prototype.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_design_patterns.creational.Prototype.Croncretes
{
    public class Form() : IDocument
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string? Field1 { get; set; } = string.Empty;
        public string? Field2 { get; set; } = string.Empty;


        public Form(string title, string description, string? field1 = null, string? field2 = null) : this()
        {
            Title = title;
            Description = description;
            Field1 = field1;
            Field2 = field2;
        }

        public IDocument Clone()
        {
            return new Form(Title, Description, Field1, Field2);
        }

        public void Display()
        {
            Console.WriteLine($"{{\"Form\": {{\"Title\": \"{Title}\", " +
                $"\"Description\": \"{Description}\", \"Field1\": \"{Field1}\", \"Field2\": \"{Field2}\"}}}}");
        }
    }
}
