public class KafkaProducer
{
    private readonly string topic = "chat-topic";
    private readonly IProducer<Null, string> producer;

    public KafkaProducer()
    {
        var config = new ProducerConfig { BootstrapServers = "localhost:9092" };
        producer = new ProducerBuilder<Null, string>(config).Build();
    }

    public async Task SendAsync(string msg)
    {
        await producer.ProduceAsync(topic, new Message<Null, string> { Value = msg });
    }
}
