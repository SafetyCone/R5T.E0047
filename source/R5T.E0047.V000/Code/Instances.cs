using System;


namespace R5T.E0047.V000
{
    public static class Instances
    {
        public static T0119.IAssertion Assertion { get; } = T0119.Assertion.Instance;
        public static Z001.IIdentityNames IdentityNames { get; } = Z001.IdentityNames.Instance;
        public static F002.IIdentityNameProvider IdentityNameProvider { get; } = F002.IdentityNameProvider.Instance;
        public static F001.IReflectedInstanceContextProvider ReflectedInstanceContextProvider { get; } = F001.ReflectedInstanceContextProvider.Instance;
        public static F002.ITypeOperator TypeOperator { get; } = F002.TypeOperator.Instance;
    }
}