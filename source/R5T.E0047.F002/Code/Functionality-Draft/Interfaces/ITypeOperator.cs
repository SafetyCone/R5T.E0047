using System;
using System.Reflection;

using R5T.T0132;


namespace R5T.E0047.F002
{
    [DraftFunctionalityMarker]
    public interface ITypeOperator : IDraftFunctionalityMarker
    {
        /// <summary>
        /// A type is a class, interface, struct, enum, or delegate.
        /// </summary>
        public bool IsType(TypeInfo typeInfo)
        {
            var output = typeInfo.IsTypeDefinition;
            return output;
        }
    }
}
