namespace TrainerTraineeApp
{
    class Trainer
    {
        public Orgranization Orgranization { get; set; }
        public List<Trainee> Trainees { get; set; } = new List<Trainee>();
        public List<Training> Trainings { get; set; } = new List<Training>();
    }
}
