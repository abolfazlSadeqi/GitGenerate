namespace Core
{
    public class MvCommandModel
    {
        public string TitleEn => "Git Move";
        public string TitleFa => "جابجایی و تغییر نام فایل‌ها";

        public string GuideHtmlEn => @"
<h3>Usage</h3>
<pre>git mv <source> <destination></pre>
<h4>Examples</h4>
<pre>
git mv file1.txt newfile.txt     # Rename a file
git mv file1.txt directory/      # Move file to a directory
git mv file1.txt file2.txt      # Rename and move a file
</pre>
<h4>Limitations</h4>
<ul>
<li>Cannot rename files that are not tracked by Git</li>
<li>Moving or renaming files will be staged for commit</li>
</ul>
<h4>What does Git Move do?</h4>
<p>The <strong>git mv</strong> command is used to move or rename files within a Git repository. It stages the changes for commit, meaning the changes are immediately tracked by Git.</p>

<h4>Common Use Cases</h4>
<ul>
    <li>Renaming a file to correct a mistake or to better reflect its content.</li>
    <li>Moving a file from one directory to another as part of reorganizing the project.</li>
    <li>Renaming a file and moving it to a new location in one step.</li>
</ul>

<h4>Comparison with Other Git Commands</h4>
<table border='1' cellpadding='10'>
    <tr>
        <th>Feature</th>
        <th>git mv</th>
        <th>git rm</th>
    </tr>
    <tr>
        <td><strong>Purpose</strong></td>
        <td>Renames or moves a file within the Git repository.</td>
        <td>Removes a file from the Git repository.</td>
    </tr>
    <tr>
        <td><strong>Effect</strong></td>
        <td>Moves/renames the file and stages the changes for commit.</td>
        <td>Stages the removal of a file for commit.</td>
    </tr>
    <tr>
        <td><strong>Files</strong></td>
        <td>Moves or renames files that are already tracked by Git.</td>
        <td>Removes files from the Git index and working directory.</td>
    </tr>
</table>

<h4>In Simple Terms</h4>
<p>Think of <strong>git mv</strong> as a tool to quickly move or rename files in your Git project. Unlike manually renaming or moving files, using <strong>git mv</strong> tells Git about the changes immediately and stages them for the next commit.</p>

<h4>Common Mistakes</h4>
<ul>
    <li>Trying to move or rename files that are not tracked by Git (e.g., untracked files).</li>
    <li>Forgetting to commit the changes after using git mv, which could result in missing changes when pushing to a remote repository.</li>
    <li>Using <strong>-f</strong> (force) when it's not needed, which can potentially overwrite existing files without warning.</li>
</ul>

<h2>Best Practices</h2>
<ul>
    <li>Use git mv for all file renaming or moving tasks to ensure Git tracks the changes correctly.</li>
    <li>Before using the <strong>-f</strong> option, double-check if the destination already contains a file to avoid accidental overwrites.</li>
    <li>Always commit the changes after using git mv to ensure they are saved in your project history.</li>
</ul>

<h2>Limitations</h2>
<ul>
    <li>Git mv only works on files that are already tracked by Git. You cannot move or rename untracked files.</li>
    <li>If you move a file outside the repository, Git will lose track of it.</li>
</ul>

<h3>How to Use</h3>
<p>To move or rename a file with Git, use <pre>git mv <source> <destination></pre>. If the destination already exists, you can force the move with the <strong>-f</strong> option. Use <strong>-n</strong> for a dry run to see what will happen before applying changes.</p>

<h2>Overview</h2>
<p>Git move is an essential tool for managing files in a Git repository, allowing you to quickly and safely move or rename files while keeping Git aware of the changes.</p>

<h4>Options</h4>
<ul>
    <li>-f : Force the move even if the destination already exists.</li>
    <li>-n : Show what would happen without actually moving the files.</li>
</ul>";

        public string GuideHtmlFa => @"
<h3>استفاده</h3>
<pre>git mv <منبع> <مقصد></pre>

<h4>مثال‌ها</h4>
<pre>
git mv file1.txt newfile.txt     # تغییر نام یک فایل
git mv file1.txt directory/      # جابجایی فایل به دایرکتوری
git mv file1.txt file2.txt      # تغییر نام و جابجایی فایل
</pre>

<h4>محدودیت‌ها</h4>
<ul>
<li>فایل‌هایی که تحت گیت نیستند نمی‌توانند تغییر نام دهند</li>
<li>جابجایی یا تغییر نام فایل‌ها برای کامیت آماده می‌شود</li>
</ul>

<h4>دقیقاً چه می‌کند؟</h4>
<p>دستور <strong>git mv</strong> برای جابجا یا تغییر نام فایل‌ها در یک مخزن گیت استفاده می‌شود. این دستور تغییرات را برای کامیت آماده می‌کند، به این معنی که تغییرات بلافاصله توسط گیت پیگیری می‌شوند.</p>

<h4>موارد کاربرد رایج</h4>
<ul>
    <li>تغییر نام فایل‌ها برای اصلاح اشتباهات یا بهتر نشان دادن محتوا.</li>
    <li>جابجایی فایل‌ها از یک دایرکتوری به دایرکتوری دیگر به عنوان بخشی از بازآرایی پروژه.</li>
    <li>تغییر نام و جابجایی یک فایل به مکان جدید در یک مرحله.</li>
</ul>

<h4>مقایسه با دستورات دیگر گیت</h4>
<table border='1' cellpadding='10'>
    <tr>
        <th>ویژگی</th>
        <th>git mv</th>
        <th>git rm</th>
    </tr>
    <tr>
        <td><strong>هدف</strong></td>
        <td>تغییر نام یا جابجایی یک فایل در مخزن گیت.</td>
        <td>حذف یک فایل از مخزن گیت.</td>
    </tr>
    <tr>
        <td><strong>اثر</strong></td>
        <td>جابجایی یا تغییر نام فایل و آماده‌سازی تغییرات برای کامیت.</td>
        <td>آماده‌سازی حذف فایل برای کامیت.</td>
    </tr>
    <tr>
        <td><strong>فایل‌ها</strong></td>
        <td>جابجایی یا تغییر نام فایل‌هایی که توسط گیت پیگیری می‌شوند.</td>
        <td>حذف فایل‌ها از ایندکس و دایرکتوری کاری گیت.</td>
    </tr>
</table>

<h4>به زبان ساده</h4>
<p>دستور <strong>git mv</strong> ابزاری است برای جابجایی یا تغییر نام سریع فایل‌ها در پروژه گیت شما. برخلاف جابجایی یا تغییر نام فایل‌ها به صورت دستی، استفاده از <strong>git mv</strong> به گیت اطلاع می‌دهد که تغییرات به‌طور فوری پیگیری شوند و برای کامیت آماده باشند.</p>

<h4>اشتباهات رایج</h4>
<ul>
    <li>سعی در جابجا یا تغییر نام فایل‌هایی که تحت گیت نیستند (مثل فایل‌های بدون پیگیری).</li>
    <li>فراموش کردن کامیت کردن تغییرات پس از استفاده از git mv که باعث می‌شود تغییرات در زمان ارسال به ریموت نادیده گرفته شوند.</li>
    <li>استفاده از <strong>-f</strong> (اجباری) زمانی که نیازی به آن نیست، که می‌تواند منجر به بازنویسی فایل‌های موجود بدون هشدار شود.</li>
</ul>

<h2>بهترین شیوه‌ها</h2>
<ul>
    <li>برای تمامی وظایف تغییر نام یا جابجایی فایل، از git mv استفاده کنید تا اطمینان حاصل کنید که گیت تغییرات را به درستی پیگیری کند.</li>
    <li>قبل از استفاده از گزینه <strong>-f</strong>، حتماً بررسی کنید که مقصد فایل موجود است تا از بازنویسی تصادفی جلوگیری کنید.</li>
    <li>همیشه پس از استفاده از git mv تغییرات را کامیت کنید تا مطمئن شوید که در تاریخچه پروژه شما ذخیره می‌شوند.</li>
</ul>

<h2>محدودیت‌ها</h2>
<ul>
    <li>دستور git mv فقط بر روی فایل‌هایی که قبلاً تحت گیت هستند، کار می‌کند. نمی‌توانید فایل‌های بدون پیگیری را جابجا یا تغییر نام دهید.</li>
    <li>اگر فایل را خارج از مخزن جابجا کنید، گیت دیگر نمی‌تواند آن را پیگیری کند.</li>
</ul>

<h3>نحوه استفاده</h3>
<p>برای جابجایی یا تغییر نام یک فایل با گیت، از دستور <pre>git mv <منبع> <مقصد></pre> استفاده کنید. اگر مقصد قبلاً وجود دارد، می‌توانید از گزینه <strong>-f</strong> برای اجباری کردن جابجایی استفاده کنید. برای مشاهده پیش‌نمایش تغییرات قبل از اعمال آن‌ها، از <strong>-n</strong> برای شبیه‌سازی استفاده کنید.</p>

<h2>نمای کلی</h2>
<p>دستور git mv ابزاری ضروری برای مدیریت فایل‌ها در مخزن گیت است و به شما این امکان را می‌دهد که به‌سرعت و ایمن فایل‌ها را جابجا یا تغییر نام دهید و گیت از تغییرات آگاه باشد.</p>

<h4>گزینه‌ها</h4>
<ul>
    <li>-f : اجباری برای جابجایی حتی اگر مقصد موجود باشد.</li>
    <li>-n : نمایش آنچه که اتفاق خواهد افتاد بدون انجام جابجایی واقعی.</li>
</ul>";

        public List<GitField> Fields { get; set; } = new List<GitField>
        {
            new GitField { Name="Source", LabelEn="Source File", LabelFa="فایل مبدا", Type="text", PlaceholderEn="file1.txt", PlaceholderFa="فایل مبدا", IsRequired=true },
            new GitField { Name="Destination", LabelEn="Destination File/Directory", LabelFa="فایل/دایرکتوری مقصد", Type="text", PlaceholderEn="newfile.txt", PlaceholderFa="فایل/دایرکتوری مقصد", IsRequired=true },
            new GitField { Name="Force", LabelEn="Force (-f)", LabelFa="اجباری (-f)", Type="checkbox" },
            new GitField { Name="DryRun", LabelEn="Dry Run (-n)", LabelFa="شبیه‌سازی (-n)", Type="checkbox" }
        };
    }
}
