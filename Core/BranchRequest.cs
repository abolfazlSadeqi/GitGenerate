namespace Core;

public class BranchRequest
{
    public string? Lang { get; set; } = "en";
    public string? Type { get; set; } = "feature"; // feature/release/hotfix/develop/main
    public string? Name { get; set; } = ""; // نام دلخواه یا base name
    public List<string> From { get; set; } = new(); // شاخه(های) مرجع (مثلاً develop, main)
    public bool PushRemote { get; set; } = false; // آیا باید push و remote ایجاد شود؟
                                                  // برای release: اگر کاربر بخواهد شماره نسخه قبلی را وارد کند یا از سرویس نسخه‌ها انتخاب کند
    public int? PreviousVersionId { get; set; } = null;
    public int PrevMajor { get; set; } = 0;
    public int PrevMinor { get; set; } = 0;
    public int PrevPatch { get; set; } = 0;
    // نوع تغییر برای تولید نسخه جدید (major/minor/patch) — می‌تونه چندتا هم انتخاب بشه؛ ولی معمولاً یکی
    public List<string> ChangeTypes { get; set; } = new();
    // pre-release tag option (alpha/beta/rc or empty)
    public string? PreReleaseLabel { get; set; } = "";
    // توضیحات دلخواه برای release notes
    public string? Description { get; set; } = "";
}
