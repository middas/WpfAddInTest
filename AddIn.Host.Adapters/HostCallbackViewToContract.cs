using AddIn.Contracts;
using AddIn.Host.Views;
using System.AddIn.Pipeline;

namespace AddIn.Host.Adapters
{
    internal class HostCallbackViewToContract : ContractBase, IHostCallbackContract
    {
        private IHostCallback _view;

        public HostCallbackViewToContract(IHostCallback view)
        {
            _view = view;
        }

        public double GetHeight()
        {
            return _view.GetHeight();
        }
    }
}