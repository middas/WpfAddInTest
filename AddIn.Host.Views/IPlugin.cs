using System.AddIn.Contract;
using System.Windows;

namespace AddIn.Host.Views
{
    public interface IPlugin
    {
        FrameworkElement GetControl();

        double GetHeight();

        void SetHostCallback(IHostCallback callback);
    }
}