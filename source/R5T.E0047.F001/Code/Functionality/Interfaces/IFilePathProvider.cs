using System;

using R5T.Magyar;

using R5T.T0132;


namespace R5T.E0047.F001
{
    [FunctionalityMarker]
    public interface IFilePathProvider : IFunctionalityMarker
    {
        public string GetExecutableDirectoryPath()
        {
            var executableFilePath = ExecutableFilePathHelper.GetExecutableFilePath();

            var output = Instances.PathOperator.GetDirectoryPathOfFilePath(executableFilePath);
            return output;
        }

        public string GetExamplesAssemblyFilePath()
        {
            var executableDirectoryPath = this.GetExecutableDirectoryPath();

            var output = Instances.PathOperator.GetFilePath(
                executableDirectoryPath,
                "R5T.E0047.Z000.dll");

            return output;
        }
    }
}
