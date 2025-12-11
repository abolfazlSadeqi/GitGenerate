namespace Core;

public class UpdateIndexCommandModel
{
    public string TitleEn => "Update Index";
    public string TitleFa => "بروزرسانی ایندکس";

    public string GuideHtmlEn => @"
<h3>Usage</h3>
<pre>git update-index [options] [file...]</pre>

<h4>Examples</h4>
<pre>
git update-index file1.txt  # Update index for a specific file
git update-index --add file1.txt  # Add new file to the index
git update-index --assume-unchanged file2.txt  # Mark file as unchanged
</pre>

<h4>What It Does?</h4>
<p>The <strong>git update-index</strong> command updates the index (staging area) with the current state of your working directory. This is used to manage the staging of files, mark files as unchanged, and modify file permissions in the index without modifying the working directory itself.</p>

<h4>Common Use Cases</h4>
<ul>
    <li>Updating the index for a specific file after changes are made.</li>
    <li>Adding new files to the staging area.</li>
    <li>Marking files as unchanged to prevent accidental staging.</li>
    <li>Modifying file permissions in the index without changing the actual file.</li>
</ul>

<h4>Best Practices</h4>
<ul>
    <li>Use <strong>--add</strong> only when you want to explicitly add new files to the staging area.</li>
    <li>If you want to prevent accidental commits of files that are temporarily not relevant, use <strong>--assume-unchanged</strong>.</li>
    <li>Always be cautious when changing file permissions using <strong>--chmod</strong>, as this might affect others using the same repository.</li>
</ul>

<h4>Limitations</h4>
<ul>
    <li>Changes made with <strong>git update-index</strong> are local to the index and do not affect the working directory. It only updates the staging area.</li>
    <li>It doesn’t track files that have been deleted. To handle deleted files, you should use <strong>git rm</strong> instead.</li>
    <li>The <strong>--assume-unchanged</strong> flag only applies to files that have already been added to the index. It won't affect files that are untracked.</li>
</ul>

<h4>Common Mistakes</h4>
<ul>
    <li>Forgetting to use <strong>--add</strong> when you want to add new files to the index.</li>
    <li>Accidentally using <strong>--assume-unchanged</strong> on files that should actually be staged.</li>
    <li>Changing file permissions without considering the effect on collaborators.</li>
</ul>

<h2>Overview</h2>
<p>Git update-index is a command used to modify the staging area in Git without affecting the working directory. It can be used to add files, change permissions, or mark files as unchanged, which is useful in various scenarios like managing temporary files or preventing accidental staging of certain files.</p>

<h2>Comparison with Other Methods</h2>
<table border='1' cellpadding='10' cellspacing='0' style='border-collapse: collapse; width: 100%;'>
    <tr style='background-color: #f2f2f2;'>
        <th style='text-align: left; padding: 8px; font-weight: bold;'>Method</th>
        <th style='text-align: left; padding: 8px; font-weight: bold;'>Advantages</th>
        <th style='text-align: left; padding: 8px; font-weight: bold;'>Disadvantages</th>
    </tr>
    <tr>
        <td style='padding: 8px;'><strong>git update-index</strong></td>
        <td style='padding: 8px;'>Allows you to update the index without modifying the working directory. It is useful for adding files, changing permissions, or marking files as unchanged.</td>
        <td style='padding: 8px;'>Does not modify the working directory directly. It is only useful for managing the staging area.</td>
    </tr>
    <tr style='background-color: #f9f9f9;'>
        <td style='padding: 8px;'><strong>git add</strong></td>
        <td style='padding: 8px;'>Adds files to the staging area and prepares them for commit.</td>
        <td style='padding: 8px;'>Does not provide options for changing file permissions or marking files as unchanged.</td>
    </tr>
    <tr>
        <td style='padding: 8px;'><strong>git rm</strong></td>
        <td style='padding: 8px;'>Used for removing files from the index and working directory.</td>
        <td style='padding: 8px;'>Cannot be used for marking files as unchanged or modifying file permissions.</td>
    </tr>
</table>
";

    public string GuideHtmlFa => @"
<h3>استفاده</h3>
<pre>git update-index [گزینه‌ها] [فایل...]</pre>

<h4>مثال‌ها</h4>
<pre>
git update-index file1.txt  # بروزرسانی ایندکس برای یک فایل خاص
git update-index --add file1.txt  # اضافه کردن فایل جدید به ایندکس
git update-index --assume-unchanged file2.txt  # علامت‌گذاری فایل به‌عنوان بدون تغییر
</pre>

<h4>دقیقاً چه می‌کند؟</h4>
<p>دستور <strong>git update-index</strong> ایندکس (منطقه آماده‌سازی) را با وضعیت فعلی دایرکتوری کاری شما بروزرسانی می‌کند. این دستور برای مدیریت آماده‌سازی فایل‌ها، علامت‌گذاری فایل‌ها به‌عنوان بدون تغییر، و تغییر مجوزهای فایل در ایندکس استفاده می‌شود، بدون اینکه تغییراتی در دایرکتوری کاری ایجاد کند.</p>

<h4>موارد کاربرد رایج</h4>
<ul>
    <li>بروزرسانی ایندکس برای یک فایل خاص پس از ایجاد تغییرات.</li>
    <li>اضافه کردن فایل‌های جدید به منطقه آماده‌سازی.</li>
    <li>علامت‌گذاری فایل‌ها به‌عنوان بدون تغییر برای جلوگیری از اضافه شدن به commit.</li>
    <li>تغییر مجوزهای فایل‌ها در ایندکس بدون تغییر فایل واقعی.</li>
</ul>

<h4>بهترین شیوه‌ها</h4>
<ul>
    <li>از <strong>--add</strong> تنها زمانی استفاده کنید که بخواهید فایل‌های جدید را به منطقه آماده‌سازی اضافه کنید.</li>
    <li>اگر می‌خواهید فایل‌هایی را که موقتاً نیازی به commit ندارند، از اضافه شدن به commit جلوگیری کنید، از <strong>--assume-unchanged</strong> استفاده کنید.</li>
    <li>هنگام تغییر مجوزهای فایل با استفاده از <strong>--chmod</strong> دقت کنید، زیرا ممکن است این تغییرات روی سایر همکارانی که از همان مخزن استفاده می‌کنند تأثیر بگذارد.</li>
</ul>

<h4>محدودیت‌ها</h4>
<ul>
    <li>تغییراتی که با <strong>git update-index</strong> انجام می‌شود فقط در ایندکس محلی اعمال می‌شود و هیچ تأثیری بر دایرکتوری کاری ندارد.</li>
    <li>این دستور فایل‌های حذف‌شده را پیگیری نمی‌کند. برای مدیریت فایل‌های حذف‌شده باید از <strong>git rm</strong> استفاده کنید.</li>
    <li>علامت‌گذاری فایل‌ها به‌عنوان بدون تغییر با <strong>--assume-unchanged</strong> فقط برای فایل‌هایی که قبلاً به ایندکس اضافه شده‌اند، قابل‌استفاده است.</li>
</ul>

<h4>اشتباهات رایج</h4>
<ul>
    <li>فراموش کردن استفاده از <strong>--add</strong> زمانی که می‌خواهید فایل‌های جدید را به ایندکس اضافه کنید.</li>
    <li>استفاده نادرست از <strong>--assume-unchanged</strong> بر روی فایل‌هایی که باید به ایندکس اضافه شوند.</li>
    <li>تغییر مجوزهای فایل بدون در نظر گرفتن تأثیر آن بر همکاران.</li>
</ul>

<h2>نمای کلی</h2>
<p>دستور <strong>git update-index</strong> ابزاری برای بروزرسانی ایندکس در گیت است که به شما امکان می‌دهد بدون تغییر دایرکتوری کاری، فایل‌ها را به ایندکس اضافه کنید، مجوزهای فایل‌ها را تغییر دهید یا فایل‌ها را به‌عنوان بدون تغییر علامت‌گذاری کنید. این ابزار در سناریوهای مختلف برای مدیریت فایل‌ها در مخزن گیت مفید است.</p>

<h2>مقایسه با روش‌های دیگر</h2>
<table border='1' cellpadding='10' cellspacing='0' style='border-collapse: collapse; width: 100%;'>
    <tr style='background-color: #f2f2f2;'>
        <th style='text-align: left; padding: 8px; font-weight: bold;'>روش</th>
        <th style='text-align: left; padding: 8px; font-weight: bold;'>مزایا</th>
        <th style='text-align: left; padding: 8px; font-weight: bold;'>معایب</th>
    </tr>
    <tr>
        <td style='padding: 8px;'><strong>git update-index</strong></td>
        <td style='padding: 8px;'>این دستور به شما این امکان را می‌دهد که ایندکس را بدون تغییر دایرکتوری کاری بروزرسانی کنید. برای اضافه کردن فایل‌ها، تغییر مجوزها یا علامت‌گذاری فایل‌ها به‌عنوان بدون تغییر مفید است.</td>
        <td style='padding: 8px;'>تأثیری بر دایرکتوری کاری ندارد و تنها ایندکس را مدیریت می‌کند.</td>
    </tr>
    <tr style='background-color: #f9f9f9;'>
        <td style='padding: 8px;'><strong>git add</strong></td>
        <td style='padding: 8px;'>این دستور فایل‌ها را به ایندکس اضافه می‌کند و آن‌ها را برای commit آماده می‌سازد.</td>
        <td style='padding: 8px;'>نمی‌توان از آن برای تغییر مجوز فایل‌ها یا علامت‌گذاری فایل‌ها به‌عنوان بدون تغییر استفاده کرد.</td>
    </tr>
    <tr>
        <td style='padding: 8px;'><strong>git rm</strong></td>
        <td style='padding: 8px;'>این دستور برای حذف فایل‌ها از ایندکس و دایرکتوری کاری استفاده می‌شود.</td>
        <td style='padding: 8px;'>نمی‌توان از آن برای علامت‌گذاری فایل‌ها به‌عنوان بدون تغییر یا تغییر مجوزهای فایل استفاده کرد.</td>
    </tr>
</table>
";

    public List<GitField> Fields { get; set; } = new List<GitField>
    {
        new GitField { Name="File", LabelEn="File", LabelFa="فایل", Type="text", PlaceholderEn="file1.txt", PlaceholderFa="file1.txt", IsRequired=true },
        new GitField { Name="Add", LabelEn="Add File (--add)", LabelFa="اضافه کردن فایل (--add)", Type="checkbox" },
        new GitField { Name="AssumeUnchanged", LabelEn="Assume Unchanged (--assume-unchanged)", LabelFa="فرض تغییر نکرده (--assume-unchanged)", Type="checkbox" },
        new GitField { Name="Chmod", LabelEn="Change File Mode (--chmod)", LabelFa="تغییر مجوز فایل (--chmod)", Type="text", PlaceholderEn="+x", PlaceholderFa="+x" }
    };
}
