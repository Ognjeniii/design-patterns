using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.Singleton
{
    // we check class as sealed to prevent anybody from deriving and 
    // changing that behavior
    public sealed class MySingletonClass : IDisposable
    {
        private bool _disposed;
        // the volatile keyword ensures that the instantiation is complete 
        // before it can be accessed further helping with thread safety.
        private static volatile MySingletonClass _instance;
        private static readonly object _syncLock = new object();

        private MySingletonClass() { }

        // uses a pattern known as double check locking
        public static MySingletonClass Instance
        {
            get
            {
                if (_instance != null)
                    return _instance;
                // removed double lock because this is fixed in C# 6
                lock (_syncLock)
                {
                    if (_instance == null)
                    {
                        _instance = new MySingletonClass();
                    }
                }
                return _instance;
            }
        }

        public int SomeValue { get; set; }


        // not a singleton pattern
        // do not make this method virtual.
        // a derived class should not be able to override this method.
        public void Dispose()
        {
            Dispose(true);
            // this object will be cleaned up by the Dispose method
            // Therefore, you should call GC.SupressFinalize to (GC - GarbageCollector)
            // take this object off the finalization queue
            // and prevent fnalization code for this object
            // from executing a second time.
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            // check to see if Dispose has already been called.
            if (_disposed) 
                return;

            // if disposing equals true, dispose  all managed and unmanaged resources.
            if (disposing)
            {
                _instance = null;
                // Dispose managed resources.
            }
        }
    }
}
