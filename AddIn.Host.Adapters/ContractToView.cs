using AddIn.Contracts;
using AddIn.Host.Views;
using System.AddIn.Pipeline;
using System.Windows;

namespace AddIn.Host.Adapters
{
    [HostAdapter]
    public class ContractToView : IPlugin
    {
        private IPluginContract _contract;
        private ContractHandle _handle;

        public ContractToView(IPluginContract contract)
        {
            _contract = contract;
            _handle = new ContractHandle(_contract);
        }

        public FrameworkElement GetControl()
        {
            var inhc = _contract.GetControl();
            var fe = FrameworkElementAdapters.ContractToViewAdapter(inhc);

            return fe;
        }

        public double GetHeight()
        {
            return _contract.GetHeight();
        }

        public void SetHostCallback(IHostCallback callback)
        {
            _contract.SetHostCallback(new HostCallbackViewToContract(callback));
        }
    }
}