namespace Core;

public class HelpCommandModel
{
    public string TitleEn => "Show Git Help";
    public string TitleFa => "نمایش راهنمای گیت";

    public string GuideHtmlEn => @"
<h3>Usage</h3>
<pre>git help [command]</pre>

<h4>Examples</h4>
<pre>
git help branch          # Show help for branch command
git help status          # Show help for status command
git help -a              # Show help for all commands
</pre>

<h4>Options</h4>
<ul>
<li>-a : Show help for all commands</li>
<li>[command] : Show help for a specific command</li>
</ul>

<h4>What It Does?</h4>
<p>The <strong>git help</strong> command provides detailed information about various Git commands. This is useful when you want to learn more about a specific command, its syntax, options, and usage. You can get help for any Git command by specifying it after <strong>git help</strong>. Additionally, using the <strong>-a</strong> option allows you to see a list of all available Git commands.</p>

<h4>Common Use Cases</h4>
<ul>
    <li>Getting help for specific Git commands such as <strong>git status</strong>, <strong>git branch</strong>, etc.</li>
    <li>Viewing the help documentation for Git commands when you're unsure about how to use them.</li>
    <li>Listing all available commands in Git using <strong>-a</strong>.</li>
</ul>

<h4>Best Practices</h4>
<ul>
    <li>Use <strong>git help [command]</strong> when you need specific help on a command.</li>
    <li>Use <strong>git help -a</strong> to get a list of all Git commands available, which can be helpful for exploring Git features.</li>
    <li>Read the examples and options sections carefully to understand the full range of options available for each command.</li>
</ul>

<h4>Limitations</h4>
<ul>
    <li>This command only provides help for Git commands and does not provide any help on Git concepts or workflows.</li>
    <li>Some advanced commands might require deeper knowledge or further documentation outside the basic help output.</li>
</ul>

<h4>Common Mistakes</h4>
<ul>
    <li>Forgetting to specify a valid Git command name after <strong>git help</strong> will result in an error.</li>
    <li>Not using the correct syntax for a command may lead to confusion or incorrect usage.</li>
</ul>

<h2>Overview</h2>
<p>The <strong>git help</strong> command is a great resource for learning about Git commands and their options. It's a quick way to get context-sensitive help when you're working with Git and need to understand a specific command or its functionality.</p>
";

    public string GuideHtmlFa => @"
<h3>استفاده</h3>
<pre>git help [دستور]</pre>

<h4>مثال‌ها</h4>
<pre>
git help branch          # Show help for branch command
git help status          # Show help for status command
git help -a              # Show help for all commands
</pre>

<h4>گزینه‌ها</h4>
<ul>
<li>-a : نمایش راهنما برای تمامی دستورات</li>
<li>[دستور] : نمایش راهنما برای دستور خاص</li>
</ul>

<h4>دقیقاً چه می‌کند؟</h4>
<p>دستور <strong>git help</strong> اطلاعات دقیقی در مورد دستورات مختلف گیت ارائه می‌دهد. این دستور زمانی که بخواهید بیشتر درباره یک دستور خاص، نحوۀ استفاده، گزینه‌ها و امکانات آن بیاموزید بسیار مفید است. همچنین با استفاده از گزینه <strong>-a</strong> می‌توانید لیستی از تمام دستورات موجود در گیت را مشاهده کنید.</p>

<h4>موارد کاربرد رایج</h4>
<ul>
    <li>دریافت راهنمایی برای دستورات خاص گیت مانند <strong>git status</strong> یا <strong>git branch</strong>.</li>
    <li>مشاهده مستندات راهنمای گیت زمانی که در استفاده از یک دستور خاص شک دارید.</li>
    <li>نمایش لیست تمامی دستورات گیت با استفاده از گزینه <strong>-a</strong>.</li>
</ul>

<h4>بهترین شیوه‌ها</h4>
<ul>
    <li>استفاده از <strong>git help [دستور]</strong> زمانی که به کمک خاص برای یک دستور نیاز دارید.</li>
    <li>استفاده از <strong>git help -a</strong> برای مشاهده لیست تمامی دستورات گیت که می‌تواند برای کاوش ویژگی‌های گیت مفید باشد.</li>
    <li>به دقت بخش مثال‌ها و گزینه‌ها را مطالعه کنید تا از تمامی امکانات دستور آگاه شوید.</li>
</ul>

<h4>محدودیت‌ها</h4>
<ul>
    <li>این دستور تنها راهنمایی در مورد دستورات گیت ارائه می‌دهد و اطلاعاتی در مورد مفاهیم یا روندهای گیت فراهم نمی‌کند.</li>
    <li>برخی دستورات پیشرفته ممکن است به دانش عمیق‌تری نیاز داشته باشند و برای اطلاعات بیشتر نیاز به مطالعه مستندات اضافی دارند.</li>
</ul>

<h4>اشتباهات رایج</h4>
<ul>
    <li>فراموش کردن وارد کردن نام یک دستور گیت معتبر پس از <strong>git help</strong> منجر به خطا می‌شود.</li>
    <li>استفاده نادرست از نحو دستور می‌تواند باعث ایجاد سردرگمی و اشتباه در استفاده از آن شود.</li>
</ul>

<h2>نمای کلی</h2>
<p>دستور <strong>git help</strong> ابزاری بسیار مفید برای یادگیری دستورات گیت و گزینه‌های آن است. این دستور یک راه سریع برای دریافت راهنمایی حساس به متن هنگام کار با گیت و نیاز به درک یک دستور خاص یا عملکرد آن است.</p>
";

    public List<GitField> Fields { get; set; } = new List<GitField>
    {
        new GitField { Name="Command", LabelEn="Command", LabelFa="دستور", Type="text", PlaceholderEn="branch", PlaceholderFa="branch", IsRequired=true },
        new GitField { Name="AllCommands", LabelEn="Show All Commands (-a)", LabelFa="نمایش همه دستورات (-a)", Type="checkbox" }
    };
}
