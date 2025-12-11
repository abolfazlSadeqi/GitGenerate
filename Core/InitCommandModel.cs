namespace Core
{
    public class InitCommandModel
    {
        public string TitleEn => "Git Init";
        public string TitleFa => "ایجاد مخزن گیت";

        public string GuideHtmlEn => @"
<h3>Usage</h3>
<pre>git init</pre>
<h4>Examples</h4>
<pre>
git init         # Initialize a new Git repository
git init --bare  # Initialize a bare repository
</pre>
<h4>Limitations</h4>
<ul>
<li>This command must be run in an empty directory to initialize a new repository.</li>
<li>For a bare repository, it should be used for shared or remote repositories.</li>
</ul>

<h4>What does Git Init do?</h4>
<p>The <strong>git init</strong> command is used to create a new Git repository in the current directory. It sets up the necessary Git configuration files and prepares the directory for version control.</p>

<h4>Common Use Cases</h4>
<ul>
    <li>Starting a new project by initializing a Git repository in an empty directory.</li>
    <li>Setting up a remote repository on a server to store and share project code (with the <strong>--bare</strong> option).</li>
</ul>

<h4>Comparison with Other Git Commands</h4>
<table border='1' cellpadding='10'>
    <tr>
        <th>Feature</th>
        <th>git init</th>
        <th>git clone</th>
    </tr>
    <tr>
        <td><strong>Purpose</strong></td>
        <td>Initializes a new repository in the current directory.</td>
        <td>Clones an existing repository from a remote source.</td>
    </tr>
    <tr>
        <td><strong>Usage</strong></td>
        <td>Used when starting a new project or repository.</td>
        <td>Used to create a local copy of an existing remote repository.</td>
    </tr>
    <tr>
        <td><strong>Initial State</strong></td>
        <td>Creates a new empty repository.</td>
        <td>Creates a copy of the repository including all history and branches.</td>
    </tr>
</table>

<h4>In Simple Terms</h4>
<p>Think of <strong>git init</strong> as the command that 'opens the door' to start tracking your project with Git. It turns your directory into a Git repository, allowing you to start committing changes and keeping track of your project's history.</p>

<h4>Common Mistakes</h4>
<ul>
    <li>Running<strong> git init</strong> in a directory that already contains files or is not empty, which may cause unexpected behavior.</li>
    <li>Using<strong>--bare</strong> without understanding that bare repositories are used for remote storage and do not have working directories.</li>
    <li>Forgetting to specify the <strong>--template</strong> option when you want to initialize a repository from a specific template.</li>
</ul>

<h2>Best Practices</h2>
<ul>
    <li>Always initialize Git repositories in an empty directory to avoid issues with pre-existing files.</li>
    <li>Use the <strong>--bare</strong> option only when creating a remote repository that will not have a working directory.</li>
    <li>If you're initializing a repository for a project, consider creating a <strong>README.md</strong> file before committing initial changes.</li>
</ul>

<h2>Limitations</h2>
<ul>
    <li>Git init does not create remote repositories.It only initializes the local repository.</li>
    <li>Running git init on an already existing project may require additional steps (like ignoring certain files) to ensure smooth functionality.</li>
</ul>

<h3>How to Use</h3>
<p>To initialize a new Git repository, simply run<pre> git init</pre> in an empty directory.If you're setting up a remote repository, use the <strong>--bare</strong> option to create a repository without a working directory.</p>

<h2>Overview</h2>
<p>The<strong> git init</strong> command is the first step in any new Git project.It allows you to start tracking your project with Git and manage changes, history, and collaboration with others.</p>

<h4>Options</h4>
<ul>
    <li>--bare : Initialize a bare repository, suitable for shared or remote repositories.</li>
    <li>--template=< directory > : Initialize the repository using a template directory.</li>
</ul>";

        public string GuideHtmlFa => @"
<h3>استفاده</h3>
<pre>git init</pre>

<h4>مثال‌ها</h4>
<pre>
git init         # ایجاد یک مخزن گیت جدید
git init --bare  # ایجاد یک مخزن bare
</pre>

<h4>محدودیت‌ها</h4>
<ul>
<li>این دستور باید در یک دایرکتوری خالی اجرا شود تا یک مخزن جدید گیت ایجاد کند.</li>
<li>برای مخزن bare، این دستور برای مخازن مشترک یا سرورهای گیت مناسب است.</li>
</ul>

<h4>دقیقاً چه می‌کند؟</h4>
<p>دستور <strong>git init</strong> برای ایجاد یک مخزن جدید گیت در دایرکتوری فعلی استفاده می‌شود. این دستور فایل‌های پیکربندی لازم گیت را تنظیم کرده و دایرکتوری را برای کنترل نسخه آماده می‌کند.</p>

<h4>موارد کاربرد رایج</h4>
<ul>
    <li>شروع یک پروژه جدید با استفاده از دستور git init در یک دایرکتوری خالی.</li>
    <li>راه‌اندازی مخزن ریموت بر روی سرور برای ذخیره و به اشتراک‌گذاری کد پروژه (با گزینه <strong>--bare</strong>).</li>
</ul>

<h4>مقایسه با دستورات دیگر گیت</h4>
<table border='1' cellpadding='10'>
    <tr>
        <th>ویژگی</th>
        <th>git init</th>
        <th>git clone</th>
    </tr>
    <tr>
        <td><strong>هدف</strong></td>
        <td>ایجاد یک مخزن جدید در دایرکتوری فعلی.</td>
        <td>کپی کردن یک مخزن موجود از یک منبع ریموت.</td>
    </tr>
    <tr>
        <td><strong>زمان استفاده</strong></td>
        <td>برای شروع یک پروژه یا مخزن جدید استفاده می‌شود.</td>
        <td>برای ایجاد یک کپی محلی از یک مخزن ریموت موجود استفاده می‌شود.</td>
    </tr>
    <tr>
        <td><strong>وضعیت اولیه</strong></td>
        <td>یک مخزن خالی جدید ایجاد می‌کند.</td>
        <td>یک کپی از مخزن با تمام تاریخچه و شاخه‌ها ایجاد می‌کند.</td>
    </tr>
</table>

<h4>به زبان ساده</h4>
<p>دستور <strong>git init</strong> مانند دستوری است که 'در را باز می‌کند' تا پروژه شما با گیت آغاز شود. این دستور دایرکتوری شما را به یک مخزن گیت تبدیل کرده و به شما اجازه می‌دهد تا تغییرات پروژه‌تان را پیگیری کرده و تاریخچه آن را نگهداری کنید.</p>

<h4>اشتباهات رایج</h4>
<ul>
    <li>اجرای<strong> git init</strong> در دایرکتوری که فایل‌هایی دارد یا خالی نیست، که ممکن است باعث رفتار غیرمنتظره شود.</li>
    <li>استفاده از <strong>--bare</strong> بدون درک این که مخزن‌های bare برای مخازن ریموت استفاده می‌شوند و دارای دایرکتوری کاری نیستند.</li>
    <li>فراموش کردن تعیین گزینه <strong>--template</strong> زمانی که می‌خواهید مخزن را از یک قالب خاص راه‌اندازی کنید.</li>
</ul>

<h2>بهترین شیوه‌ها</h2>
<ul>
    <li>همیشه مخزن‌های گیت را در دایرکتوری خالی راه‌اندازی کنید تا از مشکلات پیش‌آمده با فایل‌های موجود جلوگیری کنید.</li>
    <li>از گزینه <strong>--bare</strong> فقط زمانی استفاده کنید که می‌خواهید مخزن ریموتی بدون دایرکتوری کاری ایجاد کنید.</li>
    <li>اگر مخزن را برای یک پروژه راه‌اندازی می‌کنید، بهتر است پیش از commit کردن تغییرات اولیه، یک فایل <strong>README.md</strong> ایجاد کنید.</li>
</ul>

<h2>محدودیت‌ها</h2>
<ul>
    <li>دستور git init مخازن ریموت را ایجاد نمی‌کند. فقط مخزن محلی را راه‌اندازی می‌کند.</li>
    <li>اجرای git init در پروژه‌ای که قبلاً وجود دارد، ممکن است به مراحل اضافی نیاز داشته باشد (مثلاً نادیده گرفتن برخی فایل‌ها) تا عملکرد به طور صحیح انجام شود.</li>
</ul>

<h3>نحوه استفاده</h3>
<p>برای راه‌اندازی یک مخزن جدید گیت، کافی است دستور<pre> git init</pre> را در یک دایرکتوری خالی اجرا کنید. اگر می‌خواهید مخزن ریموت راه‌اندازی کنید، از گزینه <strong>--bare</strong> استفاده کنید تا مخزنی بدون دایرکتوری کاری ایجاد کنید.</p>

<h2>نمای کلی</h2>
<p>دستور<strong> git init</strong> اولین گام در هر پروژه گیت جدید است.این دستور به شما اجازه می‌دهد پروژه خود را تحت کنترل گیت قرار دهید و تغییرات، تاریخچه، و همکاری با دیگران را مدیریت کنید.</p>

<h4>گزینه‌ها</h4>
<ul>
    <li>--bare : ایجاد مخزن bare، مناسب برای مخازن ریموت یا مشترک.</li>
    <li>--template=< directory > : استفاده از دایرکتوری قالب برای ایجاد مخزن.</li>
</ul>";


        public List<GitField> Fields { get; set; } = new List<GitField>
        {
            new GitField { Name="Bare", LabelEn="Bare Repository", LabelFa="مخزن Bare", Type="checkbox" },
            new GitField { Name="Template", LabelEn="Template Directory", LabelFa="دایرکتوری قالب", Type="text", PlaceholderEn="template-dir", PlaceholderFa="دایرکتوری قالب" }
        };
}
}
