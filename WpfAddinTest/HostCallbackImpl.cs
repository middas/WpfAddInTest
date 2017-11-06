using AddIn.Host.Views;
using System;

namespace WpfAddinTest
{
    internal class HostCallbackImpl : IHostCallback
    {
        public Func<double> _GetHeight = null;

        public double GetHeight()
        {
            if (_GetHeight != null)
            {
                return _GetHeight();
            }

            throw new NotImplementedException();
        }
    }
}