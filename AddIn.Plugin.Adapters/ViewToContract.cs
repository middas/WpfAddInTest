using AddIn.Contracts;
using AddIn.Plugin.Views;
using System.AddIn.Contract;
using System.AddIn.Pipeline;

namespace AddIn.Plugin.Adapters
{
    [AddInAdapter]
    public class ViewToContract : ContractBase, IPluginContract
    {
        private IPlugin _view;

        public ViewToContract(IPlugin view)
        {
            _view = view;
        }

        public INativeHandleContract GetControl()
        {
            var fe = _view.GetControl();
            var inhc = FrameworkElementAdapters.ViewToContractAdapter(fe);

            return inhc;
        }

        public int GetInt()
        {
            return _view.GetInt();
        }
    }
}