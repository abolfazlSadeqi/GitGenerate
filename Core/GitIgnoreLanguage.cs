namespace Core;

public class GitIgnoreLanguage
{
    public string Name { get; set; }             // نام داخلی زبان
    public string Display { get; set; }          // نام قابل نمایش
    public List<GitIgnoreRule> Rules { get; set; } = new();
}
