// Copyright SwifterTheDragon, 2025. All Rights Reserved.

namespace SwifterTheDragon.VerboseSourceRevisionIdBuilder.SourceGenerator.Core
{
    /// <summary>
    /// Specifies which parent commit should be used.
    /// </summary>
    internal enum ParentCommitType
    {
        /// <summary>
        /// The default value.
        /// This should never be used intentionally.
        /// </summary>
        None = 0,
        /// <summary>
        /// Any parent commit.
        /// </summary>
        Any = 1,
        /// <summary>
        /// Only the first parent commit.
        /// </summary>
        FirstOnly = 2
    }
}