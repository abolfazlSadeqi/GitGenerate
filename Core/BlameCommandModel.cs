namespace Core;

public class BlameCommandModel
{
    public string TitleEn => "Git Blame";
    public string TitleFa => "بلِیم";

    public string GuideHtmlEn => @"
<h3>Usage</h3>
<pre>git blame [options] <file></pre>

<h4>Examples</h4>
<pre>
git blame file.txt           # Blame the file and show line-by-line changes
git blame -L 10,20 file.txt  # Show lines 10 to 20 in the file
git blame --show-number file.txt  # Show line numbers with blame
git blame --reverse file.txt  # Show commit history in reverse order
</pre>

<h4>What It Does?</h4>
<p>The <strong>git blame</strong> command is used to show which commit and which author are responsible for each line of a file. This command helps to trace the history of a file and see how it has changed over time, including who made specific changes.</p>

<h4>Common Use Cases</h4>
<ul>
    <li>Identifying who made specific changes to a file.</li>
    <li>Tracing the history of a file and identifying the exact commit that modified a particular line.</li>
    <li>Debugging issues by reviewing changes made by different authors.</li>
</ul>

<h4>Best Practices</h4>
<ul>
    <li>Use <strong>-L</strong> to limit the output to a specific range of lines, which is helpful when debugging a specific section of a file.</li>
    <li>Use <strong>--reverse</strong> to show commits in reverse order, especially useful for reviewing the most recent changes first.</li>
    <li>Use <strong>--author</strong> to filter the blame by a specific author when you want to know who is responsible for particular changes.</li>
</ul>

<h4>Limitations</h4>
<ul>
    <li>The command only works for files that are currently tracked in the repository and does not work on untracked files.</li>
    <li>Blame may not be accurate if the file has been heavily modified or rebased multiple times, as this can affect the commit history.</li>
</ul>

<h4>Common Mistakes</h4>
<ul>
    <li>Misunderstanding the output of <strong>git blame</strong> as it shows the most recent commit that touched a line, not necessarily the first commit that made the change.</li>
    <li>Not using <strong>-L</strong> to limit the range of lines, which could lead to an overwhelming amount of information if the file is large.</li>
</ul>

<h2>Overview</h2>
<p>The <strong>git blame</strong> command is primarily used to identify which commit and which author made changes to a particular line of code. This is extremely useful when tracing the history of bugs or changes in code, and for understanding how a file has evolved over time.</p>

<h2>Comparison with Other Methods</h2>
<table border='1' cellpadding='10' cellspacing='0' style='border-collapse: collapse; width: 100%;'>
    <tr style='background-color: #f2f2f2;'>
        <th style='text-align: left; padding: 8px; font-weight: bold;'>Method</th>
        <th style='text-align: left; padding: 8px; font-weight: bold;'>Advantages</th>
        <th style='text-align: left; padding: 8px; font-weight: bold;'>Disadvantages</th>
    </tr>
    <tr>
        <td style='padding: 8px;'><strong>git blame</strong></td>
        <td style='padding: 8px;'>Helps trace who modified specific lines of code and tracks the evolution of the file.</td>
        <td style='padding: 8px;'>Shows the most recent commit for each line, which may not be useful if the file has been heavily rebased or modified.</td>
    </tr>
    <tr style='background-color: #f9f9f9;'>
        <td style='padding: 8px;'><strong>git log</strong></td>
        <td style='padding: 8px;'>Shows a detailed history of commits for the entire repository or branch, including commit messages.</td>
        <td style='padding: 8px;'>Does not provide line-by-line details of who modified each line in a file.</td>
    </tr>
    <tr>
        <td style='padding: 8px;'><strong>git diff</strong></td>
        <td style='padding: 8px;'>Shows the difference between commits or between the working directory and the repository.</td>
        <td style='padding: 8px;'>Does not provide information about the specific author or commit for each line of code.</td>
    </tr>
</table>
";

    public string GuideHtmlFa => @"
<h3>استفاده</h3>
<pre>git blame [گزینه‌ها] <فایل></pre>

<h4>مثال‌ها</h4>
<pre>
git blame file.txt           # Blame the file and show line-by-line changes
git blame -L 10,20 file.txt  # Show lines 10 to 20 in the file
git blame --show-number file.txt  # Show line numbers with blame
git blame --reverse file.txt  # Show commit history in reverse order
</pre>

<h4>دقیقاً چه می‌کند؟</h4>
<p>دستور <strong>git blame</strong> به شما این امکان را می‌دهد که ببینید هر خط از یک فایل توسط کدام commit و کدام نویسنده تغییر یافته است. این دستور به شما کمک می‌کند تا تاریخچه تغییرات یک فایل را بررسی کنید و ببینید چه کسی تغییرات خاصی را ایجاد کرده است.</p>

<h4>موارد کاربرد رایج</h4>
<ul>
    <li>شناسایی اینکه کدام نویسنده یا commit باعث تغییرات خاص در یک فایل شده است.</li>
    <li>پیگیری تاریخچه یک فایل و شناسایی commit خاصی که یک خط را تغییر داده است.</li>
    <li>عیب‌یابی مشکلات با بررسی تغییرات ایجاد شده توسط نویسندگان مختلف.</li>
</ul>

<h4>بهترین شیوه‌ها</h4>
<ul>
    <li>از گزینه <strong>-L</strong> برای محدود کردن خروجی به یک بازه خاص از خطوط استفاده کنید، که در زمان عیب‌یابی یک بخش خاص از فایل بسیار مفید است.</li>
    <li>از گزینه <strong>--reverse</strong> برای نمایش تاریخچه commits به صورت معکوس استفاده کنید، که به ویژه زمانی مفید است که بخواهید تغییرات اخیر را ابتدا بررسی کنید.</li>
    <li>از گزینه <strong>--author</strong> برای فیلتر کردن بلِیم بر اساس یک نویسنده خاص استفاده کنید تا بدانید که کدام تغییرات توسط نویسنده خاصی ایجاد شده‌اند.</li>
</ul>

<h4>محدودیت‌ها</h4>
<ul>
    <li>این دستور تنها برای فایل‌هایی که در حال حاضر در مخزن ردیابی می‌شوند کار می‌کند و بر روی فایل‌های غیر ردیابی کار نمی‌کند.</li>
    <li>بلِیم ممکن است دقیق نباشد اگر فایل تغییرات زیادی داشته باشد یا چندین بار ری‌بیس شده باشد، زیرا تاریخچه commit ها می‌تواند تحت تأثیر قرار گیرد.</li>
</ul>

<h4>اشتباهات رایج</h4>
<ul>
    <li>درک نادرست خروجی <strong>git blame</strong>، زیرا این دستور تنها آخرین commit ای را که یک خط را تغییر داده است نشان می‌دهد، نه اولین commit که تغییر را اعمال کرده است.</li>
    <li>عدم استفاده از <strong>-L</strong> برای محدود کردن بازه خطوط، که ممکن است باعث نمایش حجم زیادی از اطلاعات شود اگر فایل بزرگ باشد.</li>
</ul>

<h2>نمای کلی</h2>
<p>دستور <strong>git blame</strong> عمدتاً برای شناسایی کدام commit و کدام نویسنده تغییرات خاصی را در یک خط از کد اعمال کرده است استفاده می‌شود. این ابزار در زمان پیگیری تاریخچه مشکلات یا تغییرات در کد بسیار مفید است و به شما کمک می‌کند تا نحوه تکامل یک فایل را در طول زمان درک کنید.</p>

<h2>مقایسه با روش‌های دیگر</h2>
<table border='1' cellpadding='10' cellspacing='0' style='border-collapse: collapse; width: 100%;'>
    <tr style='background-color: #f2f2f2;'>
        <th style='text-align: left; padding: 8px; font-weight: bold;'>روش</th>
        <th style='text-align: left; padding: 8px; font-weight: bold;'>مزایا</th>
        <th style='text-align: left; padding: 8px; font-weight: bold;'>معایب</th>
    </tr>
    <tr>
        <td style='padding: 8px;'><strong>git blame</strong></td>
        <td style='padding: 8px;'>کمک می‌کند تا بفهمید چه کسی تغییرات خاصی را در یک فایل اعمال کرده و تاریخچه فایل را پیگیری کنید.</td>
        <td style='padding: 8px;'>فقط commit اخیر را برای هر خط نشان می‌دهد، که در صورتی که فایل تغییرات زیادی داشته باشد یا چندین بار ری‌بیس شده باشد ممکن است مفید نباشد.</td>
    </tr>
    <tr style='background-color: #f9f9f9;'>
        <td style='padding: 8px;'><strong>git log</strong></td>
        <td style='padding: 8px;'>تاریخچه کامل commit ها را برای کل مخزن یا شاخه نمایش می‌دهد و شامل پیام‌های commit است.</td>
        <td style='padding: 8px;'>اطلاعات خط به خط که نشان می‌دهد چه کسی کدام خط را تغییر داده، ندارد.</td>
    </tr>
    <tr>
        <td style='padding: 8px;'><strong>git diff</strong></td>
        <td style='padding: 8px;'>تفاوت‌ها را بین commits یا بین دایرکتوری کاری و مخزن نمایش می‌دهد.</td>
        <td style='padding: 8px;'>اطلاعاتی در مورد نویسنده خاص یا commit برای هر خط کد نمی‌دهد.</td>
    </tr>
</table>
";
    public List<GitField> Fields { get; set; } = new List<GitField>
    {
        new GitField { Name="FileName", LabelEn="File Name", LabelFa="نام فایل", Type="text", PlaceholderEn="file.txt", PlaceholderFa="مثال: file.txt", IsRequired=true },
        new GitField { Name="LineRange", LabelEn="Line Range (-L)", LabelFa="محدوده خطوط (-L)", Type="text", PlaceholderEn="10,20", PlaceholderFa="مثال: 10,20" },
        new GitField { Name="ShowNumber", LabelEn="Show Line Numbers (--show-number)", LabelFa="نمایش شماره خطوط (--show-number)", Type="checkbox" },
        new GitField { Name="Reverse", LabelEn="Reverse (--reverse)", LabelFa="ترتیب معکوس (--reverse)", Type="checkbox" },
        new GitField { Name="Author", LabelEn="Author (--author)", LabelFa="نویسنده (--author)", Type="text", PlaceholderEn="John Doe", PlaceholderFa="مثال: John Doe" },
        new GitField { Name="Date", LabelEn="Date (--date)", LabelFa="تاریخ (--date)", Type="text", PlaceholderEn="2022-01-01", PlaceholderFa="مثال: 2022-01-01" }
    };
}
