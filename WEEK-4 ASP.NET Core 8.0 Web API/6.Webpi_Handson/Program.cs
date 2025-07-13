class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Type 'send' to send a message or 'listen' to receive:");

        var input = Console.ReadLine();

        if (input == "send")
        {
            var producer = new Producer();

            while (true)
            {
                Console.Write("You: ");
                string message = Console.ReadLine();
                await producer.SendMessageAsync(message);
            }
        }
        else if (input == "listen")
        {
            var consumer = new Consumer();
            consumer.StartListening();
        }
    }
}
