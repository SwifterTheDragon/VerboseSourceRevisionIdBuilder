// Copyright SwifterTheDragon, 2024. All Rights Reserved.

using System.Diagnostics;
using System.IO;

namespace SwifterTheDragon.VerboseSourceRevisionIdBuilder.SourceGenerator.Core
{
    /// <summary>
    /// Provides command line utilities, such as executing a command.
    /// </summary>
    internal static class CommandLineUtilities
    {
        #region Methods
        /// <summary>
        /// Executes a command through <c>cmd.exe</c> in the desired directory.
        /// </summary>
        /// <param name="command">
        /// The command to be passed to <c>cmd.exe</c>
        /// </param>
        /// <param name="directory">
        /// The directory to run the command on.
        /// </param>
        /// <returns>
        /// The output of the command that was executed.
        /// </returns>
        internal static string ExecuteCommandLineCommand(
            string command,
            string directory)
        {
            if (string.IsNullOrWhiteSpace(
                value: command))
            {
                return string.Empty;
            }
            if (string.IsNullOrWhiteSpace(
                value: directory))
            {
                return string.Empty;
            }
            if (!TryGetWorkingDirectory(
                path: directory,
                out string workingDirectory))
            {
                return string.Empty;
            }
            string output = string.Empty;
            using (var cmdProcess = new Process())
            {
                cmdProcess.StartInfo = new ProcessStartInfo(
                    fileName: "cmd.exe",
                    arguments: "/c "
                        + command)
                {
                    CreateNoWindow = true,
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    WorkingDirectory = workingDirectory
                };
                _ = cmdProcess.Start();
                output = cmdProcess.StandardOutput.ReadToEnd().TrimEnd();
                cmdProcess.WaitForExit();
            }
            return output;
        }
        /// <summary>
        /// Attempts to get a working directory from a path.
        /// </summary>
        /// <param name="path">
        /// The path to try and get the working directory from.
        /// </param>
        /// <param name="workingDirectory">
        /// The resulting working directory, if successful.
        /// </param>
        /// <returns>
        /// <c>true</c> if a valid working directory was found using the
        /// specified <c><paramref name="path"/></c>.
        /// Otherwise, <c>false</c>.
        /// </returns>
        private static bool TryGetWorkingDirectory(
            string path,
            out string workingDirectory)
        {
            workingDirectory = string.Empty;
            if (Directory.Exists(
                path: path))
            {
                workingDirectory = path;
                return true;
            }
            string directoryName = Path.GetDirectoryName(
                path: path);
            if (Directory.Exists(
                path: directoryName))
            {
                workingDirectory = directoryName;
                return true;
            }
            return false;
        }
        #endregion Methods
    }
}