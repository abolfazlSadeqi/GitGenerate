namespace Core;

public class GitIgnoreTemplate
{
    public string Name { get; set; }             // نام داخلی Template
    public string Display { get; set; }          // نام قابل نمایش
    public List<GitIgnoreRule> Rules { get; set; } = new();
}
