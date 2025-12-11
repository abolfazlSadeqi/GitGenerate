namespace Core;

public class CheckoutCommandModel
{
    public string TitleEn => "Checkout Branch/Commit";
    public string TitleFa => "تغییر شاخه یا کامیت";

    public string GuideHtmlEn => @"
<h3>Usage</h3>
<pre>git checkout [options] &lt;branch|commit&gt;</pre>

<h4>Examples</h4>
<pre>
git checkout develop               # Switch to branch 'develop'
git checkout -b feature            # Create and switch to new branch 'feature'
git checkout --track origin/feature # Track remote branch
git checkout HEAD~2 file.txt        # Restore a specific file from previous commit
git checkout -- file.txt            # Discard changes in working directory
</pre>

<h4>What does it do?</h4>
<p>The <code>git checkout</code> command allows you to switch between branches or restore working directory files to specific commits. It’s essential for managing different versions of your project, whether you’re switching tasks, fixing bugs, or experimenting with new features.</p>

<h4>Common Use Cases</h4>
<ul>
  <li>Switching between branches in your local repository</li>
  <li>Creating a new branch from the current branch and switching to it immediately</li>
  <li>Tracking remote branches</li>
  <li>Restoring specific files from a previous commit</li>
  <li>Discarding local changes and resetting files in the working directory</li>
</ul>

<h4>Limitations</h4>
<ul>
  <li>Cannot switch branches with uncommitted changes that conflict</li>
  <li>Detached HEAD state occurs when checking out a commit instead of a branch</li>
  <li>Files checked out will overwrite local changes unless staged</li>
</ul>

<h4>Comparison with git branch</h4>
<p>Here’s a comparison of <code>git checkout</code> and <code>git branch</code>:</p>
<table class='table table-striped'>
  <thead>
    <tr>
      <th>Feature</th>
      <th>git checkout</th>
      <th>git branch</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <td>Switching branches</td>
      <td>Yes, you can switch to an existing branch.</td>
      <td>No, you cannot switch branches.</td>
    </tr>
    <tr>
      <td>Creating a new branch</td>
      <td>Yes, with the <code>-b</code> flag, you can create a new branch and switch to it.</td>
      <td>Yes, but <code>git branch</code> only creates the branch without switching to it.</td>
    </tr>
    <tr>
      <td>Tracking a remote branch</td>
      <td>Yes, you can track a remote branch using the <code>--track</code> flag.</td>
      <td>No, you cannot track a remote branch.</td>
    </tr>
    <tr>
      <td>Restoring files from a commit</td>
      <td>Yes, you can restore files using <code>git checkout HEAD~2 file.txt</code>.</td>
      <td>No, you cannot restore files directly.</td>
    </tr>
    <tr>
      <td>Creating orphan branches</td>
      <td>Yes, with the <code>--orphan</code> flag.</td>
      <td>No, you cannot create orphan branches.</td>
    </tr>
  </tbody>
</table>

<h4>Best Practices</h4>
<ul>
  <li>Always commit or stash your changes before switching branches to avoid losing work.</li>
  <li>Use <code>git checkout -b <branch_name></code> to create and immediately switch to a new branch, which helps you avoid unnecessary steps.</li>
  <li>If you are in a detached HEAD state, be careful when making changes as they won’t be linked to any branch unless you explicitly create a new branch.</li>
  <li>For complex merges, use <code>git merge</code> instead of trying to use <code>git checkout --merge</code> to avoid potential conflicts.</li>
</ul>

<h4>Common Mistakes</h4>
<ul>
  <li>Forgetting to commit or stash changes before using <code>git checkout</code>, leading to errors or data loss.</li>
  <li>Switching to a commit (detached HEAD) without creating a new branch, which can lead to confusion or loss of work if changes are made.</li>
  <li>Using <code>git checkout -- file.txt</code> without staging changes, which might overwrite important local modifications.</li>
</ul>

<h4>Limitations</h4>
<ul>
  <li>Cannot switch branches if there are uncommitted changes that conflict with the branch you're trying to switch to.</li>
  <li>Switching to a commit puts you in a detached HEAD state, which means you are not on any branch.</li>
  <li>Files restored using <code>git checkout -- file</code> can overwrite uncommitted changes in the working directory, so be cautious.</li>
</ul>

<h3>How to Use</h3>
<p>To use <code>git checkout</code>, specify the branch or commit you want to switch to. You can also use various options to control the behavior of the command. For example, use <code>-b</code> to create a new branch or <code>--track</code> to track a remote branch.</p>

<h2>Overview</h2>
<p>In summary, <code>git checkout</code> is one of the most used commands in Git. It allows you to manage branches and restore files, making it essential for daily version control tasks. Whether you're switching branches, creating new ones, or reverting changes, understanding how to use this command effectively can save you a lot of time and confusion in your workflow.</p>";

    public string GuideHtmlFa => @"
<h3>استفاده</h3>
<pre>git checkout [گزینه‌ها] &lt;شاخه|کامیت&gt;</pre>

<h4>مثال‌ها</h4>
<pre>
git checkout develop               # Switch to branch 'develop'
git checkout -b feature            # Create and switch to new branch 'feature'
git checkout --track origin/feature # Track remote branch
git checkout HEAD~2 file.txt        # Restore a specific file from previous commit
git checkout -- file.txt            # Discard changes in working directory
</pre>

<h4>دقیقا چه می‌کند؟</h4>
<p>دستور <code>git checkout</code> برای تغییر شاخه‌ها و بازیابی فایل‌ها از کامیت‌های مختلف استفاده می‌شود. این دستور شما را قادر می‌سازد که به راحتی بین نسخه‌های مختلف کد پروژه‌تان جابجا شوید یا تغییرات نادرست را بازگردانید.</p>

<h4>موارد کاربرد رایج</h4>
<ul>
  <li>تغییر بین شاخه‌ها برای انجام تغییرات در بخش‌های مختلف پروژه</li>
  <li>ایجاد شاخه‌های جدید و جابجایی به آنها</li>
  <li>پیگیری شاخه‌های remote</li>
  <li>بازیابی فایل‌ها از یک کامیت قبلی</li>
  <li>لغو تغییرات محلی در دایرکتوری کاری</li>
</ul>

<h4>مقایسه با git branch</h4>
<p>در اینجا مقایسه‌ای بین <code>git checkout</code> و <code>git branch</code> آورده شده است:</p>
<table class='table table-striped'>
  <thead>
    <tr>
      <th>ویژگی</th>
      <th>git checkout</th>
      <th>git branch</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <td>تغییر شاخه</td>
      <td>بله، می‌توانید به یک شاخه موجود جابجا شوید.</td>
      <td>خیر، نمی‌توانید شاخه را تغییر دهید.</td>
    </tr>
    <tr>
      <td>ایجاد شاخه جدید</td>
      <td>بله، با استفاده از <code>-b</code> می‌توانید شاخه جدیدی ایجاد کرده و به آن جابجا شوید.</td>
      <td>بله، اما <code>git branch</code> فقط شاخه جدید را ایجاد می‌کند و شما باید به صورت دستی به آن جابجا شوید.</td>
    </tr>
    <tr>
      <td>پیگیری شاخه remote</td>
      <td>بله، می‌توانید با استفاده از <code>--track</code> یک شاخه remote را پیگیری کنید.</td>
      <td>خیر، نمی‌توانید شاخه remote را پیگیری کنید.</td>
    </tr>
    <tr>
      <td>بازیابی فایل‌ها از کامیت</td>
      <td>بله، می‌توانید فایل‌ها را با استفاده از <code>git checkout HEAD~2 file.txt</code> بازیابی کنید.</td>
      <td>خیر، نمی‌توانید فایل‌ها را مستقیماً بازیابی کنید.</td>
    </tr>
    <tr>
      <td>ایجاد شاخه orphan</td>
      <td>بله، با استفاده از <code>--orphan</code> می‌توانید یک شاخه orphan ایجاد کنید.</td>
      <td>خیر، نمی‌توانید شاخه orphan ایجاد کنید.</td>
    </tr>
  </tbody>
</table>

<h4>بهترین شیوه‌ها</h4>
<ul>
  <li>قبل از تغییر شاخه‌ها، تغییرات خود را commit یا stash کنید تا از دست دادن داده‌ها جلوگیری شود.</li>
  <li>برای ایجاد و جابجایی به یک شاخه جدید از <code>git checkout -b <branch_name></code> استفاده کنید تا از گام‌های اضافی جلوگیری شود.</li>
  <li>اگر در حالت detached HEAD هستید، مراقب باشید که تغییرات ایجاد شده به هیچ شاخه‌ای مرتبط نخواهند بود مگر اینکه شاخه جدیدی ایجاد کنید.</li>
  <li>برای ادغام‌های پیچیده، از <code>git merge</code> استفاده کنید تا از تضادهای احتمالی جلوگیری کنید.</li>
</ul>

<h4>اشتباهات رایج</h4>
<ul>
  <li>فراموش کردن commit یا stash کردن تغییرات قبل از استفاده از <code>git checkout</code> که منجر به خطا یا از دست رفتن داده‌ها می‌شود.</li>
  <li>انتقال به یک کامیت (حالت detached HEAD) بدون ایجاد یک شاخه جدید که ممکن است باعث گیج شدن یا از دست دادن کار شود.</li>
  <li>استفاده از <code>git checkout -- file.txt</code> بدون staged کردن تغییرات که ممکن است تغییرات محلی مهم را بازنویسی کند.</li>
</ul>

<h4>محدودیت‌ها</h4>
<ul>
  <li>نمی‌توان شاخه‌ها را تغییر داد اگر تغییرات ذخیره‌نشده تضاد داشته باشند.</li>
  <li>انتقال به یک کامیت شما را در حالت detached HEAD قرار می‌دهد که به این معنی است که شما هیچ شاخه‌ای ندارید.</li>
  <li>فایل‌هایی که با <code>git checkout -- file</code> بازیابی می‌کنید، تغییرات محلی را بازنویسی خواهند کرد مگر اینکه staged شده باشند.</li>
</ul>

<h3>نحوه استفاده</h3>
<p>برای استفاده از <code>git checkout</code> کافی است شاخه یا کامیتی که می‌خواهید به آن منتقل شوید را وارد کنید. همچنین می‌توانید از گزینه‌های مختلف برای تنظیم نحوه عملکرد دستور استفاده کنید، مانند استفاده از <code>-b</code> برای ایجاد یک شاخه جدید یا <code>--track</code> برای پیگیری شاخه remote.</p>

<h2>نمای کلی</h2>
<p>در مجموع، <code>git checkout</code> یکی از پرکاربردترین دستورات در Git است. این دستور به شما این امکان را می‌دهد که شاخه‌ها را مدیریت کرده و فایل‌ها را بازیابی کنید، که در وظایف روزانه کنترل نسخه ضروری است. چه بخواهید شاخه‌ها را جابجا کنید، شاخه‌های جدید ایجاد کنید یا تغییرات را برگردانید، درک صحیح از این دستور می‌تواند در روند کاری شما زمان و سردرگمی زیادی را نجات دهد.</p>";

    public List<GitField> Fields { get; set; } = new List<GitField>
    {
        new GitField { Name="BranchOrCommit", LabelEn="Branch or Commit", LabelFa="شاخه یا کامیت", Type="text", PlaceholderEn="develop", PlaceholderFa="نام شاخه یا کامیت", IsRequired=true },
        new GitField { Name="NewBranch", LabelEn="Create New Branch (-b)", LabelFa="ایجاد شاخه جدید (-b)", Type="checkbox" },
        new GitField { Name="Track", LabelEn="Track Remote (--track)", LabelFa="پیگیری شاخه remote (--track)", Type="checkbox" },
        new GitField { Name="ResetBranch", LabelEn="Reset/Force Branch (-B)", LabelFa="بازنشانی/اجبار شاخه (-B)", Type="checkbox" },
        new GitField { Name="Detach", LabelEn="Detach (--detach)", LabelFa="Detached HEAD (--detach)", Type="checkbox" },
        new GitField { Name="Force", LabelEn="Force Checkout (-f/--force)", LabelFa="اجبار بررسی (-f/--force)", Type="checkbox" },
        new GitField { Name="Orphan", LabelEn="Orphan Branch (--orphan)", LabelFa="شاخه Orphan (--orphan)", Type="checkbox" },
        new GitField { Name="Merge", LabelEn="Merge Checkout (--merge)", LabelFa="ادغام بررسی (--merge)", Type="checkbox" },
        new GitField { Name="ConflictStyle", LabelEn="Conflict Style (--conflict)", LabelFa="سبک تضاد (--conflict)", Type="text", PlaceholderEn="merge", PlaceholderFa="merge" }
    };
}
