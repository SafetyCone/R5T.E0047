using System;
using System.Reflection;

using R5T.T0132;


namespace R5T.E0047.F002
{
    [DraftFunctionalityMarker]
    public interface IIdentityNameProvider : IDraftFunctionalityMarker
    {
        public string GetIdentityName(TypeInfo typeInfo)
        {
            var isType = Instances.TypeOperator.IsType(typeInfo);
            if(isType)
            {
                var output = this.GetIdentityForType(typeInfo);
                return output;
            }

            throw new Exception("IdentityName for type not implemented.");
        }

        public string GetIdentityForType(TypeInfo typeInfo)
        {
            var output = $"T:{typeInfo.FullName}";
            return output;
        }
    }
}
