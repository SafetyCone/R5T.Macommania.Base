using System;


namespace R5T.Macommania
{
    /// <summary>
    /// Provides the path of the currently executing executable file.
    /// </summary>
    public interface IExecutableFilePathProvider
    {
        string GetExecutableFilePath();
    }
}
