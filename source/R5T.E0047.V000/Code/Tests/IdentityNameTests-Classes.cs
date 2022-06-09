using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace R5T.E0047.V000
{
    [TestClass]
    public class IdentityNameTests
    {
        /// <summary>
        /// <inheritdoc cref="Z000.ExampleClass00" path="/description"/>
        /// </summary>
        [TestMethod]
        public void ExampleClass00()
        {
            var actual = Instances.ReflectedInstanceContextProvider.InExampleClass00Context(
                type =>
                {
                    var output = Instances.IdentityNameProvider.GetIdentityName(type);
                    return output;
                });

            var expected = Instances.IdentityNames.ExampleClass00;

            Instances.Assertion.AreEqual(
                actual,
                expected);
        }

        /// <summary>
        /// <inheritdoc cref="Z000.ExampleClass01{T}" path="/description"/>
        /// </summary>
        [TestMethod]
        public void ExampleClass01()
        {
            var actual = Instances.ReflectedInstanceContextProvider.InExampleTypeContext(
                typeof(Z000.ExampleClass01<>),
                typeInfoFunction: type =>
                {
                    var output = Instances.IdentityNameProvider.GetIdentityName(type);
                    return output;
                });

            var expected = Instances.IdentityNames.ExampleClass01;

            Instances.Assertion.AreEqual(
                actual,
                expected);
        }
    }
}
