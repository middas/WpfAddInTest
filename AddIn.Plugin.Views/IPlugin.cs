using System.AddIn.Pipeline;
using System.Windows;

namespace AddIn.Plugin.Views
{
    [AddInBase]
    public interface IPlugin
    {
        FrameworkElement GetControl();

        double GetHeight();
    }
}