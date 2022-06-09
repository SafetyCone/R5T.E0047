using System;


namespace R5T.E0047.Z000
{
    /// <summary>
    /// This is a class demonstrating what makes method names distinct.
    /// </summary>
    public class DistinctMethods
    {
        /// <summary>
        /// A static method returning void.
        /// </summary>
        public static void StaticMethod()
        { }

        ///// <summary>
        ///// Demonstration: Are methods differentiable by return type?
        ///// Result: No. Error: Type 'DistinctMethods' already defines a member called 'StaticMethod' with the same parameter types
        ///// </summary>
        //public static string StaticMethod()
        //{ }

        ///// <summary>
        ///// Demonstration: are methods differentiable if there is a static method, then an instance method?
        ///// Result: No. Error: Type 'DistinctMethods' already defines a member called 'StaticMethod' with the same parameter types
        ///// </summary>
        //public void StaticMethod()
        //{ }

        /// <summary>
        /// A static method with one type parameter.
        /// </summary>
        public static void StaticMethod<T>()
        { }

        ///// <summary>
        ///// Demonstration: are methods differentiable by a restriction on their generic type parameter?
        ///// Result No. Error: Type 'DistinctMethods' already defines a member called 'StaticMethod' with the same parameter types
        ///// </summary>
        //public static void StaticMethod<T>()
        //    where T : ClassX
        //{ }

        /// <summary>
        /// A static method with two type parameters.
        /// </summary>
        public static void StaticMethod<T1, T2>()
        { }

#pragma warning disable CA1822 // Mark members as static

        /// <summary>
        /// An instance method retuning void.
        /// </summary>
        public void Method()
        { }

        ///// <summary>
        ///// Demonstration: are methods differentiable if there is an instance method, then a static method?
        ///// Result: No. Error: Type 'DistinctMethods' already defines a member called 'Method' with the same parameter types
        ///// </summary>
        //public static void Method()
        //{ }

        /// <summary>
        /// An instance method with one generic type parameter.
        /// </summary>
        public void Method<T>()
        { }

        /// <summary>
        /// An instance method with two generic type parameters.
        /// </summary>
        public void Method<T1, T2>()
        { }

#pragma warning restore CA1822 // Mark members as static

    }
}
