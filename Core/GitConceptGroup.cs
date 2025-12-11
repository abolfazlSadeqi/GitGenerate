namespace Core;

public class GitConceptGroup
{
    public string GroupKey { get; set; }     // repo_structure, git_objects, commits...
    public string GroupTitle { get; set; }
    public List<GitConceptItem> Items { get; set; }
}
