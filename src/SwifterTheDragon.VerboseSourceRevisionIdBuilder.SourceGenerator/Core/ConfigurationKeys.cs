// Copyright SwifterTheDragon, 2024. All Rights Reserved.

namespace SwifterTheDragon.VerboseSourceRevisionIdBuilder.SourceGenerator.Core
{
    /// <summary>
    /// The keys to configuration values.
    /// </summary>
    internal static class ConfigurationKeys
    {
        #region Fields & Properties
        /// <summary>
        /// The key to the semantic version major version configuration value.
        /// </summary>
        internal static string SemanticVersionMajorVersion
        {
            get
            {
                return "MajorVersion";
            }
        }
        /// <summary>
        /// The key to the semantic version minor version configuration value.
        /// </summary>
        internal static string SemanticVersionMinorVersion
        {
            get
            {
                return "MinorVersion";
            }
        }
        /// <summary>
        /// The key to the semantic version patch version configuration value.
        /// </summary>
        internal static string SemanticVersionPatchVersion
        {
            get
            {
                return "PatchVersion";
            }
        }
        /// <summary>
        /// The key to the generated file name configuration value.
        /// </summary>
        internal static string GeneratedFileName
        {
            get
            {
                return "GeneratedFileName";
            }
        }
        /// <summary>
        /// The key to the generated namespace configuration value.
        /// </summary>
        internal static string GeneratedNamespace
        {
            get
            {
                return "GeneratedNamespace";
            }
        }
        /// <summary>
        /// The key to the generated type name configuration value.
        /// </summary>
        internal static string GeneratedTypeName
        {
            get
            {
                return "GeneratedTypeName";
            }
        }
        /// <summary>
        /// The key to the generated field name value.
        /// </summary>
        internal static string GeneratedFieldName
        {
            get
            {
                return "GeneratedFieldName";
            }
        }
        /// <summary>
        /// The key to the semantic version prefix configuration value.
        /// </summary>
        internal static string SemanticVersionPrefix
        {
            get
            {
                return "Prefix";
            }
        }
        /// <summary>
        /// The key to the semantic version suffix configuration value.
        /// </summary>
        internal static string SemanticVersionSuffix
        {
            get
            {
                return "Suffix";
            }
        }
        /// <summary>
        /// The key to the dirty mark configuration value for labelling a
        /// working tree with local modification.
        /// </summary>
        internal static string DirtyMark
        {
            get
            {
                return "DirtyMark";
            }
        }
        /// <summary>
        /// The key to the broken mark configuration value for labelling a
        /// corrupt repository.
        /// </summary>
        internal static string BrokenMark
        {
            get
            {
                return "BrokenMark";
            }
        }
        /// <summary>
        /// The key to the detached <c>HEAD</c> label
        /// configuration value for anonymous branches.
        /// </summary>
        internal static string DetachedHeadLabel
        {
            get
            {
                return "DetachedHeadLabel";
            }
        }
        /// <summary>
        /// The key to the invalid <c>HEAD</c> label
        /// configuration value for unborn branches.
        /// </summary>
        internal static string InvalidHeadLabel
        {
            get
            {
                return "InvalidHeadLabel";
            }
        }
        /// <summary>
        /// The key to the default Git branch name configuration value.
        /// </summary>
        internal static string DefaultGitBranchName
        {
            get
            {
                return "DefaultGitBranchName";
            }
        }
        /// <summary>
        /// The key to the repository root directory relative to configuration
        /// file path configuration value.
        /// </summary>
        internal static string RepositoryRootDirectoryRelativeToConfigurationFilePath
        {
            get
            {
                return "RepositoryRootRelativeToConfigurationFilePath";
            }
        }
        /// <summary>
        /// The key to the Git reference type configuration value.
        /// </summary>
        internal static string GitReferenceType
        {
            get
            {
                return "GitReferenceType";
            }
        }
        /// <summary>
        /// The key to the candidate (most recent tag) amount configuration
        /// value.
        /// </summary>
        internal static string CandidateAmount
        {
            get
            {
                return "CandidateAmount";
            }
        }
        /// <summary>
        /// The key to the abbrev length (amount of hexadecimal digits to
        /// describe an abbreviated object name with)
        /// configuration value.
        /// </summary>
        internal static string AbbrevLength
        {
            get
            {
                return "AbbrevLength";
            }
        }
        /// <summary>
        /// The key to the first parent only configuration value.
        /// </summary>
        internal static string FirstParentOnly
        {
            get
            {
                return "FirstParentOnly";
            }
        }
        /// <summary>
        /// The key to the contains configuration value.
        /// </summary>
        internal static string Contains
        {
            get
            {
                return "Contains";
            }
        }
        /// <summary>
        /// The key to the match pattern configuration value.
        /// </summary>
        internal static string MatchPatterns
        {
            get
            {
                return "MatchPatterns";
            }
        }
        /// <summary>
        /// The key to the exclude pattern configuration value.
        /// </summary>
        internal static string ExcludePatterns
        {
            get
            {
                return "ExcludePatterns";
            }
        }
        #endregion Fields & Properties
    }
}