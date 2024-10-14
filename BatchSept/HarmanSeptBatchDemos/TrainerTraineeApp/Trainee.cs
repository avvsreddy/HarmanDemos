namespace TrainerTraineeApp
{
    class Trainee
    {
        public Trainer Trainer { get; set; }
        public List<Training> Trainings { get; set; } = new List<Training>();
    }
}
