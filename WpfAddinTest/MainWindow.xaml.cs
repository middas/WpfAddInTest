using AddIn.Host.Views;
using System;
using System.AddIn.Hosting;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace WpfAddinTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly string _AddInPath;
        private readonly string _PluginPath;

        private AddInToken _PluginToken;
        private IPlugin _Plugin;

        public MainWindow()
        {
            _PluginPath = System.IO.Path.Combine(Environment.CurrentDirectory, "Pipeline");
            _AddInPath = System.IO.Path.Combine(_PluginPath, "AddIns");

            InitializeComponent();

            var warnings = new List<string>(AddInStore.Update(_PluginPath));

            _PluginToken = AddInStore.FindAddIns(typeof(IPlugin), _PluginPath, _AddInPath).FirstOrDefault();
            _Plugin = _PluginToken.Activate<IPlugin>(AddInSecurityLevel.FullTrust);

            HostCallbackImpl impl = new HostCallbackImpl
            {
                _GetHeight = () =>
                {
                    return 300;
                }
            };
            _Plugin.SetHostCallback(impl);

            var control = _Plugin.GetControl();
            //PluginHolder.Height = _Plugin.GetHeight();

            PluginHolder.Content = control;
        }
    }
}