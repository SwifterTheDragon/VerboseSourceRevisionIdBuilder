// Copyright SwifterTheDragon, 2025. All Rights Reserved.

namespace SwifterTheDragon.VerboseSourceRevisionIdBuilder.SourceGenerator.Core
{
    /// <summary>
    /// Specifies if tags predating or containing the commit should be used.
    /// </summary>
    internal enum GitTagState
    {
        /// <summary>
        /// The default value.
        /// This should never be used intentionally.
        /// </summary>
        None = 0,
        /// <summary>
        /// Only use tags that predate the commit.
        /// </summary>
        PredatesCommit = 1,
        /// <summary>
        /// Only use tags that contain the commit.
        /// </summary>
        ContainsCommit = 2
    }
}
