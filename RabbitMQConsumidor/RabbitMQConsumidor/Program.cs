using RabbitMQ.Client.Events;
using RabbitMQ.Client;
using System.Text;

string queueNameDTF = "openwebinars.queue.DTF";
string queueNameFT = "openwebinars.queue.FT";
string queueNameF = "openwebinars.queue.F";

Console.WriteLine($"Comenzamos a escuchar los mensajes que llegan a la cola: {queueNameDTF}");
Console.WriteLine($"Comenzamos a escuchar los mensajes que llegan a la cola: {queueNameFT}");
Console.WriteLine($"Comenzamos a escuchar los mensajes que llegan a la cola: {queueNameF}");

var factory = new ConnectionFactory();
var connection = factory.CreateConnection();

var channel = connection.CreateModel();
var consumerExchangeDirect = new EventingBasicConsumer(channel);

consumerExchangeDirect.Received += (model, ea) =>
{
    var body = ea.Body.ToArray();
    var message = Encoding.UTF8.GetString(body);
    Console.WriteLine($" [x] Desde openwebinars.exchange.direct. Mensaje recibido:\n {message}. \nFecha y hora de recepción: {DateTime.Now}");
};


var consumerExchangeFanout = new EventingBasicConsumer(channel);

consumerExchangeFanout.Received += (model, ea) =>
{
    var body = ea.Body.ToArray();
    var message = Encoding.UTF8.GetString(body);
    Console.WriteLine($" [x] Desde openwebinars.exchange.fanout. Mensaje recibido:\n {message}. \nFecha y hora de recepción: {DateTime.Now}");
};


var consumerExchangeTopic = new EventingBasicConsumer(channel);

consumerExchangeTopic.Received += (model, ea) =>
{
    var body = ea.Body.ToArray();
    var message = Encoding.UTF8.GetString(body);
    Console.WriteLine($" [x] Desde openwebinars.exchange.fanout. Mensaje recibido:\n {message}. \nFecha y hora de recepción: {DateTime.Now}");
};


channel.BasicConsume(queue: queueNameDTF, autoAck: true, consumer: consumerExchangeDirect);
channel.BasicConsume(queue: queueNameFT, autoAck: true, consumer: consumerExchangeFanout);
channel.BasicConsume(queue: queueNameF, autoAck: true, consumer: consumerExchangeTopic);
Console.ReadLine();