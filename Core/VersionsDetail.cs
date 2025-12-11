namespace Core;

// مدل نسخه (اگر از قبل دارید میتونید از نسخه‌های قبلی استفاده کنید)
public class VersionsDetail
{
    public int Id { get; set; }
    public int Major { get; set; }
    public int Minor { get; set; }
    public int Patch { get; set; }
    public string PreRelease { get; set; } = "";
    public Dictionary<string, string> Description { get; set; } = new() { { "en", "" }, { "fa", "" } };
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public string Display => string.IsNullOrEmpty(PreRelease) ? $"{Major}.{Minor}.{Patch}" : $"{Major}.{Minor}.{Patch}-{PreRelease}";
}
