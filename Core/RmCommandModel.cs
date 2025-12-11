namespace Core;

public class RmCommandModel
{
    public string TitleEn => "Git Remove";
    public string TitleFa => "حذف فایل‌ها از گیت";

    public string GuideHtmlEn => @"
<h3>Usage</h3>
<pre>git rm [options] <file>...</pre>
<h4>Examples</h4>
<pre>
git rm file1.txt           # Remove a file from the working directory and the index
git rm --cached file1.txt  # Remove a file from the index but keep it in the working directory
git rm -r directory/       # Remove a directory recursively
</pre>
<h4>Limitations</h4>
<ul>
<li>The file will be deleted from both the index and the working directory, unless using --cached</li>
<li>Cannot remove files that are already committed in the repository unless using --force</li>
</ul>
<h4>Options</h4>
<ul>
<li>-r : Remove directories recursively</li>
<li>-f : Force remove files that have already been committed</li>
<li>--cached : Remove a file from the index but keep it in the working directory</li>
<li>-n : Show what would be removed, without actually removing</li>
<li>-v : Verbose output</li>
</ul>
";

    public string GuideHtmlFa => @"
<h3>استفاده</h3>
<pre>git rm [گزینه‌ها] <فایل>...</pre>
<h4>مثال‌ها</h4>
<pre>
git rm file1.txt           # حذف یک فایل از دایرکتوری کاری و شاخص گیت
git rm --cached file1.txt  # حذف فایل از شاخص گیت ولی نگه داشتن آن در دایرکتوری کاری
git rm -r directory/       # حذف دایرکتوری به صورت بازگشتی
</pre>
<h4>محدودیت‌ها</h4>
<ul>
<li>فایل از شاخص و دایرکتوری کاری حذف می‌شود، مگر اینکه از --cached استفاده کنید</li>
<li>برای حذف فایل‌هایی که قبلاً در مخزن کامیت شده‌اند، باید از --force استفاده کنید</li>
</ul>
<h4>گزینه‌ها</h4>
<ul>
<li>-r : حذف دایرکتوری‌ها به صورت بازگشتی</li>
<li>-f : حذف اجباری فایل‌ها که قبلاً کامیت شده‌اند</li>
<li>--cached : حذف فایل از شاخص، ولی نگه داشتن آن در دایرکتوری کاری</li>
<li>-n : نمایش فایل‌هایی که قرار است حذف شوند، بدون حذف واقعی</li>
<li>-v : نمایش جزئیات بیشتر</li>
</ul>
";

    public List<GitField> Fields { get; set; } = new List<GitField>
    {
        new GitField { Name="Files", LabelEn="Files to Remove", LabelFa="فایل‌های حذف‌شده", Type="text", PlaceholderEn="file1.txt file2.txt", PlaceholderFa="مثال: file1.txt file2.txt", IsRequired=true },
        new GitField { Name="Force",
            LabelEn="Force Remove (-f)", LabelFa="حذف اجباری (-f)", Type="checkbox" },
new GitField { Name="Recursive", LabelEn="Recursive (-r)", LabelFa="حذف بازگشتی (-r)", Type="checkbox" },
new GitField { Name="Cached", LabelEn="Remove from Index (-cached)", LabelFa="حذف از شاخص (-cached)", Type="checkbox" },
new GitField { Name="DryRun", LabelEn="Dry Run (-n)", LabelFa="شبیه‌سازی (-n)", Type="checkbox" },
new GitField { Name="Verbose", LabelEn="Verbose (-v)", LabelFa="نمایش جزئیات بیشتر (-v)", Type="checkbox" }
};
}
