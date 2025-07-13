public partial class ChatForm : Form
{
    private KafkaProducer producer;

    public ChatForm()
    {
        InitializeComponent();
        producer = new KafkaProducer();

        var consumer = new KafkaConsumer(DisplayMessage);
        consumer.Start();
    }

    private async void btnSend_Click(object sender, EventArgs e)
    {
        string msg = txtMessage.Text;
        await producer.SendAsync(msg);
        txtMessage.Clear();
    }

    private void DisplayMessage(string msg)
    {
        if (InvokeRequired)
        {
            Invoke(new Action<string>(DisplayMessage), msg);
        }
        else
        {
            lstMessages.Items.Add("Received: " + msg);
        }
    }
}
