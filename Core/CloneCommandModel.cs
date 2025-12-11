namespace Core;

// مدل یک فیلد در فرم دستور
public class CloneCommandModel
{
    public string Id => "clone";
    public string TitleEn => "Clone Repository";
    public string TitleFa => "کلون کردن مخزن";

    public string GuideHtmlEn => @"
<h3>Usage</h3>
<pre>git clone [options] &lt;repository&gt; [directory]</pre>
<h4>Examples</h4>
<pre>git clone https://github.com/user/repo.git
git clone -b develop https://github.com/user/repo.git myfolder</pre>
<h4>Limitations</h4>
<ul>
<li>Requires network access</li>
<li>Cannot clone private repos without authentication</li>
</ul>
<h4>Options</h4>
<ul>
<li>-b &lt;branch&gt; : Clone specific branch</li>
<li>--depth &lt;n&gt; : Create shallow clone with history truncated to n commits</li>
<li>--single-branch : Clone only one branch</li>
<li>--recurse-submodules : Initialize submodules</li>
<li>--mirror : Clone as mirror</li>
<li>--bare : Clone as bare repository</li>
<li>-o &lt;name&gt; : Set remote name</li>
<li>--config &lt;key=value&gt; : Set config inside new repo</li>
</ul>
";

    public string GuideHtmlFa => @"
<h3>استفاده</h3>
<pre>git clone [options] &lt;repository&gt; [directory]</pre>
<h4>مثال‌ها</h4>
<pre>git clone https://github.com/user/repo.git
git clone -b develop https://github.com/user/repo.git myfolder</pre>
<h4>محدودیت‌ها</h4>
<ul>
<li>نیاز به دسترسی شبکه دارد</li>
<li>برای مخازن خصوصی نیاز به احراز هویت دارد</li>
</ul>
<h4>گزینه‌ها</h4>
<ul>
<li>-b &lt;branch&gt; : کلون کردن شاخه مشخص</li>
<li>--depth &lt;n&gt; : کلون کم‌عمق با تاریخچه محدود به n کامیت</li>
<li>--single-branch : کلون تنها یک شاخه</li>
<li>--recurse-submodules : آماده‌سازی submoduleها</li>
<li>--mirror : کلون به صورت mirror</li>
<li>--bare : کلون به صورت bare</li>
<li>-o &lt;name&gt; : نام remote</li>
<li>--config &lt;key=value&gt; : تنظیم کانفیگ داخل مخزن جدید</li>
</ul>
";

    public List<GitField> Fields { get; set; } = new List<GitField>
        {
            new GitField { Name="Repository", LabelEn="Repository URL", LabelFa="آدرس مخزن", Type="text", PlaceholderEn="https://github.com/user/repo.git", PlaceholderFa="آدرس مخزن", IsRequired=true },
            new GitField { Name="Directory", LabelEn="Target Directory", LabelFa="پوشه مقصد", Type="text", PlaceholderEn="myfolder", PlaceholderFa="پوشه مقصد" },
            new GitField { Name="Branch", LabelEn="Branch", LabelFa="شاخه", Type="text", PlaceholderEn="develop", PlaceholderFa="شاخه" },
            new GitField { Name="Depth", LabelEn="Depth", LabelFa="عمق", Type="number", PlaceholderEn="1", PlaceholderFa="تعداد کامیت" },
            new GitField { Name="SingleBranch", LabelEn="Single Branch", LabelFa="کلون فقط یک شاخه", Type="checkbox" },
            new GitField { Name="RecurseSubmodules", LabelEn="Recurse Submodules", LabelFa="آماده‌سازی Submodule ها", Type="checkbox" },
            new GitField { Name="Mirror", LabelEn="Mirror Clone", LabelFa="کلون به صورت Mirror", Type="checkbox" },
            new GitField { Name="Bare", LabelEn="Bare Clone", LabelFa="کلون به صورت Bare", Type="checkbox" },
            new GitField { Name="RemoteName", LabelEn="Remote Name (-o)", LabelFa="نام Remote (-o)", Type="text", PlaceholderEn="origin", PlaceholderFa="origin" },
            new GitField { Name="Config", LabelEn="Config (key=value)", LabelFa="تنظیم کانفیگ", Type="text", PlaceholderEn="user.name=John", PlaceholderFa="user.name=John" }
        };
}

