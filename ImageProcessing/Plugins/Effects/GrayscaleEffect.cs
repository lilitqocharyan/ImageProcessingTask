using ImageProcessing.Domains;
using ImageProcessing.Interfaces;
using System;

namespace ImageProcessing.Plugins
{
    public class GrayscaleEffect : IImageEffect
    {
        public void ApplyEffect(Image image, object parameter)
        {
            //some logic
            Console.WriteLine($"Converting {image.Name} to grayscale with intensity level {parameter}.");
        }
    }
}
