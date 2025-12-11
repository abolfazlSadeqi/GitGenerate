namespace Core;

public class GitIgnoreViewModel
{
    public List<GitIgnoreLanguage> Languages { get; set; } = new();
    public List<GitIgnoreTemplate> Templates { get; set; } = new();
    public List<GitIgnoreRule> CustomRules { get; set; } = new();
}
