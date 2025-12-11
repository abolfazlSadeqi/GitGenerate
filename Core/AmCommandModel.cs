namespace Core;

public class AmCommandModel
{
    public string TitleEn => "Apply Patch from Mail";
    public string TitleFa => "اعمال Patch از ایمیل";

    public string GuideHtmlEn => @"
<h3>Usage</h3>
<pre>git am [options] <patch-file></pre>

<h4>Examples</h4>
<pre>
git am < patch.diff      # Apply a patch from a file
git am --abort           # Abort the patch application
git am --continue        # Continue after resolving conflicts
</pre>

<h4>What It Does?</h4>
<p>The <strong>git am</strong> command is used to apply patches to the current branch. Patches are typically received via email and applied using this command. The patch can be a diff file that includes changes you want to apply to your local repository. This command is often used when contributing to open-source projects or when collaborating via email and patches.</p>

<h4>Common Use Cases</h4>
<ul>
    <li>Applying a patch received from a contributor via email.</li>
    <li>Continuing the patch application after resolving conflicts manually.</li>
    <li>Aborting the patch application if an error or conflict arises that cannot be resolved.</li>
</ul>

<h4>Best Practices</h4>
<ul>
    <li>Always review the patch file before applying it to avoid unwanted changes.</li>
    <li>Ensure that you are working in the correct branch before applying a patch.</li>
    <li>If conflicts arise during the patch application, resolve them carefully and then use <strong>git am --continue</strong> to proceed.</li>
</ul>

<h4>Limitations</h4>
<ul>
    <li>Cannot apply a patch if the file has already been modified in the current branch without resolving conflicts first.</li>
    <li>Requires that the patch file be in the correct format and that the repository is in a clean state (no uncommitted changes).</li>
</ul>

<h4>Common Mistakes</h4>
<ul>
    <li>Forgetting to abort the patch application if a conflict arises and failing to resolve it properly.</li>
    <li>Applying a patch to the wrong branch or before pulling the latest changes from the remote repository.</li>
</ul>

<h2>Overview</h2>
<p>The <strong>git am</strong> command is useful when you receive patches through email or other means and need to apply them to your local repository. It's commonly used in open-source development and collaborative projects. The command can be used to apply patches, handle conflicts, and continue after resolving them.</p>
";

    public string GuideHtmlFa => @"
<h3>استفاده</h3>
<pre>git am [گزینه‌ها] <patch-file></pre>

<h4>مثال‌ها</h4>
<pre>
git am < patch.diff      # Apply a patch from a file
git am --abort           # Abort the patch application
git am --continue        # Continue after resolving conflicts
</pre>

<h4>دقیقاً چه می‌کند؟</h4>
<p>دستور <strong>git am</strong> برای اعمال پچ‌ها به شاخه جاری استفاده می‌شود. پچ‌ها معمولاً از طریق ایمیل دریافت شده و با استفاده از این دستور به مخزن گیت اعمال می‌شوند. پچ می‌تواند یک فایل diff باشد که تغییراتی را که می‌خواهید به مخزن محلی خود اعمال کنید، شامل می‌شود. این دستور معمولاً زمانی استفاده می‌شود که بخواهید به پروژه‌های متن‌باز کمک کنید یا با ایمیل و پچ‌ها همکاری کنید.</p>

<h4>موارد کاربرد رایج</h4>
<ul>
    <li>اعمال یک پچ دریافت شده از یک همکار یا مشارکت‌کننده از طریق ایمیل.</li>
    <li>ادامه اعمال پچ بعد از حل تعارض‌ها به صورت دستی.</li>
    <li>انصراف از اعمال پچ در صورت بروز خطا یا تعارض که قابل حل نیست.</li>
</ul>

<h4>بهترین شیوه‌ها</h4>
<ul>
    <li>قبل از اعمال پچ، فایل آن را به دقت مرور کنید تا از ایجاد تغییرات ناخواسته جلوگیری شود.</li>
    <li>اطمینان حاصل کنید که در شاخه صحیحی برای اعمال پچ کار می‌کنید.</li>
    <li>اگر تعارضاتی در حین اعمال پچ به وجود آمد، آن‌ها را با دقت حل کنید و سپس از دستور <strong>git am --continue</strong> برای ادامه استفاده کنید.</li>
</ul>

<h4>محدودیت‌ها</h4>
<ul>
    <li>اگر پچ به فایل‌هایی که قبلاً در شاخه جاری تغییراتی روی آن‌ها اعمال شده، نمی‌تواند اعمال شود مگر اینکه تعارض‌ها حل شوند.</li>
    <li>برای اعمال پچ، فایل پچ باید در قالب صحیح باشد و مخزن گیت باید در حالت تمیز باشد (بدون تغییرات کامیت نشده).</li>
</ul>

<h4>اشتباهات رایج</h4>
<ul>
    <li>فراموش کردن انصراف از اعمال پچ در صورتی که تعارضی پیش بیاید و عدم حل صحیح آن.</li>
    <li>اعمال پچ به شاخه اشتباه یا قبل از کشیدن تغییرات جدید از مخزن راه دور.</li>
</ul>

<h2>نمای کلی</h2>
<p>دستور <strong>git am</strong> زمانی مفید است که پچ‌ها را از طریق ایمیل یا روش‌های دیگر دریافت کرده و نیاز دارید آن‌ها را به مخزن محلی خود اعمال کنید. این دستور به طور رایج در توسعه پروژه‌های متن‌باز و پروژه‌های مشارکتی استفاده می‌شود. با این دستور می‌توانید پچ‌ها را اعمال کرده، تعارض‌ها را حل کرده و بعد از آن ادامه دهید.</p>
";

    public List<GitField> Fields { get; set; } = new List<GitField>
    {
        new GitField { Name="PatchFile", LabelEn="Patch File", LabelFa="فایل Patch", Type="text", PlaceholderEn="patch.diff", PlaceholderFa="patch.diff", IsRequired=true },
        new GitField { Name="Abort", LabelEn="Abort (--abort)", LabelFa="انصراف (--abort)", Type="checkbox" },
        new GitField { Name="Continue", LabelEn="Continue (--continue)", LabelFa="ادامه (--continue)", Type="checkbox" },
        new GitField { Name="Signoff", LabelEn="Signoff (--signoff)", LabelFa="امضاء (--signoff)", Type="checkbox" }
    };
}
