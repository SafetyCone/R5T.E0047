using System;


namespace R5T.E0047.Z000
{
    /// <summary>
    /// <inheritdoc cref="ExampleClass00" path="/description"/>
    /// <provides-ID-string>It provides a XML documentation ID string the project's XML documentation file for the output assembly.</provides-ID-string>
    /// </summary>
    /// <description>A basic instantiable class.</description>
    public class ExampleClass00
    { }

    /// <summary>
    /// <inheritdoc cref="ExampleClass01{T}" path="/description"/>
    /// <inheritdoc cref="ExampleClass00" path="/summary/provides-ID-string"/>
    /// </summary>
    /// <description>An example class with one generic type paramter.</description>
    public class ExampleClass01<T>
    { }

    /// <summary>
    /// An example class with two generic type parameters.
    /// <inheritdoc cref="ExampleClass00" path="/summary/provides-ID-string"/>
    /// </summary>
    public class ExampleClass02<T1, T2>
    { }

    /// <summary>
    /// A static example class.
    /// <inheritdoc cref="ExampleClass00" path="/summary/provides-ID-string"/>
    /// </summary>
    public static class ExampleClass03
    { }

    /// <summary>
    /// A static example class with one type parameter.
    /// <inheritdoc cref="ExampleClass00" path="/summary/provides-ID-string"/>
    /// </summary>
    public static class ExampleClass04<T>
    { }
}
