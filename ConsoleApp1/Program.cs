using System;
using System.Threading.Tasks;

namespace ConsoleApp1{
    class Program {
        static async Task Main(string[] args) {
            ServiceReference1.SOAPDemoSoapClient client = new ServiceReference1.SOAPDemoSoapClient();
            var response = await client.AddIntegerAsync(1, 5);
            Console.WriteLine($"{response.ToString()}");


            var response2 = await client.DivideIntegerAsync(10, 2);
            Console.WriteLine($"{response2.ToString()}");


            
            var response3 = await client.FindPersonAsync("20");
            Console.WriteLine($"{response3.Name}");
            
        }

    }
}

