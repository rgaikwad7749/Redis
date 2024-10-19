using System; // Importing the System namespace for basic functionalities
using StackExchange.Redis; // Importing StackExchange.Redis for Redis operations

namespace LeaderBoard // Defining the namespace for the application
{
    internal class Program // Main class of the application
    {
        // Creating a static readonly instance of ConnectionMultiplexer to manage Redis connections
        private static readonly ConnectionMultiplexer redis = ConnectionMultiplexer.Connect("localhost:6379");
        private static IDatabase db; // Database variable to interact with Redis

        // Entry point of the application
        static void Main(string[] args)
        {
            db = redis.GetDatabase();

            // Clear the existing leaderboard for fresh start
            db.KeyDelete("leaderboard1");

            // Example operations for leaderboard
            CreateLeaderboard(); // Method call to create and populate the leaderboard

            DisplayLeaderboard(); // Method call to display the current leaderboard

            Console.WriteLine("Adding new record...");
            bool isAdded = db.SortedSetAdd("leaderboard1", "Player4", 80); // Adding Player4 with a score of 80
            Console.WriteLine($"Player4 added/updated: {isAdded}"); // Debugging if Player4 was added

            DisplayLeaderboard(); // Display the updated leaderboard
        }

        // Method to create and populate the leaderboard
        private static void CreateLeaderboard()
        {
            // Adding scores for players to a sorted set named "leaderboard1"
            db.SortedSetAdd("leaderboard1", "Player1", 100); // Player1 with a score of 100
            db.SortedSetAdd("leaderboard1", "Player2", 200); // Player2 with a score of 200
            db.SortedSetAdd("leaderboard1", "Player3", 150); // Player3 with a score of 150
        }

        // Method to retrieve and display the leaderboard
        private static void DisplayLeaderboard()
        {
            // Retrieve and display leaderboard entries sorted by score in descending order
            var leaderboard = db.SortedSetRangeByRankWithScores("leaderboard1", 0, -1, Order.Descending);

            Console.WriteLine("Leaderboard1:");
            foreach (var entry in leaderboard) // Iterate through each entry in the leaderboard
            {
                Console.WriteLine($"{entry.Element}: {entry.Score}"); // Print player name and score
            }
        }
    }
}
