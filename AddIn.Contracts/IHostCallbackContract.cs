using System.AddIn.Contract;

namespace AddIn.Contracts
{
    public interface IHostCallbackContract : IContract
    {
        double GetHeight();
    }
}