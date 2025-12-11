namespace Core;

// نتیجه‌ای که سرویس برمی‌گرداند (لیست دستوراتی که باید اجرا شوند و توضیح)
public class BranchPlan
{
    public string BranchName { get; set; } = "";
    public List<string> Commands { get; set; } = new();
    public string SuggestedTag { get; set; } = ""; // برای release
    public string ReleaseNotes { get; set; } = "";
    public string Summary { get; set; } = "";
}
