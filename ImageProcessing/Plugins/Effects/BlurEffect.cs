using ImageProcessing.Domains;
using ImageProcessing.Interfaces;
using System;

namespace ImageProcessing.Plugins
{
    public class BlurEffect : IImageEffect
    {
        public void ApplyEffect(Image image, object parameter)
        {
            //some logic
            Console.WriteLine($"Blurring {image.Name} with size {parameter} pixels.");
        }
    }
}
