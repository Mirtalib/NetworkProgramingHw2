using Client.Models;
using System.Net.Sockets;

var client = new TcpClient("127.0.0.1", 1234);

var stream = client.GetStream();

var bw = new BinaryWriter(stream);
var br = new BinaryReader(stream);

var CommandText = string.Empty;
var CommandParam = string.Empty;

while (true)
{
    Console.WriteLine("Enter Command Text");
    CommandText = Console.ReadLine();
    Console.WriteLine("Enter Command Param");
    CommandParam = Console.ReadLine();
    if (string.IsNullOrEmpty(CommandText) || string.IsNullOrEmpty(CommandParam))
    {
        Console.WriteLine("You entered an error, please try again");
        await Task.Delay(100);
        continue;
    }

    var command = new Command
    {
        Text = CommandText,
        Param = CommandParam
    };

}
