using System;
using System.Threading.Tasks;
using StackExchange.Redis;

namespace RedisPubSub
{
    internal class Program
    {
        private const string RedisConnectionString = "localhost";
        // Connection string for Redis

        private const string ChannelName = "my-channel";
        // Name of the channel for Pub/Sub

        static void Main(string[] args)
        {
            // Create a connection to the Redis server
            var connection = ConnectionMultiplexer.Connect(RedisConnectionString);
            var subscriber = connection.GetSubscriber();
            // Get the subscriber instance

            // Subscribe to the channel and define the message handling logic
            subscriber.Subscribe(ChannelName, (channel, message) =>
            {
                Console.WriteLine($"Received message: {message}");
            });

            Console.WriteLine("Subscribed to channel. Press any key to publish a message...");
            Console.ReadKey();
            // Wait for user input before publishing

            SubscriberMethod(subscriber);
            Console.ReadKey();
        }

        private static async Task SubscriberMethod(ISubscriber subscriber)
        {
            // Publish a message to the channel
            await subscriber.PublishAsync(ChannelName, "Hello, world!");
            Console.WriteLine("Message published!");

            // Keep the application running to listen for messages
            Console.WriteLine("Press any key to exit...");
        }
    }
}
