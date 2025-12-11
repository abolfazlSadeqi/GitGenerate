using System.ComponentModel.DataAnnotations;

namespace Core;

public class GitSubmoduleInputModel
{
    // Operation: add / update / remove / init / sync
    [Required] public string OperationType { get; set; } = "add";

    [Display(Name = "Repository URL")]
    public string RepositoryUrl { get; set; } = "";

    [Display(Name = "Local Path (submodule path)")]
    public string LocalPath { get; set; } = "";

    // For add: which branch/tag to checkout inside submodule (optional)
    [Display(Name = "Submodule Reference (branch/tag/commit)")]
    public string Reference { get; set; } = "";

    // If true, perform recursive update / clone
    public bool Recursive { get; set; } = true;

    // After changing .gitmodules and stage, automatically create commit
    public bool AutoCommit { get; set; } = true;

    // If AutoCommit true, optionally push to remote
    public bool PushToRemote { get; set; } = false;

    // If user wants pre-release tag generation for release flows
    public bool IsReleaseFlow { get; set; } = false;
    public string ReleaseTagPrefix { get; set; } = "v";

    // Conflict resolution options (for conflict helper)
    public string ConflictType { get; set; } = ""; // e.g. "detached-head", "url-mismatch", "pointer-mismatch", "modules-dir-missing"

    // User note for commit message
    public string CommitMessage { get; set; } = "";
}
