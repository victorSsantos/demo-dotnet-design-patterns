using demo_design_patterns.Interfaces;

namespace demo_design_patterns.Patterns
{
    public class Pattern(IPattern demo)
    {
        private readonly IPattern _demo = demo;

        public void Run()
        {
            _demo.ExecutePattern();
        }
    }
}
