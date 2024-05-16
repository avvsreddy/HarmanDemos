namespace TrainerTraineeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Organization org = new Organization();

        }
    }
    class Organization
    {
        public string Name { get; set; } // Property

    }
    class Trainer
    {
        public Organization TheOrganization { get; set; }
        public List<Trainee> Trainees { get; set; } = new List<Trainee>();
        public List<Training> Trainings { get; set; } = new List<Training>();
    }
    class Trainee
    {
        public Trainer Trainer { get; set; }
    }
    class Training
    {
        public List<Trainee> Trainees { get; set; } = new List<Trainee>();
        public Trainer Trainer { get; set; }
        public Course Course { get; set; }

    }
    class Course
    {
        public List<Module> Modules { get; set; } = new List<Module>();
    }
    class Module
    {
        public List<Unit> Units { get; set; } = new List<Unit>();
    }
    class Unit
    {
        public int Duration { get; set; }
        public List<Topic> Topics { get; set; } = new List<Topic>();
    }
    class Topic
    {

    }
}
