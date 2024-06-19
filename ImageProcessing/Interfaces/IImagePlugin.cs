namespace ImageProcessing.Interfaces
{
    public interface IImagePlugin
    {
        string Name { get; }
        IImageEffect CreateEffect();
    }
}
