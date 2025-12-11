namespace Core;

public class ResetCommandModel
{
    public string TitleEn => "Reset Changes";
    public string TitleFa => "بازنشانی تغییرات";

    public string GuideHtmlEn => @"
<h3>Usage</h3>
<pre>git reset [options] [<commit>]</pre>

<h4>What is Git Reset?</h4>
<p>Git reset moves the current branch to a specified commit, optionally modifying the staging area (index) and working directory. It's commonly used to undo commits, unstage changes, or revert changes to a previous state.</p>

<h4>Common Use Cases</h4>
<ul>
    <li>Undo the last commit without losing the changes in the working directory.</li>
    <li>Unstage changes in the staging area.</li>
    <li>Discard uncommitted changes and reset the working directory and index to a specific commit.</li>
    <li>Fix mistakes from a merge commit by resetting to a point before the merge.</li>
</ul>

<h4>Examples</h4>
<pre>
# Reset staging area only (soft reset)
git reset --soft HEAD~1

# Reset staging and working directory (mixed reset, default)
git reset HEAD~1

# Reset everything including working directory (hard reset)
git reset --hard HEAD~1

# Unstage a specific file
git reset HEAD file.txt

# Reset to a specific commit by hash
git reset --hard abc1234
</pre>

<h4>What Does Git Reset Do?</h4>
<p>Git reset changes the current branch's history, either by moving the HEAD to a specific commit or untracking changes in the staging area. Depending on the options used, it can modify the working directory, the index (staging area), or both.</p>

<h4>Comparison with Git Merge</h4>
<p>While <strong>merge</strong> integrates another branch into the current branch, <strong>reset</strong> moves the current branch pointer, effectively undoing commits or changes. Merge preserves history; reset can rewrite it.</p>

<h4>Comparison Table: Reset vs. Merge</h4>
<table border='1' cellpadding='10'>
    <tr>
        <th>Feature</th>
        <th>Git Reset</th>
        <th>Git Merge</th>
    </tr>
    <tr>
        <td><strong>Purpose</strong></td>
        <td>Undo commits or changes by moving the HEAD pointer.</td>
        <td>Integrates changes from another branch into the current branch.</td>
    </tr>
    <tr>
        <td><strong>Impact on History</strong></td>
        <td>Can rewrite commit history (especially with <code>--hard</code> or <code>--soft</code>).</td>
        <td>Preserves commit history; no rewriting of history.</td>
    </tr>
    <tr>
        <td><strong>Changes Applied</strong></td>
        <td>Can reset changes in the working directory, staging area, or both.</td>
        <td>Integrates changes from a different branch into the current branch.</td>
    </tr>
    <tr>
        <td><strong>When to Use</strong></td>
        <td>When you want to undo, unstage, or discard changes.</td>
        <td>When you want to combine changes from multiple branches.</td>
    </tr>
    <tr>
        <td><strong>Reversibility</strong></td>
        <td>Can be permanent if using a hard reset, so use with caution.</td>
        <td>Merge commits can be reverted using <code>git revert</code>, but merging itself cannot be undone directly.</td>
    </tr>
</table>

<h4>In Simple Terms</h4>
<p>Git reset is like hitting an 'undo' button. It lets you roll back changes in your history, unstage files, or even delete uncommitted work. You can reset back to a specific commit to remove unwanted changes.</p>

<h4>Common Mistakes</h4>
<ul>
    <li>Using a <strong>hard reset</strong> without realizing it will permanently delete uncommitted changes.</li>
    <li>Forgetting that <strong>reset</strong> can rewrite history, which may affect shared repositories.</li>
    <li>Resetting merge commits without fully understanding the impact on the branch history.</li>
</ul>

<h2>Best Practices</h2>
<ul>
    <li>Always double-check the commit hash or ref before performing a reset to avoid losing important work.</li>
    <li>Consider using <strong>git reset --soft</strong> if you just need to unstage changes or go back one commit without affecting your working directory.</li>
    <li>Use <strong>git reset --hard</strong> only when you're certain you want to discard all changes.</li>
    <li>For a cleaner reset, use <strong>git reset --keep</strong> to avoid overwriting local changes.</li>
</ul>

<h2>Limitations</h2>
<ul>
    <li>Hard reset will discard uncommitted changes permanently.</li>
    <li>Cannot reset commits pushed to remote without force push.</li>
    <li>Soft reset does not modify the working directory, so it may leave changes in your files.</li>
    <li>Resetting merge commits can be complex and may lead to unexpected results if not handled carefully.</li>
</ul>

<h3>How to Use</h3>
<p>Git reset can be used with different options depending on whether you want to reset only the staging area, the working directory, or both. It can also be used to reset to a specific commit or unstage files that have been staged for commit.</p>

<h2>Overview</h2>
<p>Git reset is a powerful tool that helps you manage your commit history and working directory. Whether you're undoing commits, unstaging files, or fixing merge mistakes, reset is a versatile command that can help you correct errors or revert to previous states in your Git repository.</p>

<h4>Options</h4>
<ul>
    <li>--soft : Move HEAD only, keep index and working directory</li>
    <li>--mixed : Move HEAD and reset index (default)</li>
    <li>--hard : Move HEAD and reset index + working directory</li>
    <li>--keep : Reset only if it doesn’t overwrite local changes</li>
    <li>--merge : Reset with merge info preserved</li>
    <li>&lt;commit&gt; : Target commit to reset to</li>
    <li>&lt;file&gt; : Unstage specific file</li>
</ul>";

    public string GuideHtmlFa => @"
<h3>استفاده</h3>
<pre>git reset [گزینه‌ها] [<کامیت>]</pre>

<h4>Git Reset چیست؟</h4>
<p>Git reset شاخه فعلی را به یک commit مشخص منتقل می‌کند و می‌تواند index و working directory را تغییر دهد. معمولاً برای undo کردن کامیت‌ها، unstaging تغییرات یا بازگشت به یک وضعیت قبلی استفاده می‌شود.</p>

<h4>موارد کاربرد رایج</h4>
<ul>
    <li>بازگشت به آخرین commit بدون از دست دادن تغییرات در working directory.</li>
    <li>Unstage کردن تغییرات از staging area.</li>
    <li>حذف تغییرات uncommitted و بازنشانی working directory و index به یک commit مشخص.</li>
    <li>اصلاح اشتباهات ناشی از merge commit با بازنشانی به وضعیت قبل از merge.</li>
</ul>

<h4>مثال‌ها</h4>
<pre>
# Reset staging area only (soft reset)
git reset --soft HEAD~1

# Reset staging and working directory (mixed reset, default)
git reset HEAD~1

# Reset everything including working directory (hard reset)
git reset --hard HEAD~1

# Unstage a specific file
git reset HEAD file.txt

# Reset to a specific commit by hash
git reset --hard abc1234
</pre>

<h4>دقیقاً چه می‌کند؟</h4>
<p>Git reset تاریخچه شاخه فعلی را تغییر می‌دهد و اشاره HEAD را به commit خاصی منتقل می‌کند، یا تغییرات staging area را unstage می‌کند. بسته به گزینه‌های انتخابی، می‌تواند working directory، index یا هر دو را تغییر دهد.</p>

<h4>مقایسه با git merge</h4>
<p>در حالی که <strong>merge</strong> یک شاخه دیگر را به شاخه فعلی اضافه می‌کند، <strong>reset</strong> اشاره HEAD را جابه‌جا می‌کند و عملاً کامیت‌ها یا تغییرات را undo می‌کند. Merge تاریخچه را حفظ می‌کند؛ reset می‌تواند تاریخچه را بازنویسی کند.</p>

<h4>مقایسه: Reset در مقابل Merge</h4>
<table border='1' cellpadding='10'>
    <tr>
        <th>ویژگی</th>
        <th>Git Reset</th>
        <th>Git Merge</th>
    </tr>
    <tr>
        <td><strong>هدف</strong></td>
        <td>کامیت‌ها یا تغییرات را با جابه‌جایی اشاره HEAD undo می‌کند.</td>
        <td>تغییرات یک شاخه دیگر را به شاخه فعلی اضافه می‌کند.</td>
    </tr>
    <tr>
        <td><strong>تأثیر بر تاریخچه</strong></td>
        <td>می‌تواند تاریخچه کامیت‌ها را بازنویسی کند (به‌ویژه با <code>--hard</code> یا <code>--soft</code>).</td>
        <td>تاریخچه را حفظ می‌کند؛ تاریخچه بازنویسی نمی‌شود.</td>
    </tr>
    <tr>
        <td><strong>تغییرات اعمال‌شده</strong></td>
        <td>می‌تواند تغییرات در working directory، staging area، یا هر دو را تغییر دهد.</td>
        <td>تغییرات یک شاخه دیگر را به شاخه فعلی ادغام می‌کند.</td>
    </tr>
    <tr>
        <td><strong>چه زمانی استفاده شود</strong></td>
        <td>زمانی که بخواهید تغییرات را undo، unstaged کنید یا تغییرات را حذف کنید.</td>
        <td>زمانی که بخواهید تغییرات چندین شاخه را ترکیب کنید.</td>
    </tr>
    <tr>
        <td><strong>قابلیت برگشت</strong></td>
        <td>در صورتی که از hard reset استفاده شود، می‌تواند دائمی باشد، بنابراین باید با دقت استفاده شود.</td>
        <td>کامیت‌های merge را می‌توان با استفاده از <code>git revert</code> برگرداند، اما خود merge را نمی‌توان به‌طور مستقیم undo کرد.</td>
    </tr>
</table>

<h4>به زبان ساده</h4>
<p>Git reset مانند دکمه 'لغو است. این ابزار به شما امکان می‌دهد تغییرات تاریخچه خود را برگشت دهید، فایل‌ها را unstage کنید یا حتی تغییرات uncommitted را حذف کنید. می‌توانید به یک commit خاص بازنشانی کنید تا تغییرات ناخواسته را حذف کنید.</p>

<h4>اشتباهات رایج</h4>
<ul>
    <li>استفاده از <strong>hard reset</strong> بدون درک اینکه این کار تغییرات uncommitted را به‌طور دائمی حذف می‌کند.</li>
    <li>فراموش کردن اینکه <strong>reset</strong> می‌تواند تاریخچه را بازنویسی کند، که ممکن است بر روی مخازن اشتراکی تاثیر بگذارد.</li>
    <li>Reset کردن merge commits بدون درک کامل تأثیر آن بر تاریخچه شاخه.</li>
</ul>

<h2>بهترین شیوه‌ها</h2>
<ul>
    <li>قبل از انجام reset، هاش یا مرجع commit را دوباره بررسی کنید تا از دست دادن کارهای مهم جلوگیری کنید.</li>
    <li>اگر فقط نیاز دارید تغییرات را unstaged کنید یا یک commit را به عقب برگردانید، از <strong>git reset --soft</strong> استفاده کنید.</li>
    <li>فقط زمانی از <strong>git reset --hard</strong> استفاده کنید که مطمئن باشید می‌خواهید تمام تغییرات را حذف کنید.</li>
    <li>برای یک reset تمیزتر، از <strong>git reset --keep</strong> استفاده کنید تا از بازنویسی تغییرات محلی جلوگیری کنید.</li>
</ul>

<h2>محدودیت‌ها</h2>
<ul>
    <li>Hard reset تغییرات uncommitted را به‌طور دائمی حذف می‌کند.</li>
    <li>کامیت‌های push شده به remote بدون force push قابل reset نیستند.</li>
    <li>Soft reset هیچ تغییری در working directory ایجاد نمی‌کند، بنابراین ممکن است تغییرات در فایل‌ها باقی بمانند.</li>
    <li>Reset کردن merge commits می‌تواند پیچیده باشد و ممکن است منجر به نتایج غیرمنتظره شود اگر به درستی مدیریت نشود.</li>
</ul>

<h3>نحوه استفاده</h3>
<p>Git reset می‌تواند با گزینه‌های مختلفی استفاده شود، بسته به اینکه آیا فقط staging area، working directory یا هر دو را می‌خواهید reset کنید. همچنین می‌توانید برای unstage کردن فایل‌ها یا بازگشت به یک commit خاص از آن استفاده کنید.</p>

<h2>نمای کلی</h2>
<p>Git reset یک ابزار قدرتمند است که به شما کمک می‌کند تاریخچه commit‌ها و working directory خود را مدیریت کنید. چه بخواهید commit‌ها را بازگردانید، فایل‌ها را unstaged کنید یا اشتباهات merge را اصلاح کنید، reset ابزاری انعطاف‌پذیر است که می‌تواند به شما در اصلاح خطاها یا بازگشت به وضعیت‌های قبلی کمک کند.</p>

<h4>گزینه‌ها</h4>
<ul>
    <li>--soft : فقط HEAD را منتقل می‌کند، index و working directory حفظ می‌شوند</li>
    <li>--mixed : HEAD را منتقل و index را بازنشانی می‌کند (پیش‌فرض)</li>
    <li>--hard : HEAD را منتقل و index + working directory را بازنشانی می‌کند</li>
    <li>--keep : فقط در صورتی reset می‌کند که تغییرات محلی overwrite نشوند</li>
    <li>--merge : reset با حفظ اطلاعات merge</li>
    <li>&lt;commit&gt; : کامیت هدف برای reset</li>
    <li>&lt;file&gt; : unstage فایل مشخص</li>
</ul>";

    public List<GitField> Fields { get; set; } = new List<GitField>
    {
        new GitField{ Name="Commit", LabelEn="Commit Hash/Ref", LabelFa="هاش یا مرجع کامیت", Type="text", PlaceholderEn="HEAD~1", PlaceholderFa="HEAD~1" },
        new GitField{ Name="Mode", LabelEn="Reset Mode", LabelFa="حالت Reset", Type="select", Options=new List<GitOption>
            {
                new GitOption{ Value="soft", TextEn="Soft", TextFa="Soft" },
                new GitOption{ Value="mixed", TextEn="Mixed", TextFa="Mixed" },
                new GitOption{ Value="hard", TextEn="Hard", TextFa="Hard" },
                new GitOption{ Value="keep", TextEn="Keep", TextFa="Keep" },
                new GitOption{ Value="merge", TextEn="Merge", TextFa="Merge" }
            }
        },
        new GitField{ Name="File", LabelEn="Specific File", LabelFa="فایل مشخص برای Unstage", Type="text", PlaceholderEn="file.txt", PlaceholderFa="file.txt" }
    };
}
