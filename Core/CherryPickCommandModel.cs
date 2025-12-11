namespace Core;

public class CherryPickCommandModel
{
    public string TitleEn => "Cherry Pick";
    public string TitleFa => "چری پیک";

    public string GuideHtmlEn => @"
<h3>Usage</h3>
<pre>git cherry-pick <commit-hash></pre>

<h4>Examples</h4>
<pre>
git cherry-pick abc123       # Apply commit abc123 to the current branch
git cherry-pick --no-commit abc123  # Apply commit but don't commit
git cherry-pick --edit abc123  # Apply commit and edit the commit message
git cherry-pick --strategy=recursive abc123  # Use a specific merge strategy
</pre>

<h4>What It Does?</h4>
<p>The <strong>git cherry-pick</strong> command allows you to apply a commit from one branch to another. It helps when you want to apply changes from a specific commit to your current branch, without merging the entire branch. This can be useful when you need to bring in bug fixes or specific features without integrating everything from the source branch.</p>

<h4>Common Use Cases</h4>
<ul>
    <li>Bringing in a specific bug fix from one branch to another.</li>
    <li>Applying specific commits from a feature branch to the master or development branch.</li>
    <li>Extracting changes from another branch without merging the entire history.</li>
</ul>

<h4>Best Practices</h4>
<ul>
    <li>Use <strong>--no-commit</strong> if you want to review the changes before committing them.</li>
    <li>If you are working with multiple merge conflicts, use <strong>--strategy</strong> to specify a merge strategy (e.g., <strong>recursive</strong> or <strong>ours</strong>) to handle conflicts in a more controlled way.</li>
    <li>Use <strong>--edit</strong> if you need to modify the commit message before applying the commit.</li>
    <li>Always make sure to check for conflicts after using <strong>git cherry-pick</strong>, as the changes from the selected commit may not be directly compatible with the current branch.</li>
</ul>

<h4>Limitations</h4>
<ul>
    <li>If conflicts arise during the cherry-pick, you will need to resolve them manually before continuing.</li>
    <li>Cherry-picking multiple commits can sometimes lead to issues with commit history, making it harder to track changes accurately.</li>
    <li>It doesn't always guarantee a clean history, as it only brings in individual commits and doesn't respect the context of the whole branch.</li>
</ul>

<h4>Common Mistakes</h4>
<ul>
    <li>Not resolving merge conflicts properly when they arise during cherry-picking.</li>
    <li>Using <strong>git cherry-pick</strong> for large feature integration, where a full merge or rebase would be more appropriate.</li>
    <li>Forgetting to use <strong>--no-commit</strong> when you want to review the changes before committing them.</li>
</ul>

<h2>Overview</h2>
<p>Cherry-picking allows you to apply specific commits from one branch to another. It is a powerful tool when you want to apply isolated changes like bug fixes or features from a different branch, without merging the entire branch. However, it should be used cautiously, as it can lead to complications in the commit history if used improperly.</p>

<h2>Comparison with Other Methods</h2>
<table border='1' cellpadding='10' cellspacing='0' style='border-collapse: collapse; width: 100%;'>
    <tr style='background-color: #f2f2f2;'>
        <th style='text-align: left; padding: 8px; font-weight: bold;'>Method</th>
        <th style='text-align: left; padding: 8px; font-weight: bold;'>Advantages</th>
        <th style='text-align: left; padding: 8px; font-weight: bold;'>Disadvantages</th>
    </tr>
    <tr>
        <td style='padding: 8px;'><strong>git cherry-pick</strong></td>
        <td style='padding: 8px;'>Apply specific commits from one branch to another without merging the entire branch.</td>
        <td style='padding: 8px;'>Can lead to a messy commit history and conflicts if used excessively.</td>
    </tr>
    <tr style='background-color: #f9f9f9;'>
        <td style='padding: 8px;'><strong>git merge</strong></td>
        <td style='padding: 8px;'>Combines the entire history of two branches and preserves context.</td>
        <td style='padding: 8px;'>Can result in large, less specific commits and potentially unnecessary changes.</td>
    </tr>
    <tr>
        <td style='padding: 8px;'><strong>git rebase</strong></td>
        <td style='padding: 8px;'>Integrates changes from one branch into another, keeping history linear.</td>
        <td style='padding: 8px;'>Can rewrite commit history, which may cause issues if not done carefully.</td>
    </tr>
</table>
";

    public string GuideHtmlFa => @"
<h3>استفاده</h3>
<pre>git cherry-pick <commit-hash></pre>

<h4>مثال‌ها</h4>
<pre>
git cherry-pick abc123       # Apply commit abc123 to the current branch
git cherry-pick --no-commit abc123  # Apply commit but don't commit
git cherry-pick --edit abc123  # Apply commit and edit the commit message
git cherry-pick --strategy=recursive abc123  # Use a specific merge strategy
</pre>

<h4>دقیقاً چه می‌کند؟</h4>
<p>دستور <strong>git cherry-pick</strong> به شما این امکان را می‌دهد که یک commit خاص را از یک شاخه به شاخه دیگر منتقل کنید. این دستور زمانی مفید است که بخواهید تغییرات یک commit خاص را بدون ادغام تمام تاریخچه آن شاخه به شاخه دیگر اعمال کنید.</p>

<h4>موارد کاربرد رایج</h4>
<ul>
    <li>انتقال یک اصلاح باگ خاص از یک شاخه به شاخه دیگر.</li>
    <li>اعمال commit های خاص از یک شاخه ویژگی به شاخه اصلی یا توسعه.</li>
    <li>استخراج تغییرات از یک شاخه بدون ادغام تمام تاریخچه آن شاخه.</li>
</ul>

<h4>بهترین شیوه‌ها</h4>
<ul>
    <li>از <strong>--no-commit</strong> استفاده کنید اگر می‌خواهید تغییرات را قبل از commit مشاهده کنید.</li>
    <li>اگر با تعارضات زیادی مواجه هستید، از <strong>--strategy</strong> برای انتخاب استراتژی مرج خاص (مثل <strong>recursive</strong> یا <strong>ours</strong>) استفاده کنید.</li>
    <li>اگر نیاز به ویرایش پیام commit دارید، از <strong>--edit</strong> استفاده کنید.</li>
    <li>همیشه بعد از استفاده از <strong>git cherry-pick</strong> تعارض‌ها را بررسی کنید، زیرا تغییرات از commit انتخاب شده ممکن است با شاخه جاری سازگار نباشند.</li>
</ul>

<h4>محدودیت‌ها</h4>
<ul>
    <li>اگر تعارضاتی در هنگام چری پیک به وجود آید، باید آن‌ها را به صورت دستی حل کنید.</li>
    <li>چری پیک کردن چندین commit ممکن است مشکلاتی در تاریخچه commit ایجاد کند و پیگیری تغییرات را دشوارتر کند.</li>
    <li>این دستور همیشه تاریخچه پاکی ایجاد نمی‌کند زیرا تنها commit های فردی را وارد می‌کند و از تمام تاریخچه شاخه مبدأ بی‌توجه است.</li>
</ul>

<h4>اشتباهات رایج</h4>
<ul>
    <li>حل نکردن درست تعارضات مرج در هنگام چری پیک.</li>
    <li>استفاده از <strong>git cherry-pick</strong> برای ادغام ویژگی‌های بزرگ، در حالی که برای این کار روش‌های دیگری مثل مرج یا ری‌بیس مناسب‌تر هستند.</li>
    <li>فراموش کردن استفاده از <strong>--no-commit</strong> وقتی که می‌خواهید تغییرات را قبل از commit بررسی کنید.</li>
</ul>

<h2>نمای کلی</h2>
<p>دستور <strong>git cherry-pick</strong> به شما این امکان را می‌دهد که commit های خاص را از یک شاخه به شاخه دیگر منتقل کنید. این ابزار زمانی مفید است که بخواهید تغییرات مشخصی مانند اصلاحات باگ یا ویژگی‌ها را بدون ادغام تمام تاریخچه شاخه اعمال کنید. با این حال، باید با دقت از آن استفاده کنید زیرا می‌تواند باعث ایجاد مشکلاتی در تاریخچه commit ها شود.</p>

<h2>مقایسه با روش‌های دیگر</h2>
<table border='1' cellpadding='10' cellspacing='0' style='border-collapse: collapse; width: 100%;'>
    <tr style='background-color: #f2f2f2;'>
        <th style='text-align: left; padding: 8px; font-weight: bold;'>روش</th>
        <th style='text-align: left; padding: 8px; font-weight: bold;'>مزایا</th>
        <th style='text-align: left; padding: 8px; font-weight: bold;'>معایب</th>
    </tr>
    <tr>
        <td style='padding: 8px;'><strong>git cherry-pick</strong></td>
        <td style='padding: 8px;'>امکان انتقال commit های خاص از یک شاخه به شاخه دیگر بدون ادغام تمام تاریخچه شاخه.</td>
        <td style='padding: 8px;'>ممکن است تاریخچه commit ها به هم بریزد و تعارضات به وجود آید.</td>
    </tr>
    <tr style='background-color: #f9f9f9;'>
        <td style='padding: 8px;'><strong>git merge</strong></td>
        <td style='padding: 8px;'>تمام تاریخچه دو شاخه را با هم ترکیب می‌کند و ارتباط کامل بین آن‌ها حفظ می‌شود.</td>
        <td style='padding: 8px;'>ممکن است commit های غیرضروری هم به شاخه وارد شود.</td>
    </tr>
    <tr>
        <td style='padding: 8px;'><strong>git rebase</strong></td>
        <td style='padding: 8px;'>تغییرات یک شاخه را به شاخه دیگر می‌آورد و تاریخچه خطی حفظ می‌شود.</td>
        <td style='padding: 8px;'>ممکن است تاریخچه commit ها را تغییر دهد که در صورتی که به درستی استفاده نشود، می‌تواند مشکلاتی ایجاد کند.</td>
    </tr>
</table>
";



    public List<GitField> Fields { get; set; } = new List<GitField>
    {
        new GitField { Name="CommitHash", LabelEn="Commit Hash", LabelFa="هش کامیت", Type="text", PlaceholderEn="abc123", PlaceholderFa="مثال: abc123", IsRequired=true },
        new GitField { Name="NoCommit", LabelEn="No Commit (--no-commit)", LabelFa="بدون commit (--no-commit)", Type="checkbox" },
        new GitField { Name="Edit", LabelEn="Edit Commit Message (--edit)", LabelFa="ویرایش پیام commit (--edit)", Type="checkbox" },
        new GitField { Name="Strategy", LabelEn="Merge Strategy (--strategy)", LabelFa="استراتژی مرج (--strategy)", Type="text", PlaceholderEn="recursive", PlaceholderFa="recursive" },
        new GitField { Name="StrategyOption", LabelEn="Strategy Option (--strategy-option)", LabelFa="گزینه استراتژی (--strategy-option)", Type="text", PlaceholderEn="theirs", PlaceholderFa="theirs" }
    };
}
