using System;

using R5T.T0064;


namespace R5T.Macommania
{
    /// <summary>
    /// Provides the parent directory path of the current executing executable file.
    /// </summary>
    [ServiceDefinitionMarker]
    public interface IExecutableFileDirectoryPathProvider : IServiceDefinition
    {
        string GetExecutableFileDirectoryPath();
    }
}
