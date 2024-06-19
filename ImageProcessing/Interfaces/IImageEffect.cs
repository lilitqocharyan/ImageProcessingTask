using ImageProcessing.Domains;

namespace ImageProcessing.Interfaces
{
    public interface IImageEffect
    {
        void ApplyEffect(Image image, object parameter);
    }
}
