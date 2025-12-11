namespace Core;

public class ShortlogCommandModel
{
    public string TitleEn => "Short Log";
    public string TitleFa => "لاگ کوتاه";

    public string GuideHtmlEn => @"
<h3>Usage</h3>
<pre>git shortlog [options]</pre>

<h4>Examples</h4>
<pre>
git shortlog                # Show a summary of commits by author
git shortlog -n             # Sort by number of commits
git shortlog -e             # Show email addresses of authors
git shortlog --since=<date> # Show commits since a certain date
</pre>

<h4>What It Does?</h4>
<p>The <strong>git shortlog</strong> command provides a summarized view of commit history, grouped by author. This helps to get a quick overview of who contributed the most and when, often used for generating contributor statistics.</p>

<h4>Common Use Cases</h4>
<ul>
    <li>Summarizing commit history by author.</li>
    <li>Generating statistics for contributors in a project.</li>
    <li>Finding out who committed the most changes in a specific time period.</li>
    <li>Tracking changes by specific authors over time.</li>
</ul>

<h4>Best Practices</h4>
<ul>
    <li>Use <strong>-n</strong> to sort the list by the number of commits to easily see who has the most contributions.</li>
    <li>If you're working on a team, use <strong>-e</strong> to include email addresses to identify contributors more accurately.</li>
    <li>Use <strong>--since</strong> to filter commits by a specific date range, which can be useful for generating weekly or monthly contributor reports.</li>
</ul>

<h4>Limitations</h4>
<ul>
    <li>It only summarizes the commits, so it won't give you details about individual commits (e.g., commit messages or diff).</li>
    <li>If you're looking for specific commit details, you should use <strong>git log</strong> instead.</li>
    <li>The <strong>git shortlog</strong> command doesn't show authors who have made no commits, which can be limiting when you need a full contributor list.</li>
</ul>

<h4>Common Mistakes</h4>
<ul>
    <li>Forgetting to use <strong>-n</strong> when you need to sort by the number of commits, which may lead to an unordered output.</li>
    <li>Using it without filtering by date (e.g., <strong>--since</strong>) when you need reports for a specific period.</li>
    <li>Not considering the fact that email addresses may not be available if authors don't have a consistent email format.</li>
</ul>

<h2>Overview</h2>
<p>Git shortlog is a powerful command for summarizing commit history by author. It's a great tool for generating contributor statistics or reviewing who contributed to the project over time. It's important to know that it's best used for high-level summaries, and not for deep dive into commit details.</p>

<h2>Comparison with Other Methods</h2>
<table border='1' cellpadding='10' cellspacing='0' style='border-collapse: collapse; width: 100%;'>
    <tr style='background-color: #f2f2f2;'>
        <th style='text-align: left; padding: 8px; font-weight: bold;'>Method</th>
        <th style='text-align: left; padding: 8px; font-weight: bold;'>Advantages</th>
        <th style='text-align: left; padding: 8px; font-weight: bold;'>Disadvantages</th>
    </tr>
    <tr>
        <td style='padding: 8px;'><strong>git shortlog</strong></td>
        <td style='padding: 8px;'>Summarizes commit history by author and provides a high-level view of contributions.</td>
        <td style='padding: 8px;'>Does not provide detailed commit information or any commit message content.</td>
    </tr>
    <tr style='background-color: #f9f9f9;'>
        <td style='padding: 8px;'><strong>git log</strong></td>
        <td style='padding: 8px;'>Provides detailed commit history, including commit messages and diffs.</td>
        <td style='padding: 8px;'>Can be overwhelming with a large number of commits, making it harder to get a high-level view.</td>
    </tr>
    <tr>
        <td style='padding: 8px;'><strong>git blame</strong></td>
        <td style='padding: 8px;'>Shows detailed line-by-line information about who committed specific changes.</td>
        <td style='padding: 8px;'>Can be too granular and does not summarize the entire commit history.</td>
    </tr>
</table>
";

    public string GuideHtmlFa => @"
<h3>استفاده</h3>
<pre>git shortlog [گزینه‌ها]</pre>

<h4>مثال‌ها</h4>
<pre>
git shortlog                # نمایش خلاصه‌ای از commit‌ها بر اساس نویسنده
git shortlog -n             # مرتب‌سازی بر اساس تعداد commit‌ها
git shortlog -e             # نمایش آدرس ایمیل نویسندگان
git shortlog --since=<تاریخ> # نمایش commit‌ها از تاریخ مشخص
</pre>

<h4>دقیقاً چه می‌کند؟</h4>
<p>دستور <strong>git shortlog</strong> خلاصه‌ای از تاریخچه commit ها به تفکیک نویسنده ارائه می‌دهد. این ابزار به شما کمک می‌کند تا یک نمای کلی از مشارکت‌های افراد در پروژه و تاریخچه تغییرات داشته باشید. این دستور معمولاً برای تولید آمار و گزارش‌های مربوط به نویسندگان استفاده می‌شود.</p>

<h4>موارد کاربرد رایج</h4>
<ul>
    <li>خلاصه‌سازی تاریخچه commit‌ها بر اساس نویسنده.</li>
    <li>تولید آمار از مشارکت‌کنندگان پروژه.</li>
    <li>یافتن اینکه چه کسی بیشترین commit‌ها را در یک بازه زمانی خاص انجام داده است.</li>
    <li>پیگیری تغییرات در یک پروژه توسط نویسندگان مختلف در طول زمان.</li>
</ul>

<h4>بهترین شیوه‌ها</h4>
<ul>
    <li>از <strong>-n</strong> برای مرتب‌سازی براساس تعداد commit‌ها استفاده کنید تا ببینید چه کسی بیشترین مشارکت را داشته است.</li>
    <li>اگر با تیمی کار می‌کنید، از <strong>-e</strong> برای نمایش آدرس ایمیل‌ها استفاده کنید تا شناسایی مشارکت‌کنندگان دقیق‌تر باشد.</li>
    <li>از <strong>--since</strong> برای فیلتر کردن commit ها بر اساس تاریخ استفاده کنید، این امر برای تولید گزارش‌های هفتگی یا ماهانه مفید است.</li>
</ul>

<h4>محدودیت‌ها</h4>
<ul>
    <li>فقط تاریخچه commit ها را خلاصه می‌کند و اطلاعات مربوط به جزئیات commit مانند پیام‌ها یا diffs را نشان نمی‌دهد.</li>
    <li>اگر به دنبال جزئیات دقیق commit‌ها هستید، باید از <strong>git log</strong> استفاده کنید.</li>
    <li>دستور <strong>git shortlog</strong> فقط نویسندگانی را نشان می‌دهد که commit انجام داده‌اند و ممکن است نویسندگان بدون commit را نشان ندهد.</li>
</ul>

<h4>اشتباهات رایج</h4>
<ul>
    <li>فراموش کردن استفاده از <strong>-n</strong> برای مرتب‌سازی بر اساس تعداد commit‌ها، که ممکن است خروجی نامرتب شود.</li>
    <li>استفاده از آن بدون فیلتر کردن تاریخ (مثلاً <strong>--since</strong>) زمانی که نیاز به گزارش در بازه زمانی خاص دارید.</li>
    <li>عدم توجه به اینکه آدرس‌های ایمیل ممکن است در صورتی که نویسندگان فرمت ایمیل ثابت نداشته باشند، در دسترس نباشند.</li>
</ul>

<h2>نمای کلی</h2>
<p>دستور <strong>git shortlog</strong> ابزاری مفید برای خلاصه‌سازی تاریخچه commit ها بر اساس نویسنده است. این ابزار معمولاً برای تولید آمار و گزارش‌هایی در مورد مشارکت‌ها و تغییرات در پروژه استفاده می‌شود. با این حال، این دستور بیشتر برای خلاصه‌های سطح بالا مفید است و برای جستجو در جزئیات commit ها مناسب نیست.</p>

<h2>مقایسه با روش‌های دیگر</h2>
<table border='1' cellpadding='10' cellspacing='0' style='border-collapse: collapse; width: 100%;'>
    <tr style='background-color: #f2f2f2;'>
        <th style='text-align: left; padding: 8px; font-weight: bold;'>روش</th>
        <th style='text-align: left; padding: 8px; font-weight: bold;'>مزایا</th>
        <th style='text-align: left; padding: 8px; font-weight: bold;'>معایب</th>
    </tr>
    <tr>
        <td style='padding: 8px;'><strong>git shortlog</strong></td>
        <td style='padding: 8px;'>خلاصه‌ای از تاریخچه commit‌ها بر اساس نویسنده ارائه می‌دهد و نمای کلی از مشارکت‌ها را به دست می‌دهد.</td>
        <td style='padding: 8px;'>جزئیات commit‌ها، مانند پیام‌های commit یا تغییرات (diff) را نشان نمی‌دهد.</td>
    </tr>
    <tr style='background-color: #f9f9f9;'>
        <td style='padding: 8px;'><strong>git log</strong></td>
        <td style='padding: 8px;'>تاریخچه کامل commit‌ها را نمایش می‌دهد که شامل پیام‌های commit و diffs است.</td>
        <td style='padding: 8px;'>ممکن است در صورت تعداد زیاد commit‌ها، خروجی شلوغ و پیچیده شود.</td>
    </tr>
    <tr>
        <td style='padding: 8px;'><strong>git blame</strong></td>
        <td style='padding: 8px;'>اطلاعات دقیق خط به خط در مورد اینکه چه کسی تغییرات خاصی را انجام داده است را نشان می‌دهد.</td>
        <td style='padding: 8px;'>خیلی جزئی است و تاریخچه کامل commit‌ها را نمی‌دهد.</td>
    </tr>
</table>
";

    public List<GitField> Fields { get; set; } = new List<GitField>
    {
        new GitField { Name="Since", LabelEn="Since Date (--since)", LabelFa="از تاریخ (--since)", Type="text", PlaceholderEn="2021-01-01", PlaceholderFa="2021-01-01" },
        new GitField { Name="Email", LabelEn="Show Emails (-e)", LabelFa="نمایش ایمیل‌ها (-e)", Type="checkbox" },
        new GitField { Name="NumberSort", LabelEn="Sort by Number of Commits (-n)", LabelFa="مرتب‌سازی بر اساس تعداد commit‌ها (-n)", Type="checkbox" }
    };
}
