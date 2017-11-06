using AddIn.Contracts;
using AddIn.Plugin.Views;
using System.AddIn.Pipeline;

namespace AddIn.Plugin.Adapters
{
    internal class HostCallbackContractToView : IHostCallback
    {
        private IHostCallbackContract _contract;
        private ContractHandle _handle;

        public HostCallbackContractToView(IHostCallbackContract contract)
        {
            _contract = contract;
            _handle = new ContractHandle(_contract);
        }

        public double GetHeight()
        {
            return _contract.GetHeight();
        }
    }
}