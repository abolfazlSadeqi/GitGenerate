namespace Core;

public class GitIgnoreRule
{
    public string Id { get; set; }           // شناسه یکتا برای Rule
    public string Description { get; set; }  // توضیح Rule برای نمایش به کاربر
    public string Pattern { get; set; }      // Pattern واقعی که در gitignore قرار می‌گیرد
    public bool Enabled { get; set; } = true;// فعال/غیرفعال شدن Rule
}
