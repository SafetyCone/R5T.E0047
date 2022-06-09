using System;


namespace R5T.E0047.Z001
{
    public class IdentityNames : IIdentityNames
    {
        #region Infrastructure

        public static IdentityNames Instance { get; } = new();

        private IdentityNames()
        {
        }

        #endregion
    }
}
