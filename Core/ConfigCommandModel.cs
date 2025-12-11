namespace Core
{
    public class ConfigCommandModel
    {
        public string TitleEn => "Configure Git Settings";
        public string TitleFa => "تنظیمات گیت";

        public string GuideHtmlEn => @"
<h3>Usage</h3>
<pre>git config [options] [key] [value]</pre>
<h4>Examples</h4>
<pre>
git config user.name 'Your Name'          # Set global username
git config user.email 'your.email@example.com' # Set global email
git config --global core.editor nano      # Set default editor
git config --list                         # List all config settings
</pre>

<h4>Options</h4>
<ul>
<li>--global : Apply the setting globally</li>
<li>--local : Apply the setting to the local repository</li>
<li>--system : Apply the setting to the system</li>
<li>--list : List all current settings</li>
</ul>

<h4>What Does Git Config Do?</h4>
<p>The <strong>git config</strong> command allows you to configure Git settings such as user information, default editor, and other preferences. These settings can be applied globally, locally (for a specific repository), or system-wide. It is important to configure Git with your name and email to identify your commits correctly.</p>

<h4>Common Use Cases</h4>
<ul>
    <li>Setting your name and email globally for all repositories.</li>
    <li>Configuring the default text editor used by Git (e.g., nano, vim, or Visual Studio Code).</li>
    <li>Listing all Git settings to check or troubleshoot configuration.</li>
</ul>

<h4>Comparison with Other Git Commands</h4>
<table border='1' cellpadding='10'>
    <tr>
        <th>Feature</th>
        <th>git config</th>
        <th>git init</th>
    </tr>
    <tr>
        <td><strong>Purpose</strong></td>
        <td>Set and get Git configuration settings</td>
        <td>Initialize a new Git repository</td>
    </tr>
    <tr>
        <td><strong>Effect</strong></td>
        <td>Configures Git settings (user name, email, editor, etc.)</td>
        <td>Creates a new local Git repository</td>
    </tr>
    <tr>
        <td><strong>Scope</strong></td>
        <td>Global, local, system</td>
        <td>Only local to the directory</td>
    </tr>
</table>

<h4>In Simple Terms</h4>
<p><strong>git config</strong> is like setting up preferences in an application. You tell Git how to identify you, which editor to use, and various other preferences to make your Git experience smoother. This is essential for ensuring consistency in your workflow across different repositories.</p>

<h4>Common Mistakes</h4>
<ul>
    <li>Forgetting to configure your user name and email, which leads to commits being made under the default name ('Your Name') and email ('you @example.com').</li>
    <li>Applying settings globally when they should be local (e.g., changing the editor for one repository only).</li>
    <li>Not checking your configuration with<strong> git config --list</strong> to ensure everything is set correctly.</li>
</ul>

<h2>Best Practices</h2>
<ul>
    <li>Always configure your user name and email globally as soon as you set up Git for the first time.</li>
    <li>Use<strong> git config --global</strong> for settings that apply to all repositories and<strong> git config --local</strong> for settings specific to a single repository.</li>
    <li>Check your Git configuration regularly with <strong>git config --list</strong> to ensure that everything is set as expected.</li>
</ul>

<h2>Limitations</h2>
<ul>
    <li><strong>git config</strong> does not track changes to files or commit them.It is purely for configuring Git settings.</li>
    <li>Changes made via<strong> git config</strong> affect only the configuration of Git.They do not modify the actual repository contents.</li>
</ul>

<h3>How to Use</h3>
<p>Run<pre> git config[options][key][value]</pre> to configure Git.For example, <pre>git config user.name 'Your Name'</pre> sets your global username, and<pre> git config --global core.editor nano</pre> sets your default editor globally.</p>

<h2>Overview</h2>
<p>The<strong> git config</strong> command is essential for configuring Git’s behavior. You can configure global settings (for all repositories), local settings(for a specific repository), and system-wide settings.</p>

<h4>Options</h4>
<ul>
    <li>--global : Apply settings globally across all repositories</li>
    <li>--local : Apply settings to the current repository only</li>
    <li>--system : Apply settings across the system</li>
    <li>--list : Display all current settings</li>
</ul>
";

        public string GuideHtmlFa => @"
<h3>استفاده</h3>
<pre>git config [گزینه‌ها] [کلید] [مقدار]</pre>

<h4>مثال‌ها</h4>
<pre>
git config user.name 'Your Name'          # Set global username
git config user.email 'your.email@example.com' # Set global email
git config --global core.editor nano      # Set default editor
git config --list                         # List all config settings
</pre>

<h4>گزینه‌ها</h4>
<ul>
<li>--global : اعمال تنظیمات به صورت جهانی</li>
<li>--local : اعمال تنظیمات به صورت محلی برای ریپازیتوری جاری</li>
<li>--system : اعمال تنظیمات به صورت سیستمی</li>
<li>--list : نمایش تمامی تنظیمات</li>
</ul>

<h4>دقیقاً چه می‌کند؟</h4>
<p>دستور <strong>git config</strong> به شما این امکان را می‌دهد که تنظیمات گیت را پیکربندی کنید، مانند نام کاربری، ایمیل و سایر ترجیحات. این تنظیمات می‌توانند به صورت جهانی، محلی (برای یک مخزن خاص) یا سیستمی اعمال شوند. برای اطمینان از شناسایی صحیح کامیت‌ها، تنظیم نام و ایمیل در گیت بسیار مهم است.</p>

<h4>موارد کاربرد رایج</h4>
<ul>
    <li>تنظیم نام و ایمیل خود به صورت جهانی برای تمامی مخازن.</li>
    <li>پیکربندی ویرایشگر پیش‌فرض گیت (مانند nano، vim یا Visual Studio Code).</li>
    <li>نمایش تنظیمات گیت برای بررسی یا رفع مشکل در پیکربندی.</li>
</ul>

<h4>مقایسه با دستورات دیگر گیت</h4>
<table border='1' cellpadding='10'>
    <tr>
        <th>ویژگی</th>
        <th>git config</th>
        <th>git init</th>
    </tr>
    <tr>
        <td><strong>هدف</strong></td>
        <td>تنظیم و دریافت تنظیمات گیت</td>
        <td>ایجاد یک مخزن گیت جدید</td>
    </tr>
    <tr>
        <td><strong>اثر</strong></td>
        <td>تنظیمات گیت (نام کاربری، ایمیل، ویرایشگر و غیره) را پیکربندی می‌کند</td>
        <td>یک مخزن گیت محلی جدید ایجاد می‌کند</td>
    </tr>
    <tr>
        <td><strong>دامنه</strong></td>
        <td>جهانی، محلی، سیستمی</td>
        <td>فقط محلی در دایرکتوری فعلی</td>
    </tr>
</table>

<h4>به زبان ساده</h4>
<p>دستور <strong>git config</strong> مانند تنظیم ترجیحات در یک نرم‌افزار است. شما به گیت می‌گویید که چگونه شما را شناسایی کند، از چه ویرایشگری استفاده کند و سایر تنظیمات را برای تجربه‌ای بهتر در گیت اعمال می‌کنید. این تنظیمات برای اطمینان از یکپارچگی در گردش کار شما در مخازن مختلف ضروری است.</p>

<h4>اشتباهات رایج</h4>
<ul>
    <li>فراموش کردن پیکربندی نام کاربری و ایمیل،
<h4>اشتباهات رایج</h4>
<ul>
    <li>فراموش کردن پیکربندی نام کاربری و ایمیل، که منجر به این می‌شود که کامیت‌ها با نام پیش‌فرض ('Your Name') و ایمیل ('you @example.com') ثبت شوند.</li>
    <li>اعمال تنظیمات به صورت جهانی زمانی که باید به صورت محلی اعمال شوند (مثلاً تغییر ویرایشگر برای یک مخزن خاص).</li>
    <li>عدم بررسی تنظیمات با دستور<strong> git config --list</strong> برای اطمینان از درست بودن پیکربندی‌ها.</li>
</ul>

<h2>بهترین شیوه‌ها(Best Practices)</h2>
<ul>
    <li>همیشه نام کاربری و ایمیل خود را به صورت جهانی تنظیم کنید به محض اینکه گیت را برای اولین بار تنظیم می‌کنید.</li>
    <li>از<strong> git config --global</strong> برای تنظیماتی که برای همه مخازن اعمال می‌شوند و از<strong> git config --local</strong> برای تنظیماتی که فقط برای یک مخزن خاص اعمال می‌شوند استفاده کنید.</li>
    <li>تنظیمات گیت خود را به طور منظم با <strong>git config --list</strong> بررسی کنید تا اطمینان حاصل کنید که همه چیز به درستی تنظیم شده است.</li>
</ul>

<h2>محدودیت‌ها</h2>
<ul>
    <li><strong>git config</strong> تغییرات را در فایل‌های گیت اعمال نمی‌کند.تنها تنظیمات پیکربندی را تنظیم می‌کند.</li>
    <li>تغییرات انجام شده توسط <strong>git config</strong> تنها بر تنظیمات گیت تأثیر می‌گذارند و هیچ‌گونه تغییری در محتوای مخزن ایجاد نمی‌کنند.</li>
</ul>

<h3>نحوه استفاده</h3>
<p>دستور<pre> git config[options][key][value]</pre> را اجرا کنید تا گیت را پیکربندی کنید. به عنوان مثال، <pre>git config user.name 'Your Name'</pre> نام کاربری جهانی شما را تنظیم می‌کند، و<pre> git config --global core.editor nano</pre> ویرایشگر پیش‌فرض شما را به صورت جهانی تنظیم می‌کند.</p>

<h2>نمای کلی</h2>
<p>دستور<strong> git config</strong> برای پیکربندی تنظیمات گیت ضروری است.شما می‌توانید تنظیمات جهانی (برای تمام مخازن)، محلی(برای یک مخزن خاص) و سیستمی را تنظیم کنید.</p>
";
        public List<GitField> Fields { get; set; } = new List<GitField>
        {
            new GitField { Name="Key", LabelEn="Setting Key", LabelFa="کلید تنظیم", Type="text", PlaceholderEn="user.name", PlaceholderFa="user.name", IsRequired=true },
            new GitField { Name="Value", LabelEn="Setting Value", LabelFa="مقدار تنظیم", Type="text", PlaceholderEn="'Your Name'", PlaceholderFa="'Your Name'", IsRequired=true },
            new GitField { Name="Global", LabelEn="Global (--global)", LabelFa="جهانی (--global)", Type="checkbox" },
            new GitField { Name="List", LabelEn="List Settings (--list)", LabelFa="نمایش تنظیمات (--list)", Type="checkbox" }
        };
    }
}
