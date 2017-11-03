using AddIn.Plugin.Views;
using System;
using System.AddIn;
using System.AddIn.Contract;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Plugin
{
    [AddIn(nameof(Plugin))]
    public class Plugin : IPlugin
    {
        public FrameworkElement GetControl()
        {
            return new PluginControl();
        }

        public int GetInt()
        {
            return 5;
        }
    }
}
