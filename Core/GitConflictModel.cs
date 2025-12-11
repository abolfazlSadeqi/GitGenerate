namespace Core
{
    public class GitConflictModel
    {
        public string TitleEn => "Git Conflicts - Complete Reference";
        public string TitleFa => "کانفلیکت‌های گیت - مرجع کامل";

        public class ConflictItem
        {
            public string Type { get; set; }
            public string Scenario { get; set; }
            public string Solution { get; set; }
            public string Notes { get; set; }
        }

        public List<ConflictItem> Conflicts => new List<ConflictItem>
        {
            new ConflictItem
            {
                Type = "Cherry-pick Line Conflict",
                Scenario = "When cherry-picking a commit from develop to stage, lines modified in both branches overlap, causing a conflict.",
                Solution = @"# Stage resolved files
git add .
# Continue cherry-pick
git cherry-pick --continue
# Or abort cherry-pick if needed
git cherry-pick --abort",
                Notes = "Always check git status; resolve only staged conflicts before continuing."
            },
            new ConflictItem
            {
                Type = "Merge Line Conflict",
                Scenario = "Two branches modify the same lines in the same file during a merge, resulting in conflict markers in the file.",
                Solution = @"# Open the file, resolve <<<<<<< HEAD and >>>>>>> markers
git add <resolved-files>
git commit",
                Notes = "Using IDE or git diff tools helps resolve conflicts accurately."
            },
            new ConflictItem
            {
                Type = "Rebase Commit Conflict",
                Scenario = "Rebasing a branch onto another branch where overlapping changes exist, Git stops at conflicted commit.",
                Solution = @"# Resolve conflicts in files
git add .
# Continue rebase
git rebase --continue
# Or abort if needed
git rebase --abort",
                Notes = "Resolve commits sequentially; don't skip commits accidentally."
            },
            new ConflictItem
            {
                Type = "Binary File Conflict",
                Scenario = "Both branches modified a binary file (e.g., image, Excel), Git cannot auto-merge.",
                Solution = @"# Manually choose correct file version
git add <file>
git commit",
                Notes = "Binary files require human decision; Git cannot merge automatically."
            },
            new ConflictItem
            {
                Type = "Pull Conflict Due to Local Changes",
                Scenario = "Local edits conflict with incoming remote changes when executing git pull.",
                Solution = @"# Stash local changes
git stash
# Pull from remote
git pull
# Apply stashed changes
git stash pop
# Resolve any conflicts
git add .
git commit",
                Notes = "Always commit or stash local changes before pulling to avoid conflicts."
            },
            new ConflictItem
            {
                Type = "Delete vs Modify Conflict",
                Scenario = "One branch deletes a file while the other modifies the same file.",
                Solution = @"# Decide whether to keep or delete the file
git add <file>
git commit",
                Notes = "Git marks this file as conflicted; manual resolution is required."
            },
            new ConflictItem
            {
                Type = "Submodule Pointer Conflict",
                Scenario = "Both branches update the same submodule to different commits.",
                Solution = @"git submodule update --init --recursive
# Resolve manually if necessary
git add .
git commit",
                Notes = "Check submodule commit hashes to ensure correctness."
            },
            new ConflictItem
            {
                Type = "File Rename Conflict",
                Scenario = "Same file renamed differently on two branches; Git cannot auto-merge.",
                Solution = @"# Use merge tool to select correct version
git add <resolved-file>
git commit",
                Notes = "May require moving or renaming files manually."
            },
            new ConflictItem
            {
                Type = "Line Ending Conflict (CRLF vs LF)",
                Scenario = "Different OS users commit with different line endings, causing conflicts.",
                Solution = @"# Normalize line endings
git config core.autocrlf true
git add .
git commit",
                Notes = "Adding .gitattributes helps prevent future line-ending conflicts."
            },
            new ConflictItem
            {
                Type = "Whitespace Conflict",
                Scenario = "Whitespace differences in the same lines across branches.",
                Solution = @"# Manually fix or ignore whitespace changes
git merge -Xignore-space-change
git add .
git commit",
                Notes = "Code formatting tools (prettier, clang-format) help prevent this."
            },
            new ConflictItem
            {
                Type = "Subtree Merge Conflict",
                Scenario = "Merging a repository subtree causes overlapping files or directories.",
                Solution = @"# Manually resolve overlapping directories
git add .
git commit",
                Notes = "Carefully decide which subtree version to keep."
            },
            new ConflictItem
            {
                Type = "Tag Conflict",
                Scenario = "Both branches have a tag pointing to different commits.",
                Solution = @"git tag -d <tag>
git tag <tag> <commit>",
                Notes = "Decide which branch’s tag is authoritative."
            },
            new ConflictItem
            {
                Type = "Stash Apply Conflict",
                Scenario = "Applying a stash conflicts with current branch files.",
                Solution = @"git stash apply
# Resolve conflicts
git add .
git commit",
                Notes = "Use stash pop cautiously; resolve conflicts before committing."
            },
            new ConflictItem
            {
                Type = "Revert Commit Conflict",
                Scenario = "Reverting a commit conflicts with subsequent changes.",
                Solution = @"git revert <commit>
# Resolve conflicts
git add .
git commit",
                Notes = "Manual resolution is often required."
            },
            new ConflictItem
            {
                Type = "Interactive Rebase Squash Conflict",
                Scenario = "Squashing multiple commits with overlapping changes during interactive rebase.",
                Solution = @"git rebase -i
# Resolve conflicts, then continue
git rebase --continue",
                Notes = "Check each commit carefully during squash."
            },
            new ConflictItem
            {
                Type = "Fast-forward Merge Blocked",
                Scenario = "Cannot fast-forward because branch histories diverged.",
                Solution = @"git merge --no-ff <branch>
# Resolve conflicts manually if any",
                Notes = "May need manual merge for overlapping files."
            },
            new ConflictItem
            {
                Type = "Remote Upstream Change Conflict",
                Scenario = "Remote branch changes conflict with local commits.",
                Solution = @"git fetch
git rebase origin/<branch>
# Resolve conflicts
git add .
git rebase --continue",
                Notes = "Using rebase keeps history linear."
            },
            new ConflictItem
            {
                Type = "Empty Commit Conflict",
                Scenario = "Cherry-pick or rebase results in an empty commit because changes already exist.",
                Solution = @"git cherry-pick --skip",
                Notes = "Safe to skip; commit already applied."
            },
            new ConflictItem
            {
                Type = "Locked File Conflict",
                Scenario = "File is open in another program or locked by OS; cannot apply changes.",
                Solution = @"# Close the file in editor/IDE
# Retry git operation",
                Notes = "Common on Windows due to file locks."
            },
            new ConflictItem
            {
                Type = "Custom Merge Driver Conflict",
                Scenario = "Custom merge driver cannot resolve conflicts automatically.",
                Solution = @"# Resolve manually
git add .
git commit",
                Notes = "Check merge driver configuration."
            },
            new ConflictItem
            {
                Type = "Interactive Rebase Multi-Commit Conflict",
                Scenario = "Squashing or reordering multiple commits with overlapping changes.",
                Solution = @"git rebase -i
# Resolve each conflict
git rebase --continue",
                Notes = "Careful attention to commit order is essential."
            },
        };
    }
}
