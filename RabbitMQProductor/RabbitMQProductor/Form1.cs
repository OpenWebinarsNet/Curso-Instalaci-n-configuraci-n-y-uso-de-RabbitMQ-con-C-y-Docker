using RabbitMQ.Client;
using System.Text;

namespace RabbitMQProductor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDirect_Click(object sender, EventArgs e)
        {
            var factory = new ConnectionFactory();
            using var connection = factory.CreateConnection();
            using var channel = connection.CreateModel();

            string message = $"{txtMensaje.Text}. Mensaje enviado desde productor a las {DateTime.Now} vía Direct Exchange";            
            var body = Encoding.UTF8.GetBytes(message);
            PublishMessageToExchangeDirect(channel, body);

            channel?.Dispose();
            connection?.Dispose();
            txtMensaje.Clear();

        }

        private void btnTopic_Click(object sender, EventArgs e)
        {
            var factory = new ConnectionFactory();
            using var connection = factory.CreateConnection();
            using var channel = connection.CreateModel();

            string message = $"{txtMensaje.Text}. Mensaje enviado desde productor a las {DateTime.Now} vía Topic Exchange";
            Console.WriteLine(message);
            var body = Encoding.UTF8.GetBytes(message);

            PublishMessageToExchangeTopic(channel, body);
            channel?.Dispose();
            connection?.Dispose();
            txtMensaje.Clear();
        }       

        private void btnFanout_Click(object sender, EventArgs e)
        {
            var factory = new ConnectionFactory();
            using var connection = factory.CreateConnection();
            using var channel = connection.CreateModel();

            string message = $"{txtMensaje.Text}. Mensaje enviado desde productor a las {DateTime.Now} vía Fanout Exchange";
            Console.WriteLine(message);
            var body = Encoding.UTF8.GetBytes(message);

            PublishMessageToExchangeFanout(channel, body);

            channel?.Dispose();
            connection?.Dispose();
            txtMensaje.Clear();
        }        

        private void PublishMessageToExchangeDirect(IModel channel, byte[] body)
        {
            channel.BasicPublish(
                        exchange: "openwebinars.exchange.direct",
                        routingKey: "routingKey1",
                        basicProperties: null,
                        body: body);
        }

        private void PublishMessageToExchangeTopic(IModel channel, byte[] body)
        {
            channel.BasicPublish(
                                    exchange: "openwebinars.exchange.topic",
                                    routingKey: "openwebinars.rabbitmqtests.*",
                                    basicProperties: null,
                                    body: body);
        }

        private void PublishMessageToExchangeFanout(IModel channel, byte[] body)
        {
            channel.BasicPublish(
                        exchange: "openwebinars.exchange.fanout",
                        routingKey: "",
                        basicProperties: null,
                        body: body);
        }

    }
}