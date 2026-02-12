using System.Data.SQLite;

namespace telikiergasia2
{
    internal class stats
    {
        private string connectionString = "Data Source=Database.db;Version=3;";

        public string GetFirstQuestion()
        {
            return ExecuteSingleResult(
                "SELECT Question FROM Gamemode ORDER BY id ASC LIMIT 1");
        }

        public string GetLastQuestion()
        {
            return ExecuteSingleResult(
                "SELECT Question FROM Gamemode ORDER BY id DESC LIMIT 1");
        }

        public string GetLongestQuestion()
        {
            return ExecuteSingleResult(
                "SELECT Question FROM Gamemode ORDER BY LENGTH(Question) DESC LIMIT 1");
        }

        // Βοηθητική μέθοδος για να μην γράφουμε ίδιο κώδικα 3 φορές
        private string ExecuteSingleResult(string query)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
                {
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                        return result.ToString();
                    else
                        return "Δεν υπάρχουν δεδομένα.";
                }
            }
        }
    }
}
