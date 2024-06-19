using ImageProcessing.Interfaces;

namespace ImageProcessing.Plugins
{
    public class GrayscalePlugin : IImagePlugin
    {
        public string Name => "Grayscale";

        public IImageEffect CreateEffect()
        {
            //some logic
            return new GrayscaleEffect();
        }
    }
}
