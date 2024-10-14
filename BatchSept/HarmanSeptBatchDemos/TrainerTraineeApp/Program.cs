namespace TrainerTraineeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Training training = new Training();
            Trainer trainer = new Trainer();
            training.Trainer = trainer;

            Orgranization org = new Orgranization();
            org.Name = "EdForce";
            trainer.Orgranization = org;

            Console.WriteLine($"Organization Name: {training.GetOrganizationName()}");

            Trainee t1 = new Trainee();
            Trainee t2 = new Trainee();
            Trainee t3 = new Trainee();

            training.Trainees.Add(t1);
            training.Trainees.Add(t2);
            training.Trainees.Add(t3);


            Console.WriteLine($"No. of Trainees: {training.GetTraineesCount()}");

            Course course = new Course();
            training.Course = course;

            Module m1 = new Module();
            Module m2 = new Module();
            course.Modules.Add(m1);
            course.Modules.Add(m2);

            Unit u1 = new Unit { Duration = 20 };
            Unit u2 = new Unit { Duration = 60 };
            Unit u3 = new Unit { Duration = 120 };
            Unit u4 = new Unit { Duration = 10 };

            m1.Units.Add(u1);
            m1.Units.Add(u2);
            m2.Units.Add(u3);
            m2.Units.Add(u4);

            Console.WriteLine($"Training Duration: {training.GetTrainingDuration()}");
        }
    }
}
