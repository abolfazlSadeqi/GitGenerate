namespace Core;

public class GitIgnoreRequest
{
    public List<string> SelectedLanguages { get; set; } = new();  // زبان‌های انتخاب شده
    public List<string> SelectedTemplates { get; set; } = new();  // Template های انتخاب شده
    public List<GitIgnoreRule> CustomRules { get; set; } = new(); // Custom Rules کاربر
}
