using Castle.Windsor;

namespace Tas.Framework
{
    public sealed class DependencyContainer
    {
        private static WindsorContainer _Instance;
        private static object _Lock = new object();

        private DependencyContainer() {}

        public static WindsorContainer Instance
        {
            get
            {
                lock (_Lock)
                {
                    if (_Instance == null)
                    {
                        _Instance = new WindsorContainer();
                    }

                    return _Instance;
                }                
            }
        }
    }
}
