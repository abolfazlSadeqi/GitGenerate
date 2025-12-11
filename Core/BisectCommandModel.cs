namespace Core;

public class BisectCommandModel
{
    public string TitleEn => "Use Git Bisect to Find the Commit that Broke Something";
    public string TitleFa => "استفاده از گیت بی‌سکت برای یافتن commit مشکل‌ساز";

    public string GuideHtmlEn => @"
<h3>Usage</h3>
<pre>git bisect [options] [start commit] [bad commit]</pre>

<h4>Examples</h4>
<pre>
git bisect start           # Start bisecting
git bisect bad <commit>    # Mark the bad commit
git bisect good <commit>   # Mark the good commit
git bisect reset           # Reset bisecting
</pre>

<h4>What It Does?</h4>
<p>The <strong>git bisect</strong> command is a powerful tool used to help you find the commit that introduced a bug. It performs a binary search through the commit history, allowing you to quickly pinpoint the commit that caused an issue in the code. By marking a commit as 'good' (where the bug did not exist) and a commit as 'bad' (where the bug is present), Git will start narrowing down the search and identify the exact commit that introduced the problem.</p>

<h4>Common Use Cases</h4>
<ul>
    <li>Locating the commit that introduced a bug in your project.</li>
    <li>Finding the exact change that caused a regression.</li>
    <li>Debugging issues in a large codebase by isolating problematic commits.</li>
</ul>

<h4>Best Practices</h4>
<ul>
    <li>Start by marking a commit as 'good' (a known working version) and another as 'bad' (where the issue appears).</li>
    <li>Use<strong> git bisect reset</strong> to undo the bisect operation after you've identified the faulty commit.</li>
    <li>Ensure that your tests or checks are working correctly during the bisecting process to validate each commit's state.</li>
</ul>

<h4>Limitations</h4>
<ul>
    <li>Requires you to have a known good commit to start the bisect process.</li>
    <li>Can be time-consuming if you have a large commit history and need to manually verify each state of the code.</li>
</ul>

<h4>Common Mistakes</h4>
<ul>
    <li>Marking a commit as 'good' or 'bad' incorrectly, which can lead to incorrect results.</li>
    <li>Forgetting to reset the bisect session after completing the search, leading to confusion in subsequent commands.</li>
</ul>

<h2>Overview</h2>
<p>Git bisect is an extremely useful tool when you need to isolate the commit that caused an issue in your code. By using binary search, it can significantly reduce the time it takes to find a bug.Once the faulty commit is found, you can take the necessary steps to fix the issue or investigate it further.</p>
";

    public string GuideHtmlFa => @"
<h3>استفاده</h3>
<pre>git bisect [گزینه‌ها] [شروع commit] [bad commit]</pre>

<h4>مثال‌ها</h4>
<pre>
git bisect start           # Start bisecting
git bisect bad <commit>    # Mark the bad commit
git bisect good <commit>   # Mark the good commit
git bisect reset           # Reset bisecting
</pre>

<h4>دقیقاً چه می‌کند؟</h4>
<p>دستور <strong>git bisect</strong> یک ابزار قدرتمند است که به شما کمک می‌کند commit‌ای که یک باگ را وارد کرده شناسایی کنید. این دستور یک جستجوی دودویی در تاریخچه commits انجام می‌دهد و به شما این امکان را می‌دهد که سریعاً commit مشکل‌ساز را شناسایی کنید. با علامت‌گذاری یک commit به عنوان 'خوب' (جایی که باگ وجود ندارد) و دیگری به عنوان گبدگ (جایی که باگ وجود دارد)، گیت شروع به جستجو می‌کند تا commit مشکل‌ساز را شناسایی کند.</p>

<h4>موارد کاربرد رایج</h4>
<ul>
    <li>شناسایی commit‌ای که یک باگ را در پروژه شما وارد کرده است.</li>
    <li>یافتن تغییرات دقیقاً باعث ایجاد یک بازگشت به وضعیت قبلی شده است.</li>
    <li>عیب‌یابی مشکلات در یک کدبیس بزرگ از طریق ایزوله کردن commits مشکل‌ساز.</li>
</ul>

<h4>بهترین شیوه‌ها</h4>
<ul>
    <li>ابتدا یک commit به عنوان 'خوب' (یک نسخه شناخته شده که بدون مشکل است) و یک commit به عنوان 'بد' (جایی که مشکل مشاهده می‌شود) علامت‌گذاری کنید.</li>
    <li>از دستور <strong>git bisect reset</strong> برای بازنشانی عملیات بی‌سکت پس از شناسایی commit مشکل‌ساز استفاده کنید.</li>
    <li>اطمینان حاصل کنید که آزمایش‌ها یا بررسی‌های شما در طول فرایند bisect به درستی کار می‌کنند تا وضعیت هر commit را تأیید کنید.</li>
</ul>

<h4>محدودیت‌ها</h4>
<ul>
    <li>نیاز به یک commit خوب برای شروع فرایند bisect دارید.</li>
    <li>اگر تاریخچه commits شما بزرگ باشد و باید وضعیت کد را به صورت دستی برای هر commit بررسی کنید، ممکن است زمان‌بر باشد.</li>
</ul>

<h4>اشتباهات رایج</h4>
<ul>
    <li>علامت‌گذاری اشتباه یک commit به عنوان 'خوب' یا 'بد'، که می‌تواند منجر به نتایج نادرست شود.</li>
    <li>فراموش کردن بازنشانی جلسه bisect پس از اتمام جستجو، که باعث سردرگمی در دستورات بعدی خواهد شد.</li>
</ul>

<h2>نمای کلی</h2>
<p>دستور<strong> git bisect</strong> یک ابزار بسیار مفید زمانی است که نیاز دارید commit‌ای که باعث ایجاد مشکل در کد شما شده است را ایزوله کنید.با استفاده از جستجوی دودویی، می‌تواند زمان لازم برای یافتن یک باگ را به طور چشمگیری کاهش دهد.پس از پیدا کردن commit مشکل‌ساز، می‌توانید اقدامات لازم برای اصلاح مشکل یا بررسی بیشتر آن را انجام دهید.</p>
";

    public List<GitField> Fields { get; set; } = new List<GitField>
    {
        new GitField { Name="Start", LabelEn="Start Bisecting", LabelFa="شروع Bisect", Type="checkbox" },
        new GitField { Name="Bad", LabelEn="Bad Commit", LabelFa="Commit خراب", Type="text", PlaceholderEn="bad_commit_hash", PlaceholderFa="commit خراب" },
        new GitField { Name="Good", LabelEn="Good Commit", LabelFa="Commit سالم", Type="text", PlaceholderEn="good_commit_hash", PlaceholderFa="commit سالم" },
        new GitField { Name="Reset", LabelEn="Reset Bisecting", LabelFa="بازنشانی Bisect", Type="checkbox" }
    };
}
