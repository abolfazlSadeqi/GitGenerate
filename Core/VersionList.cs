namespace Core;

public class VersionList
{
  

    // توضیح دو زبانه برای هر بخش Semantic Versioning
    public Dictionary<string, string> MajorDescription { get; set; } = new()
    {
        {"en", "Major version changes include incompatible API changes and require full testing."},
        {"fa", "تغییرات نسخه Major شامل تغییرات ناسازگار و نیازمند تست کامل است."}
    };
    public Dictionary<string, string> MinorDescription { get; set; } = new()
    {
        {"en", "Minor version changes add new features without breaking existing functionality."},
        {"fa", "تغییرات نسخه Minor قابلیت‌های جدید اضافه می‌کند بدون شکستن عملکرد موجود."}
    };
    public Dictionary<string, string> PatchDescription { get; set; } = new()
    {
        {"en", "Patch version changes fix bugs and minor issues without adding features."},
        {"fa", "تغییرات نسخه Patch رفع باگ و مشکلات جزئی است بدون افزودن قابلیت جدید."}
    };
    public Dictionary<string, string> PreReleaseDescription { get; set; } = new()
    {
        {"en", "Pre-release versions (like RC or beta) are not fully stable and may change before final release."},
        {"fa", "نسخه‌های پیش‌انتشار (مثل RC یا beta) پایدار کامل نیستند و قبل از انتشار نهایی ممکن است تغییر کنند."}
    };

    // توضیحات آزاد (برای release notes) دو زبانه
    public Dictionary<string, string> Description { get; set; } = new()
    {
        {"en", "" },
        {"fa", "" }
    };

    // قوانین تغییر نسخه (Rules)
    public Dictionary<string, List<string>> Rules { get; set; } = new()
{
    { "en", new List<string>
        {
            "Follow Semantic Versioning rules: MAJOR.MINOR.PATCH",
            "Major changes should break backward compatibility",
            "Minor changes should add features without breaking existing functionality",
            "Patch changes should only fix bugs",
            "Use pre-release labels (e.g., rc, beta) for testing versions before final release"
        }
    },
    { "fa", new List<string>
        {
            "پیروی از قوانین Semantic Versioning: MAJOR.MINOR.PATCH",
            "تغییرات Major باید ناسازگار با نسخه قبلی باشند",
            "تغییرات Minor قابلیت‌های جدید اضافه می‌کنند بدون شکستن نسخه‌های موجود",
            "تغییرات Patch فقط باید باگ‌ها را رفع کنند",
            "برای نسخه‌های آزمایشی قبل از انتشار نهایی از pre-release (مثل rc یا beta) استفاده کنید"
        }
    }
};

    // چالش‌ها (Challenges)
    public Dictionary<string, List<string>> Challenges { get; set; } = new()
{
    { "en", new List<string>
        {
            "Ensuring backward compatibility for Minor changes",
            "Managing breaking changes for Major releases",
            "Keeping release notes consistent and clear",
            "Handling pre-release versions and testing"
        }
    },
    { "fa", new List<string>
        {
            "اطمینان از سازگاری با نسخه‌های قبلی در تغییرات Minor",
            "مدیریت تغییرات ناسازگار در نسخه‌های Major",
            "حفظ یکپارچگی و شفافیت در Release Notes",
            "مدیریت نسخه‌های pre-release و تست آنها"
        }
    }
};

    // راه‌حل‌ها (Solutions)
    public Dictionary<string, List<string>> Solutions { get; set; } = new()
{
    { "en", new List<string>
        {
            "Use automated testing for backward compatibility",
            "Document breaking changes clearly in release notes",
            "Tag pre-release versions in Git (e.g., 1.2.0-rc.1)",
            "Follow strict branching strategy for release management"
        }
    },
    { "fa", new List<string>
        {
            "استفاده از تست خودکار برای بررسی سازگاری با نسخه‌های قبلی",
            "مستندسازی دقیق تغییرات ناسازگار در Release Notes",
            "تگ‌گذاری نسخه‌های pre-release در Git (مثال: 1.2.0-rc.1)",
            "پیروی از استراتژی شاخه‌بندی منظم برای مدیریت انتشار"
        }
    }
};

    // یادداشت‌ها (Notes)
    public Dictionary<string, List<string>> Notes { get; set; } = new()
{
    { "en", new List<string>
        {
            "Always increment version numbers according to Semantic Versioning rules",
            "Pre-release versions should not be used in production",
            "Keep a changelog for every release",
            "Use CI/CD to automate release and tagging"
        }
    },
    { "fa", new List<string>
        {
            "همیشه شماره نسخه را طبق قوانین Semantic Versioning افزایش دهید",
            "نسخه‌های pre-release نباید در محیط تولید استفاده شوند",
            "برای هر انتشار یک Changelog نگه دارید",
            "از CI/CD برای اتوماسیون انتشار و تگ‌گذاری استفاده کنید"
        }
    }
};

    // بهترین روش‌ها (BestPractices)
    public Dictionary<string, List<string>> BestPractices { get; set; } = new()
{
    { "en", new List<string>
        {
            "Follow Semantic Versioning strictly",
            "Automate release and tagging with CI/CD",
            "Use clear pre-release identifiers (rc, beta, alpha)",
            "Communicate breaking changes clearly to users"
        }
    },
    { "fa", new List<string>
        {
            "رعایت دقیق قوانین Semantic Versioning",
            "اتوماسیون انتشار و تگ‌گذاری با CI/CD",
            "استفاده از شناسه‌های واضح برای نسخه‌های پیش‌انتشار (rc, beta, alpha)",
            "اطلاع‌رسانی واضح تغییرات ناسازگار به کاربران"
        }
    }
};

    // اشتباهات رایج (Mistakes)
    public Dictionary<string, List<string>> Mistakes { get; set; } = new()
{
    { "en", new List<string>
        {
            "Skipping version numbers or not following SemVer rules",
            "Using Major version for minor fixes",
            "Releasing pre-release versions directly to production",
            "Not documenting changes properly"
        }
    },
    { "fa", new List<string>
        {
            "رد کردن شماره نسخه یا عدم رعایت قوانین SemVer",
            "استفاده از Major برای اصلاحات جزئی",
            "انتشار نسخه‌های پیش‌انتشار مستقیم در محیط تولید",
            "مستندسازی ناقص تغییرات"
        }
    }
};

    
}
