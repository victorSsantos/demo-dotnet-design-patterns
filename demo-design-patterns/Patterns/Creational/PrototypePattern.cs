using demo_design_patterns.creational.Prototype.Croncretes;
using demo_design_patterns.Interfaces;

namespace demo_design_patterns.Patterns.Creational
{
    public class PrototypePattern : IPattern
    {
        public void ExecutePattern()
        {
            var report = new Report("Report Test", "Some content reported");
            Console.Write("Source => ");
            report.Display();

            var clonedReport = report.Clone();
            Console.Write("Clone => ");
            clonedReport.Display();

            Console.WriteLine($"report == clonedReport ? {report == clonedReport}");

            var form = new Form("Form Test", "Form Description", "First Name", "Last Name");
            Console.Write("Source => ");
            form.Display();

            var clonedForm = form.Clone();
            Console.Write("Clone => ");
            clonedForm.Display();

            Console.WriteLine($"report == clonedReport ? {form == clonedForm}");
        }
    }
}
