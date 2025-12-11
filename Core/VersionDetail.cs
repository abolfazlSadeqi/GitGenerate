namespace Core;

public class VersionDetail
{
    public int Id { get; set; }

    // Semantic version parts
    public int Major { get; set; } // Breaking changes, incompatible
    public int Minor { get; set; } // New features, backward compatible
    public int Patch { get; set; } // Bug fixes, minor changes
    public string PreRelease { get; set; } = ""; // e.g., "rc.1", "beta.2"
    public int? ParentVersionId { get; set; } // برای شاخه‌بندی و مشخص کردن نسخه والد

    public  Dictionary<string, string> Description { get; set; } = new   Dictionary<string, string> (); // e.g., "rc.1", "beta.2"

    
    // نمایش نسخه کامل
    public string Display => string.IsNullOrEmpty(PreRelease)
        ? $"{Major}.{Minor}.{Patch}"
        : $"{Major}.{Minor}.{Patch}-{PreRelease}";

  
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
