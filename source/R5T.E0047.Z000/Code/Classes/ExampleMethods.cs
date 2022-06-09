using System;


namespace R5T.E0047.Z000
{
    /// <summary>
    /// This is a class providing example methods.
    /// It provides XML documentation ID strings for methods in the project's XML documentation file for the output assembly.
    /// </summary>
    public class ExampleMethods
    {
        /// <summary>
        /// A static method returning void.
        /// </summary>
        public static void Method01()
        { }

        /// <summary>
        /// A static method returning a string.
        /// </summary>
        /// <returns></returns>
        public static string Method02()
        {
            return String.Empty;
        }

        /// <summary>
        /// A static method with one type parameter.
        /// </summary>
        public static void Method03<T>()
        { }

        /// <summary>
        /// A static method with two type parameters.
        /// </summary>
        public static void Method04<T1, T2>()
        { }

#pragma warning disable CA1822 // Mark members as static

        /// <summary>
        /// An instance method retuning void.
        /// </summary>
        public void Method05()
        { }

        /// <summary>
        /// An instance method returning a string.
        /// </summary>
        public string Method06()
        {
            return String.Empty;
        }

        /// <summary>
        /// An instance method with one generic type parameter.
        /// </summary>
        public void Method06<T>()
        { }

        /// <summary>
        /// An instance method with two generic type parameters.
        /// </summary>
        public void Method06<T1, T2>()
        { }

        /// <summary>
        /// An instance method returning a generic type parameter.
        /// The input constructor is required 
        /// </summary>
        public T Method07<T>()
        {
            var output = (T)(new object());
            return output;
        }

        /// <summary>
        /// A method taking a string and returning a string.
        /// </summary>
        public string Method08(string value)
        {
            return value;
        }

        /// <summary>
        /// A method taking a generic type instance and returning a generic type instance.
        /// </summary>
        public T Method09<T>(T value)
        {
            return value;
        }

        /// <summary>
        /// Method with new() restriction on generic type parameter.
        /// </summary>
        public void Method10<T>()
            where T : new()
        { }

        /// <summary>
        /// Method with class restriction on generic type parameter.
        /// </summary>
        public void Method11<T>()
            where T : class
        { }

        /// <summary>
        /// Method with specific class restriction on generic type parameter.
        /// </summary>
        public void Method12<T>()
            where T : class
        { }

#pragma warning restore CA1822 // Mark members as static

    }

    /// <summary>
    /// This is a generic class providing example methods.
    /// It provides XML documentation ID strings for methods in the project's XML documentation file for the output assembly.
    /// </summary>
    public class ExampleMethods<T>
    {
        /// <summary>
        /// Method taking one parameter.
        /// </summary>
        public void Method01(T _)
        { }

        /// <summary>
        /// Method with one generic type parameter.
        /// </summary>
        public void Method02<T1>()
        { }
    }
}
