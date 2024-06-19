using ImageProcessing.Domains;
using ImageProcessing.Interfaces;
using System;

namespace ImageProcessing.Plugins
{
    public class ResizeEffect : IImageEffect
    {
        public void ApplyEffect(Image image, object parameter)
        {
            //some logic
            Console.WriteLine($"Resizing {image.Name} to {parameter} pixels.");
        }

    }
}
