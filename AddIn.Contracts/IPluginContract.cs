using System.AddIn.Contract;
using System.AddIn.Pipeline;

namespace AddIn.Contracts
{
    [AddInContract]
    public interface IPluginContract : IContract
    {
        INativeHandleContract GetControl();

        double GetHeight();

        void SetHostCallback(IHostCallbackContract callback);
    }
}