using Confluent.Kafka;

public class Producer
{
    private readonly string topic = "chat-topic";

    public async Task SendMessageAsync(string message)
    {
        var config = new ProducerConfig { BootstrapServers = "localhost:9092" };

        using var producer = new ProducerBuilder<Null, string>(config).Build();
        var result = await producer.ProduceAsync(topic, new Message<Null, string> { Value = message });

        Console.WriteLine($"Message sent to {result.TopicPartitionOffset}");
    }
}
