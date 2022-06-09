using System;


namespace R5T.E0047.F002
{
    public class IdentityNameProvider : IIdentityNameProvider
    {
        #region Infrastructure

        public static IdentityNameProvider Instance { get; } = new();

        private IdentityNameProvider()
        {
        }

        #endregion
    }
}
