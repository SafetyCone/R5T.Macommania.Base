using System;


namespace R5T.Macommania
{
    /// <summary>
    /// Provides the parent directory path of the current executing executable file.
    /// </summary>
    public interface IExecutableFileDirectoryPathProvider
    {
        string GetExecutableFileDirectoryPath();
    }
}
