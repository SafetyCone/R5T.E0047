using System;


namespace R5T.E0047.F002
{
    public static class Instances
    {
        public static IIdentityNameProvider IdentityNameProvider { get; } = F002.IdentityNameProvider.Instance;
        public static F001.IReflectedInstanceContextProvider ReflectedInstanceContextProvider { get; } = F001.ReflectedInstanceContextProvider.Instance;
        public static ITypeOperator TypeOperator { get; } = F002.TypeOperator.Instance;
    }
}