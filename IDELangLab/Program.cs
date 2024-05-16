namespace IDELangLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LangC c = new();
            LangCS cs = new LangCS();
            LangJava java = new LangJava();
            LangVB vB = new LangVB();
            IDE ide = new IDE();

            ide.Languages.Add(c);
            ide.Languages.Add(cs);
            ide.Languages.Add(java);
            ide.Languages.Add(vB);


            ide.DoWork();

        }
    }


    interface ILanguage
    {
        string GetName();
        string GetUnit();
        string GetParadigm();
    }

    class IDE // OCP
    {
        //public LangC C { get; set; }
        //public LangCS CS { get; set; }
        //public LangJava Java { get; set; }
        //public LangVB VB { get; set; }

        public List<ILanguage> Languages { get; set; } = new List<ILanguage>();

        public void DoWork()
        {

            foreach (ILanguage l in Languages)
            {
                Console.WriteLine(l.GetName());
                Console.WriteLine(l.GetUnit());
                Console.WriteLine(l.GetParadigm());
            }
            //Console.WriteLine("Lang CSharp");
            //Console.WriteLine(CS.GetName());
            //Console.WriteLine(CS.GetUnit());
            //Console.WriteLine(CS.GetParadigm());
            //Console.WriteLine("Lang Java");
            //Console.WriteLine(Java.GetName());
            //Console.WriteLine(Java.GetUnit());
            //Console.WriteLine(Java.GetParadigm());
            //Console.WriteLine("Lang VB");
            //Console.WriteLine(VB.GetName());
            //Console.WriteLine(VB.GetUnit());
            //Console.WriteLine(VB.GetParadigm());
        }
    }

    abstract class ObjectOriented
    {
        public string GetUnit()
        {
            return "Class";
        }
        public string GetParadigm()
        {
            return "Object Oriented";
        }
    }

    abstract class Procedural
    {
        public string GetUnit()
        {
            return "Function";
        }
        public string GetParadigm()
        {
            return "Procedural";
        }
    }

    class LangCS : ObjectOriented, ILanguage
    {

        public string GetName()
        {
            return "CSharp";
        }
    }
    class LangJava : ObjectOriented, ILanguage
    {

        public string GetName()
        {
            return "Java";
        }
    }
    class LangC : Procedural, ILanguage
    {

        public string GetName()
        {
            return "C Language";
        }
    }

    class LangVB : ObjectOriented, ILanguage // OCP
    {

        public string GetName()
        {
            return "Visual Basic";
        }
    }
}
