using ImageProcessing.Interfaces;

namespace ImageProcessing.Plugins
{
    public class BlurPlugin : IImagePlugin
    {
        public string Name => "Blur";

        public IImageEffect CreateEffect()
        {
            //some logic
            return new BlurEffect();
        }
    }
}
