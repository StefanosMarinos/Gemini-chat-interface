namespace telikiergasia2
{
    // Αντιπροσωπεύει μία εγγραφή από τον πίνακα Gamemode
    internal class Question
    {
        public int Id { get; set; }        // Το id της ερώτησης
        public string Text { get; set; }   // Το κείμενο της ερώτησης

        public Question(int id, string text)
        {
            Id = id;
            Text = text;
        }
    }
}
