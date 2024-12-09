using demo_design_patterns.creational.Prototype.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_design_patterns.creational.Prototype.Croncretes
{
    public class Report() : IDocument
    {
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;

        public Report(string title, string content) : this()
        {
            Title = title;
            Content = content;
        }

        public IDocument Clone()
        {
            return new Report(Title, Content);
        }

        public void Display()
        {
            Console.WriteLine($"{{\"Report\": {{\"Title\": \"{Title}\", {{\"Content\": \"{Content}\"}}}}");
        }
    }
}
