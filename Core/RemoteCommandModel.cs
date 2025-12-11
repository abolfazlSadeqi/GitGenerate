namespace Core
{
    public class RemoteCommandModel
    {
        public string TitleEn => "Manage Remote Repositories";
        public string TitleFa => "مدیریت مخازن ریموت";

        public string GuideHtmlEn => @"
<h3>Usage</h3>
<pre>git remote [options] <command> [<args>]</pre>

<h4>What is Git Remote?</h4>
<p>The <strong>git remote</strong> command is used to manage remote repositories in Git. You can add, remove, or modify the remotes associated with your local repository. Remotes are versions of your project hosted on the internet or other networks, and Git uses them to track and sync changes.</p>

<h4>Examples</h4>
<pre>
# Add a new remote repository
git remote add origin https://github.com/user/repo.git

# Remove an existing remote repository
git remote remove origin

# List all configured remotes with URLs
git remote -v

# Change the URL of an existing remote
git remote set-url origin https://github.com/user/another-repo.git
</pre>

<h4>Limitations</h4>
<ul>
<li>Must be executed from within a Git repository</li>
<li>Commands affect only the configuration of the local repository</li>
<li>Does not fetch or push changes to the remote repository; it only manages remote configurations</li>
</ul>

<h4>Options</h4>
<ul>
<li><strong>add <name> <url></strong>: Add a new remote repository</li>
<li><strong>remove <name></strong>: Remove an existing remote</li>
<li><strong>rename <old> <new></strong>: Rename a remote</li>
<li><strong>set-url <name> <url></strong>: Change the URL of an existing remote</li>
<li><strong>-v</strong>: Show the URLs of all remotes</li>
<li><strong>show <name></strong>: Show detailed information about a specific remote</li>
</ul>

<h4>Common Use Cases</h4>
<ul>
    <li>Setting up a new remote repository for a project</li>
    <li>Changing the URL of an existing remote repository (e.g., when switching between HTTPS and SSH URLs)</li>
    <li>Removing an old or unused remote repository</li>
    <li>Renaming a remote (for example, renaming `origin` to something else)</li>
</ul>

<h4>Best Practices</h4>
<ul>
    <li>Always use a meaningful name for your remotes, e.g., `origin` for your main remote and `upstream` for the original repository.</li>
    <li>Use `git remote -v` frequently to check which URLs are configured for your remotes.</li>
    <li>When changing a remote URL, ensure that the new URL points to the correct repository and is accessible.</li>
</ul>

<h4>Common Mistakes</h4>
<ul>
    <li>Forgetting to specify the name when adding a remote repository</li>
    <li>Using incorrect URLs (e.g., forgetting 'https://') when setting remote URLs</li>
    <li>Removing a remote that is still being used by other collaborators or scripts</li>
</ul>";

        public string GuideHtmlFa => @"
<h3>استفاده</h3>
<pre>git remote [گزینه‌ها] <دستور> [<آرگومان‌ها>]</pre>

<h4>Git Remote چیست؟</h4>
<p>دستور <strong>git remote</strong> برای مدیریت مخازن ریموت در گیت استفاده می‌شود. شما می‌توانید ریموت‌ها را اضافه، حذف یا تغییر دهید. ریموت‌ها نسخه‌هایی از پروژه شما هستند که بر روی اینترنت یا شبکه‌های دیگر میزبانی می‌شوند و گیت از آنها برای پیگیری و همگام‌سازی تغییرات استفاده می‌کند.</p>

<h4>مثال‌ها</h4>
<pre>
# Add a new remote repository
git remote add origin https://github.com/user/repo.git

# Remove an existing remote repository
git remote remove origin

# List all configured remotes with URLs
git remote -v

# Change the URL of an existing remote
git remote set-url origin https://github.com/user/another-repo.git
</pre>

<h4>محدودیت‌ها</h4>
<ul>
<li>این دستور باید از داخل یک مخزن گیت اجرا شود</li>
<li>دستورات فقط بر روی پیکربندی مخزن محلی تاثیر می‌گذارند</li>
<li>دستورهای <strong>git remote</strong> تغییراتی در مخزن ریموت ایجاد نمی‌کنند و فقط تنظیمات ریموت را مدیریت می‌کنند</li>
</ul>

<h4>گزینه‌ها</h4>
<ul>
<li><strong>add <name> <url></strong>: اضافه کردن یک مخزن ریموت جدید</li>
<li><strong>remove <name></strong>: حذف یک مخزن ریموت موجود</li>
<li><strong>rename <old> <new></strong>: تغییر نام یک ریموت</li>
<li><strong>set-url <name> <url></strong>: تغییر URL یک ریموت موجود</li>
<li><strong>-v</strong>: نمایش URLهای ریموت‌ها</li>
<li><strong>show <name></strong>: نمایش اطلاعات کامل یک ریموت</li>
</ul>

<h4>موارد کاربرد رایج</h4>
<ul>
    <li>راه‌اندازی یک مخزن ریموت جدید برای پروژه</li>
    <li>تغییر URL یک مخزن ریموت موجود (برای مثال، تغییر از HTTPS به SSH)</li>
    <li>حذف یک ریموت قدیمی یا غیرقابل استفاده</li>
    <li>تغییر نام یک ریموت (مثلاً تغییر نام `origin` به چیزی دیگر)</li>
</ul>

<h4>بهترین شیوه‌ها</h4>
<ul>
    <li>همیشه از نام‌های معنادار برای ریموت‌های خود استفاده کنید، مثلاً برای ریموت اصلی از `origin` و برای ریموت اصلی پروژه از `upstream` استفاده کنید.</li>
    <li>از دستور `git remote -v` به‌طور مرتب برای بررسی URLهای پیکربندی‌شده استفاده کنید.</li>
    <li>وقتی URL ریموت را تغییر می‌دهید، مطمئن شوید که URL جدید به مخزن صحیح اشاره می‌کند و قابل دسترسی است.</li>
</ul>

<h4>اشتباهات رایج</h4>
<ul>
    <li>فراموش کردن نام ریموت هنگام اضافه کردن یک ریموت جدید</li>
    <li>استفاده از URLهای نادرست (مثلاً فراموش کردن 'https://') هنگام تنظیم URL ریموت</li>
    <li>حذف ریموت‌هایی که هنوز توسط دیگر همکاران یا اسکریپت‌ها استفاده می‌شوند</li>
</ul>";

        public List<GitField> Fields { get; set; } = new List<GitField>
{
    new GitField
    {
        Name = "RemoteName",
        LabelEn = "Remote Name",
        LabelFa = "نام ریموت",
        Type = "text",
        PlaceholderEn = "origin",
        PlaceholderFa = "origin",
        IsRequired = true
    },
    new GitField
    {
        Name = "RemoteURL",
        LabelEn = "Remote URL",
        LabelFa = "URL ریموت",
        Type = "text",
        PlaceholderEn = "https://github.com/user/repo.git",
        PlaceholderFa = "https://github.com/user/repo.git"
    },
    new GitField
    {
        Name = "Command",
        LabelEn = "Command",
        LabelFa = "دستور",
        Type = "select",
        IsRequired = true,
        Options = new List<GitOption> // مقدار پیش‌فرض برای Options
        {
            new GitOption { Value = "add", TextEn = "Add", TextFa = "اضافه کردن" },
            new GitOption { Value = "remove", TextEn = "Remove", TextFa = "حذف کردن" },
            new GitOption { Value = "rename", TextEn = "Rename", TextFa = "تغییر نام" },
            new GitOption { Value = "set-url", TextEn = "Set URL", TextFa = "تنظیم URL" }
        }
    }
};


    }
}
