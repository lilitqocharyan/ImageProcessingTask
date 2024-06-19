using ImageProcessing;
using ImageProcessing.Domains;
using System;
using System.Collections.Generic;

namespace Task_VectoDigital_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // loading plugins
            var processor = new ImageProcessor();
            processor.LoadPlugins();

            // images examples
            var images = new List<Image>
            {
                new Image("Image#1"),
                new Image("Image#2"),
                new Image("Image#3")
            };

            // effects examples
            var imageEffects = new List<List<(string effectName, object parameter)>>
            {
                new List<(string effectName, object parameter)>
                {
                    ("Resize", 100),
                    ("Blur", 2)
                },
                new List<(string effectName, object parameter)>
                {
                    ("Resize", 100)
                },
                new List<(string effectName, object parameter)>
                {
                    ("Resize", 150),
                    ("Blur", 5),
                    ("Grayscale", 70)
                }
            };

            // Applying effects to images
            for (int i = 0; i < images.Count; i++)
            {
                Console.WriteLine($"Processing {images[i]}");
                processor.ApplyEffects(images[i], imageEffects[i]);
                Console.WriteLine("-------------------------------");
            }

            Console.ReadKey();
        }
    }
}
