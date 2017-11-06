using AddIn.Plugin.Views;
using System.AddIn;
using System.Windows;

namespace Plugin
{
    [AddIn(nameof(Plugin))]
    public class Plugin : IPlugin
    {
        private PluginControl _Control;

        public Plugin()
        {
            _Control = new PluginControl();
        }

        public FrameworkElement GetControl()
        {
            return _Control;
        }

        public double GetHeight()
        {
            _Control.Measure(new Size(double.PositiveInfinity, double.PositiveInfinity));

            return _Control.DesiredSize.Height;
        }
    }
}