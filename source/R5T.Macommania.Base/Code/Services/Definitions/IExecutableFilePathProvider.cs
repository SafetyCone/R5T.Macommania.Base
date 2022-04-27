using System;

using R5T.T0064;


namespace R5T.Macommania
{
    /// <summary>
    /// Provides the path of the currently executing executable file.
    /// </summary>
    [ServiceDefinitionMarker]
    public interface IExecutableFilePathProvider : IServiceDefinition
    {
        string GetExecutableFilePath();
    }
}
