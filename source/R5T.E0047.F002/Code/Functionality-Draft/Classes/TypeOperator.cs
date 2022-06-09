using System;


namespace R5T.E0047.F002
{
    public class TypeOperator : ITypeOperator
    {
        #region Infrastructure

        public static TypeOperator Instance { get; } = new();

        private TypeOperator()
        {
        }

        #endregion
    }
}
