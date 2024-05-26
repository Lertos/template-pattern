namespace template_pattern
{
    //A demonstration of the Template pattern in C#
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====");
            new Process().Start();
            Console.WriteLine("====");
            new Variation1().Start();
            Console.WriteLine("====");
            new Variation2().Start();
            Console.WriteLine("====");
            new Variation3().Start();
            Console.WriteLine("====");

            /* OUTPUT: 
             
                ====
                Step 1
                Step 2
                Step 3
                ====
                Step 1 adapted
                Step 2
                Step 3
                ====
                Step 1
                Step 2 adapted
                Step 3
                ====
                Step 1
                Step 2 super adapted
                Step 3 adapted
                ====
             
             */
        }
    }

    public class Process
    {
        public void Start()
        {
            Step1();
            Step2();
            Step3();
        }

        protected virtual void Step1() { Console.WriteLine("Step 1"); }
        protected virtual void Step2() { Console.WriteLine("Step 2"); }
        protected virtual void Step3() { Console.WriteLine("Step 3"); }
    }

    public class Variation1 : Process
    {
        protected override void Step1() { Console.WriteLine("Step 1 adapted"); }
    }

    public class Variation2 : Process
    {
        protected override void Step2() { Console.WriteLine("Step 2 adapted"); }
    }

    public class Variation3 : Process
    {
        protected override void Step2() { Console.WriteLine("Step 2 super adapted"); }
        protected override void Step3() { Console.WriteLine("Step 3 adapted"); }
    }
}
