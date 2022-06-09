using System;


namespace R5T.E0047.F001
{
    public static class Instances
    {
        public static IFilePathProvider FilePathProvider { get; } = F001.FilePathProvider.Instance;
        public static T0041.PathOperator PathOperator { get; } = T0041.PathOperator.Instance;
        public static F0018.IReflectionOperator ReflectionOperations { get; } = F0018.ReflectionOperator.Instance;
    }
}