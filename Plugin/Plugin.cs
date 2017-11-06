using AddIn.Plugin.Views;
using System.AddIn;
using System.Windows;

namespace Plugin
{
    [AddIn(nameof(Plugin))]
    public class Plugin : IPlugin
    {
        private IHostCallback _Callback;
        private PluginControl _Control;

        public Plugin()
        {
            _Control = new PluginControl();
        }

        public FrameworkElement GetControl()
        {
            if (_Callback != null)
            {
                _Control.SetHeight(_Callback.GetHeight());
            }

            return _Control;
        }

        public double GetHeight()
        {
            _Control.Measure(new Size(double.PositiveInfinity, double.PositiveInfinity));

            return _Control.DesiredSize.Height;
        }

        public void SetHostCallback(IHostCallback callback)
        {
            _Callback = callback;
        }
    }
}