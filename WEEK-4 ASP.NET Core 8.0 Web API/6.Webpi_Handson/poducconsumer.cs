public class KafkaConsumer
{
    private readonly string topic = "chat-topic";
    private readonly Action<string> messageHandler;

    public KafkaConsumer(Action<string> handler)
    {
        messageHandler = handler;
    }

    public void Start()
    {
        Task.Run(() =>
        {
            var config = new ConsumerConfig
            {
                GroupId = Guid.NewGuid().ToString(),
                BootstrapServers = "localhost:9092",
                AutoOffsetReset = AutoOffsetReset.Earliest
            };

            using var consumer = new ConsumerBuilder<Ignore, string>(config).Build();
            consumer.Subscribe(topic);

            while (true)
            {
                var cr = consumer.Consume();
                messageHandler(cr.Message.Value);
            }
        });
    }
}
