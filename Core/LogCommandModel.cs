namespace Core;

public class LogCommandModel
{
    public string TitleEn => "View Commit History";
    public string TitleFa => "مشاهده تاریخچه کامیت‌ها";

    public string GuideHtmlEn => @"
<h3>Usage</h3>
<pre>git log [options]</pre>

<h4>What is Git Log?</h4>
<p>The <strong>git log</strong> command shows the commit history of the repository. By default, it displays a list of commits in reverse chronological order.</p>

<h4>Common Use Cases</h4>
<ul>
    <li>Reviewing commit history for debugging or tracking changes over time.</li>
    <li>Finding specific commits from a particular author or related to a specific topic.</li>
    <li>Visualizing commit history in a more intuitive way with graphical representations.</li>
    <li>Inspecting the commit history for a specific file to see who modified it and when.</li>
</ul>

<h4>Examples</h4>
<pre>
# Show the latest 5 commits
git log -n 5

# Show commits from a specific author
git log --author='John Doe'

# Show commits containing a specific keyword
git log --grep='bug fix'

# Show commit history for a specific file
git log -- <file-path>

# Show a graphical representation of the commit history
git log --graph --oneline --decorate --all
</pre>

<h4>What Does Git Log Do?</h4>
<p>Git log shows the history of commits in the current branch or all branches, depending on the options used. You can filter by author, date, commit message, and even search for specific patterns or keywords within the commit messages. Additionally, it can provide a graphical representation of the repository's commit history.</p>

<h4>Comparison with Git Show</h4>
<p>While <strong>git show</strong> displays information about a specific commit (including changes made), <strong>git log</strong> shows the history of multiple commits. <strong>git show</strong> is useful for inspecting individual commits, while <strong>git log</strong> provides an overview of the commit history.</p>

<h4>Comparison Table</h4>
<table style='width: 100%; border-collapse: collapse; margin-top: 20px;'>
    <thead>
        <tr>
            <th style='background-color: #4CAF50; color: white; padding: 10px; text-align: left;'>Feature</th>
            <th style='background-color: #4CAF50; color: white; padding: 10px; text-align: left;'>Git Log</th>
            <th style='background-color: #4CAF50; color: white; padding: 10px; text-align: left;'>Git Show</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td style='border: 1px solid #ddd; padding: 8px;'>Purpose</td>
            <td style='border: 1px solid #ddd; padding: 8px;'>Shows history of multiple commits</td>
            <td style='border: 1px solid #ddd; padding: 8px;'>Shows details of a specific commit</td>
        </tr>
        <tr>
            <td style='border: 1px solid #ddd; padding: 8px;'>Output</td>
            <td style='border: 1px solid #ddd; padding: 8px;'>List of commits</td>
            <td style='border: 1px solid #ddd; padding: 8px;'>Detailed commit information (including changes)</td>
        </tr>
        <tr>
            <td style='border: 1px solid #ddd; padding: 8px;'>Granularity</td>
            <td style='border: 1px solid #ddd; padding: 8px;'>Displays multiple commits</td>
            <td style='border: 1px solid #ddd; padding: 8px;'>Displays individual commit details</td>
        </tr>
        <tr>
            <td style='border: 1px solid #ddd; padding: 8px;'>Visualization</td>
            <td style='border: 1px solid #ddd; padding: 8px;'>Can visualize commit history graphically</td>
            <td style='border: 1px solid #ddd; padding: 8px;'>Cannot visualize commit history graphically</td>
        </tr>
    </tbody>
</table>

<h4>In Simple Terms</h4>
<p>Git log is a way to look back at your Git history. It lets you see which changes were made, when, and by whom. You can narrow down the history to specific dates, authors, or files, and visualize it with a graph if needed.</p>

<h4>Common Mistakes</h4>
<ul>
    <li>Overwhelming output in large repositories – filtering with options like <strong>--author</strong>, <strong>--since</strong>, or <strong>-n</strong> helps.</li>
    <li>Forgetting that the default view only shows commits from the current branch unless <strong>--all</strong> is specified.</li>
    <li>Using <strong>--graph</strong> in very large repositories may make the output harder to read due to complexity.</li>
</ul>

<h2>Best Practices</h2>
<ul>
    <li>Use <strong>--oneline</strong> for a concise view of commit history.</li>
    <li>Use <strong>--author</strong> and <strong>--grep</strong> to quickly find specific commits without manually scrolling through a long list.</li>
    <li>If dealing with large repositories, specify a date range with <strong>--since</strong> and <strong>--until</strong> to narrow down results.</li>
    <li>Use <strong>--graph</strong> and <strong>--decorate</strong> together for a more visual and organized output.</li>
</ul>

<h2>Limitations</h2>
<ul>
    <li>Can be overwhelming for large repositories with long commit history.</li>
    <li>May not show merged branches without specific flags like <strong>--all</strong>.</li>
    <li>Cannot show commits from a remote repository unless fetched first.</li>
</ul>

<h3>How to Use</h3>
<p>Git log is versatile and can be customized with multiple options. You can filter by author, date, commit message, or even limit the number of commits displayed. It’s a powerful tool for analyzing and understanding the history of your project.</p>

<h2>Overview</h2>
<p>Git log provides detailed insights into the history of your Git repository. Whether you're tracking bugs, reviewing changes, or simply curious about your project's history, it's an indispensable tool for navigating through commit history.</p>

<h4>Options</h4>
<ul>
    <li>-n, --max-count <n> : Show a limited number of commits</li>
    <li>--author <name> : Filter by author name</li>
    <li>--grep <pattern> : Search commit messages by pattern</li>
    <li>--since <date> : Show commits after a specific date</li>
    <li>--until <date> : Show commits before a specific date</li>
    <li>--graph : Show commit history in a graphical format</li>
    <li>--oneline : Show each commit in a single line</li>
    <li>--decorate : Show references to branches, tags, etc.</li>
    <li>--all : Show commits from all branches</li>
    <li>-- <file> : Show history for a specific file</li>
</ul>";

    public string GuideHtmlFa => @"
<h3>استفاده</h3>
<pre>git log [گزینه‌ها]</pre>

<h4>Git Log چیست؟</h4>
<p>دستور <strong>git log</strong> تاریخچه کامیت‌های مخزن را نمایش می‌دهد. به طور پیش‌فرض، لیستی از کامیت‌ها را به ترتیب معکوس تاریخی نمایش می‌دهد.</p>

<h4>موارد کاربرد رایج</h4>
<ul>
    <li>بررسی تاریخچه کامیت‌ها برای عیب‌یابی یا پیگیری تغییرات در طول زمان.</li>
    <li>یافتن کامیت‌های خاص از یک نویسنده خاص یا مرتبط با موضوع خاص.</li>
    <li>نمایش تاریخچه کامیت‌ها به صورت گرافیکی برای درک بهتر تاریخچه پروژه.</li>
    <li>بازبینی تاریخچه کامیت‌ها برای یک فایل خاص و مشاهده تغییرات آن در طول زمان.</li>
</ul>

<h4>مثال‌ها</h4>
<pre>
# Show the latest 5 commits
git log -n 5

# Show commits from a specific author
git log --author='John Doe'

# Show commits containing a specific keyword
git log --grep='bug fix'

# Show commit history for a specific file
git log -- <file-path>

# Show a graphical representation of the commit history
git log --graph --oneline --decorate --all
</pre>

<h4>دقیقاً چه می‌کند؟</h4>
<p>Git log تاریخچه کامیت‌ها در شاخه فعلی یا همه شاخه‌ها را بسته به گزینه‌های انتخابی نمایش می‌دهد. شما می‌توانید بر اساس نویسنده، تاریخ، پیام کامیت و حتی جستجو برای الگوهای خاص در پیام‌های کامیت، تاریخچه را فیلتر کنید. همچنین می‌توانید تاریخچه را به صورت گرافیکی مشاهده کنید.</p>

<h4>مقایسه با git show</h4>
<p>در حالی که <strong>git show</strong> اطلاعات مربوط به یک کامیت خاص (شامل تغییرات ایجاد شده) را نمایش می‌دهد، <strong>git log</strong> تاریخچه چندین کامیت را نشان می‌دهد. <strong>git show</strong> برای بررسی کامیت‌های فردی مفید است، در حالی که <strong>git log</strong> نمای کلی از تاریخچه کامیت‌ها را فراهم می‌کند.</p>

<h4>مقایسه جدول</h4>
<table style='width: 100%; border-collapse: collapse; margin-top: 20px;'>
    <thead>
        <tr>
            <th style='background-color: #4CAF50; color: white; padding: 10px; text-align: left;'>ویژگی</th>
            <th style='background-color: #4CAF50; color: white; padding: 10px; text-align: left;'>Git Log</th>
            <th style='background-color: #4CAF50; color: white; padding: 10px; text-align: left;'>Git Show</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td style='border: 1px solid #ddd; padding: 8px;'>هدف</td>
            <td style='border: 1px solid #ddd; padding: 8px;'>نمایش تاریخچه چندین کامیت</td>
            <td style='border: 1px solid #ddd; padding: 8px;'>نمایش جزئیات یک کامیت خاص</td>
        </tr>
        <tr>
            <td style='border: 1px solid #ddd; padding: 8px;'>خروجی</td>
            <td style='border: 1px solid #ddd; padding: 8px;'>لیست کامیت‌ها</td>
            <td style='border: 1px solid #ddd; padding: 8px;'>اطلاعات جزئی کامیت (شامل تغییرات)</td>
        </tr>
        <tr>
            <td style='border: 1px solid #ddd; padding: 8px;'>مقیاس</td>
            <td style='border: 1px solid #ddd; padding: 8px;'>نمایش چندین کامیت</td>
            <td style='border: 1px solid #ddd; padding: 8px;'>نمایش جزئیات یک کامیت</td>
        </tr>
        <tr>
            <td style='border: 1px solid #ddd; padding: 8px;'>گرافیک</td>
            <td style='border: 1px solid #ddd; padding: 8px;'>نمایش گرافیکی تاریخچه کامیت‌ها</td>
            <td style='border: 1px solid #ddd; padding: 8px;'>نمایش گرافیکی تاریخچه کامیت‌ها ندارد</td>
        </tr>
    </tbody>
</table>

<h4>اشتباهات رایج</h4>
<ul>
    <li>خروجی زیاد در مخازن بزرگ – استفاده از گزینه‌های فیلتر مانند <strong>--author</strong>، <strong>--since</strong> یا <strong>-n</strong> به کاهش حجم خروجی کمک می‌کند.</li>
    <li>فراموش کردن اینکه نمایش پیش‌فرض فقط کامیت‌های شاخه فعلی را نشان می‌دهد مگر اینکه از گزینه <strong>--all</strong> استفاده کنید.</li>
    <li>استفاده از <strong>--graph</strong> در مخازن بسیار بزرگ ممکن است باعث شود خروجی پیچیده و خوانا نباشد.</li>
</ul>

<h2>بهترین شیوه‌ها</h2>
<ul>
    <li>برای مشاهده تاریخچه کامیت‌ها به طور مختصر از گزینه <strong>--oneline</strong> استفاده کنید.</li>
    <li>برای یافتن سریع کامیت‌های خاص از گزینه‌های <strong>--author</strong> و <strong>--grep</strong> استفاده کنید.</li>
    <li>در هنگام کار با مخازن بزرگ، تاریخچه را با استفاده از گزینه‌های <strong>--since</strong> و <strong>--until</strong> محدود کنید.</li>
    <li>برای مشاهده تاریخچه به صورت گرافیکی و منظم از گزینه‌های <strong>--graph</strong> و <strong>--decorate</strong> همزمان استفاده کنید.</li>
</ul>

<h2>محدودیت‌ها</h2>
<ul>
    <li>برای مخازن بزرگ که تاریخچه طولانی دارند، ممکن است گیج‌کننده باشد.</li>
    <li>ممکن است بدون استفاده از پرچم‌های خاص، شاخه‌های merge شده را نشان ندهد.</li>
    <li>کامیت‌های مربوط به مخزن remote فقط با fetch شدن قابل مشاهده هستند.</li>
</ul>

<h3>نحوه استفاده</h3>
<p>Git log بسیار قابل تنظیم است و می‌توانید با استفاده از گزینه‌های مختلف آن را سفارشی کنید. می‌توانید بر اساس نویسنده، تاریخ، پیام کامیت یا حتی تعداد کامیت‌ها آن را فیلتر کنید. این ابزار برای بررسی و تحلیل تاریخچه پروژه بسیار مفید است.</p>

<h2>نمای کلی</h2>
<p>Git log بینش‌های دقیقی از تاریخچه مخزن شما فراهم می‌کند. چه برای پیگیری مشکلات، بررسی تغییرات یا فقط کنجکاوی در مورد تاریخچه پروژه، این ابزار برای مرور تاریخچه کامیت‌ها ضروری است.</p>

<h4>گزینه‌ها</h4>
<ul>
    <li>-n, --max-count <n> : نمایش تعداد محدودی از کامیت‌ها</li>
    <li>--author <name> : فیلتر کردن بر اساس نام نویسنده</li>
    <li>--grep <pattern> : جستجو در پیام‌های کامیت</li>
    <li>--since <date> : نمایش کامیت‌ها از یک تاریخ خاص</li>
    <li>--until <date> : نمایش کامیت‌ها قبل از یک تاریخ خاص</li>
    <li>--graph : نمایش تاریخچه کامیت‌ها به صورت گرافیکی</li>
    <li>--oneline : نمایش هر کامیت در یک خط</li>
    <li>--decorate : نمایش ارجاع به شاخه‌ها، تگ‌ها و غیره</li>
    <li>--all : نمایش کامیت‌ها از همه شاخه‌ها</li>
    <li>-- <file> : نمایش تاریخچه برای یک فایل خاص</li>
</ul>";

    public List<GitField> Fields { get; set; } = new List<GitField>
    {
        new GitField { Name="MaxCount", LabelEn="Max Commit Count", LabelFa="تعداد حداکثر کامیت‌ها", Type="number", PlaceholderEn="5", PlaceholderFa="5" },
        new GitField { Name="Author", LabelEn="Author", LabelFa="نویسنده", Type="text", PlaceholderEn="John Doe", PlaceholderFa="جان دو" },
        new GitField { Name="Grep", LabelEn="Grep Pattern", LabelFa="الگوی جستجو", Type="text", PlaceholderEn="bug fix", PlaceholderFa="bug fix" },
        new GitField { Name="Since", LabelEn="Since Date", LabelFa="از تاریخ", Type="date", PlaceholderEn="2021-01-01", PlaceholderFa="2021-01-01" },
        new GitField { Name="Until", LabelEn="Until Date", LabelFa="تا تاریخ", Type="date", PlaceholderEn="2021-12-31", PlaceholderFa="2021-12-31" },
        new GitField { Name="File", LabelEn="File", LabelFa="فایل", Type="text", PlaceholderEn="file.txt", PlaceholderFa="file.txt" },
        new GitField { Name="Graph", LabelEn="Show Graph", LabelFa="نمایش گراف", Type="checkbox" },
        new GitField { Name="Oneline", LabelEn="Oneline", LabelFa="یک خطی", Type="checkbox" },
        new GitField { Name="Decorate", LabelEn="Decorate", LabelFa="تزئین", Type="checkbox" },
        new GitField { Name="All", LabelEn="Show All Branches", LabelFa="نمایش همه شاخه‌ها", Type="checkbox" }
    };
}
