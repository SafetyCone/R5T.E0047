using System;


namespace R5T.E0047.Z000
{
    /// <summary>
    /// An initial class.
    /// </summary>
    public class Distinct
    { }

    /// <summary>
    /// Demonstration: Are types differentiable if they have a generic type parameter?
    /// Result: Yes.
    /// </summary>
    public class Distinct<T>
    { }

    ///// <summary>
    ///// Demonstration: Are types differentiable based on a struct restriction of their generic type parameter?
    ///// Result: No. Error: The namespace 'R5T.E0047.Z000' already contains a definition for 'Distinct'
    ///// </summary>
    //public class Distinct<T>
    //    where T : struct
    //{ }

    ///// <summary>
    ///// Demonstration: Are types differentiable based on a class restriction of their generic type parameter?
    ///// Result: No. Error: The namespace 'R5T.E0047.Z000' already contains a definition for 'Distinct'
    ///// </summary>
    //public class Distinct<T>
    //    where T : class
    //{ }

    ///// <summary>
    ///// Demonstration: Are types differentiable based on a specific class restriction of their generic type parameter?
    ///// Result: No. Error: The namespace 'R5T.E0047.Z000' already contains a definition for 'Distinct'
    ///// </summary>
    //public class Distinct<T>
    //    where T : ClassX
    //{ }

    ///// <summary>
    ///// Demonstration: Are types differentiable based on a specific struct restriction of their generic type parameter?
    ///// Result: No. Error: The namespace 'R5T.E0047.Z000' already contains a definition for 'Distinct'
    ///// </summary>
    //public class Distinct<T>
    //    where T : StructY
    //{ }

    /// <summary>
    /// Demonstration: Are types differentiable based on the number of generic type parameters?
    /// Result: Yes.
    /// </summary>
    public class Distinct<T1, T2>
    { }

    //    /// <summary>
    //    /// Demonstration: Are types differentiable based on whether they are an interface or a class?
    //    /// Result: No. Error: The namespace 'R5T.E0047.Z000' already contains a definition for 'Distinct'
    //    /// </summary>
    //#pragma warning disable IDE1006 // Naming Styles
    //    public interface Distinct
    //#pragma warning restore IDE1006 // Naming Styles
    //    { }

    ///// <summary>
    ///// Demonstration: Are types differentiable based on whether they are a struct or a class?
    ///// Result: No. Error: The namespace 'R5T.E0047.Z000' already contains a definition for 'Distinct'
    ///// </summary>
    //public struct Distinct
    //{ }

    ///// <summary>
    ///// Demonstration: Are types differentiable based on whether they are a static class or a class?
    ///// Result: No. Error: The namespace 'R5T.E0047.Z000' already contains a definition for 'Distinct'
    ///// </summary>
    //public static class Distinct
    //{ }
}
