using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections;
using System.IO;

namespace VectorShapes
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();
            IConfiguration configuration;
            configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetParent(AppContext.BaseDirectory).FullName)
                .AddJsonFile("appsettings.json")
                .Build();
            serviceCollection.AddSingleton(configuration);

            Rectangle rectangle = new Rectangle(10, 10, 30, 40);
            Square square = new Square(15, 30, 35);
            Ellipse ellipse = new Ellipse(100, 150, 300, 200);
            Circle circle = new Circle(1, 1, 300);
            Textbox textbox = new Textbox(5, 5, 200, 100, "Sample Text");


            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("Requested Drawing");
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine(rectangle.PrintOut());
            Console.WriteLine(square.PrintOut());
            Console.WriteLine(ellipse.PrintOut());
            Console.WriteLine(circle.PrintOut());
            Console.WriteLine(textbox.PrintOut());
            Console.WriteLine("----------------------------------------------------------------");
        }
    }
}