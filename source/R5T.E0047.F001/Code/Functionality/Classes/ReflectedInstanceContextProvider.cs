using System;


namespace R5T.E0047.F001
{
    public class ReflectedInstanceContextProvider : IReflectedInstanceContextProvider
    {
        #region Infrastructure

        public static ReflectedInstanceContextProvider Instance { get; } = new();

        private ReflectedInstanceContextProvider()
        {
        }

        #endregion
    }
}
