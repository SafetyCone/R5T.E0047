using System;


namespace R5T.E0047.Y000
{
    public static class Glossary
    {
        public static class ForCodeElementIdentityNames
        {
            /// <summary>
            /// <inheritdoc cref="IdentityName" path="/definition"/>
            /// These are the same ID strings used in C# XML documentation comments.
            /// See: <see href="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/xmldoc/#id-strings"/>
            /// </summary>
            /// <definition>The name by which a code element can be uniquely identified.</definition>
            /// <name><i>identity name</i></name>
            public static readonly object IdentityName;

            /// <summary>
            /// <inheritdoc cref="UniqueTypeCriteria" path="/definition"/>
            /// </summary>
            /// <definition>Types are unique by the combination of: 1) assemblied, namespaced, type name and 2) generic type parameter arity.</definition>
            /// <name><i>unique type criteria</i></name>
            public static readonly object UniqueTypeCriteria;
        }
    }
}
