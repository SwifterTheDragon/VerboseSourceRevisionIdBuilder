// Copyright SwifterTheDragon, 2024. All Rights Reserved.

namespace SwifterTheDragon.VerboseSourceRevisionIdBuilder.SourceGenerator.Core
{
    /// <summary>
    /// Specifies which reference types are being referred to.
    /// </summary>
    internal enum GitReferenceType
    {
        /// <summary>
        /// The default value.
        /// This should never be used intentionally.
        /// </summary>
        None = 0,
        /// <summary>
        /// Only annotated tags are being referenced.
        /// </summary>
        AnnotatedTags = 1,
        /// <summary>
        /// Both annotated tags and lightweight (non-annotated)
        /// tags are being referenced.
        /// </summary>
        Tags = 2,
        /// <summary>
        /// All reference types are being referenced.
        /// </summary>
        All = 3
    }
}