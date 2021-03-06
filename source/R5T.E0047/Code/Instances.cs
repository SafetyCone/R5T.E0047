using System;

using R5T.T0062;
using R5T.T0070;


namespace R5T.E0047
{
    public static class Instances
    {
        public static IHost Host { get; } = T0070.Host.Instance;
        public static F002.IIdentityNameProvider IdentityNameProvider { get; } = F002.IdentityNameProvider.Instance;
        public static F001.IReflectedInstanceContextProvider ReflectedInstanceContextProvider { get; } = F001.ReflectedInstanceContextProvider.Instance;
        public static IServiceAction ServiceAction { get; } = T0062.ServiceAction.Instance;
        public static F002.ITypeOperator TypeOperator { get; } = F002.TypeOperator.Instance;
    }
}