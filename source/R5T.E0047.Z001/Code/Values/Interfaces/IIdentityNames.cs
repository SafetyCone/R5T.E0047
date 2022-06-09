using System;

using R5T.T0131;


namespace R5T.E0047.Z001
{
    /// <summary>
    /// Provides identity names for code elements from the <see cref="Z000"/> library.
    /// </summary>
    [ValuesMarker]
    public interface IIdentityNames : IValuesMarker
    {
        public string ExampleClass00 => "T:R5T.E0047.Z000.ExampleClass00";
        public string ExampleClass01 => "T:R5T.E0047.Z000.ExampleClass01`1";
    }
}
