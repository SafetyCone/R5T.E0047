using System;
using System.Linq;
using System.Reflection;

using R5T.T0132;


namespace R5T.E0047.F001
{
    [FunctionalityMarker]
    public interface IReflectedInstanceContextProvider : IFunctionalityMarker
    {
        public TOut InExampleTypeContext<TOut>(
            string typeName,
            Func<TypeInfo, TOut> typeInfoFunction)
        {
            var output = Instances.ReflectionOperations.InAssemblyContext(
                Instances.FilePathProvider.GetExamplesAssemblyFilePath(),
                assembly =>
                {
                    var type = assembly.DefinedTypes
                        .Where(xType => xType.FullName == typeName)
                        // Throw if none, use first for speed (avoid evaluating all types are required by single) since we know there should only be zero or one types.
                        .First();

                    var output = typeInfoFunction(type);
                    return output;
                });

            return output;
        }

        public TOut InExampleTypeContext<TOut>(
            Type type,
            Func<TypeInfo, TOut> typeInfoFunction)
        {
            var typeName = type.FullName;

            return this.InExampleTypeContext(
                typeName,
                typeInfoFunction);
        }

        public TOut InExampleTypeContext<T, TOut>(
            Func<TypeInfo, TOut> typeInfoFunction)
        {
            var type = typeof(T);

            return this.InExampleTypeContext(
                type,
                typeInfoFunction);
        }

        public TOut InExampleClass00Context<TOut>(
            Func<TypeInfo, TOut> typeFunction)
        {
            var output = this.InExampleTypeContext(
                "R5T.E0047.Z000.ExampleClass00",
                typeFunction);

            return output;
        }
    }
}
