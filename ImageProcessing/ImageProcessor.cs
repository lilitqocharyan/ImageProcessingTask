using ImageProcessing.Domains;
using ImageProcessing.Interfaces;
using ImageProcessing.Plugins;
using System;
using System.Collections.Generic;

namespace ImageProcessing
{
    public class ImageProcessor
    {
        private List<IImagePlugin> _plugins;
        private Dictionary<string, IImageEffect> _effects;

        public ImageProcessor()
        {
            _plugins = new List<IImagePlugin>();
            _effects = new Dictionary<string, IImageEffect>();
        }

        public void LoadPlugins()
        {
            _plugins.Add(new ResizePlugin());
            _plugins.Add(new BlurPlugin());
            _plugins.Add(new GrayscalePlugin());

            // Create effects
            foreach (var plugin in _plugins)
            {
                _effects[plugin.Name] = plugin.CreateEffect();
            }
        }


        public void ApplyEffects(Image image, List<(string effectName, object parameter)> effects)
        {
            foreach (var effect in effects)
            {
                if (_effects.ContainsKey(effect.effectName))
                {
                    _effects[effect.effectName].ApplyEffect(image, effect.parameter);
                }
                else
                {
                    Console.WriteLine($"{effect.effectName} effect not found.");
                }
            }
        }
    }
}
