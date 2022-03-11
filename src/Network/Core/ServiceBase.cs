using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileShare.Network
{
    public abstract class ServiceBase : IService, IDisposable
    {
        protected Thread workingThread;

        public abstract void Start();

        public abstract void Stop();

        public void Dispose()
        {
            //workingThread?.A
        }
    }
}
