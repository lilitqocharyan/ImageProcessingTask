using ImageProcessing.Interfaces;

namespace ImageProcessing.Plugins
{
    public class ResizePlugin : IImagePlugin
    {
        public string Name => "Resize";

        public IImageEffect CreateEffect()
        {
            //some logic
            return new ResizeEffect();
        }
    }
}
