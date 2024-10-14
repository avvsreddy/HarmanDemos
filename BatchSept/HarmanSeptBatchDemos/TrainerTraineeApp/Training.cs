namespace TrainerTraineeApp
{
    class Training
    {
        public Trainer Trainer { get; set; } // HAS-A
        public List<Trainee> Trainees { get; set; } = new List<Trainee>();
        public Course Course { get; set; }


        public string GetOrganizationName()
        {
            // Trainer t = new Trainer(); // Uses
            return Trainer.Orgranization.Name;

        }

        public int GetTraineesCount()
        {
            return Trainees.Count;
        }

        public int GetTrainingDuration()
        {
            int totDuration = 0;
            // foreach module in a course
            foreach (var module in Course.Modules)
            {
                // for each unit in a module
                foreach (var unit in module.Units)
                {
                    totDuration += unit.Duration;
                }
            }
            return totDuration;


        }

    }
}
