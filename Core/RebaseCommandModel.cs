namespace Core;
using System.Collections.Generic;

public class RebaseCommandModel
{
    public string TitleEn => "Rebase Branch";
    public string TitleFa => "بازپایه‌گذاری شاخه";

    public string GuideHtmlEn => @"
<h3>Usage</h3>
<pre>git rebase [options] [<upstream>] [<branch>]</pre>

<h4>What is Rebase?</h4>
<p>Rebase moves or reapplies local commits on top of another base tip. Unlike <code>merge</code>, which creates a merge commit, rebase creates a linear history.</p>

<h4>Difference vs Merge</h4>
<ul>
<li><strong>Merge:</strong> Combines histories and creates a merge commit.</li>
<li><strong>Rebase:</strong> Reapplies commits on top of another branch; linear history; avoids merge commits.</li>
<li>Rebase rewrites history; merge does not.</li>
<li>Rebase is useful before pushing to avoid multiple merge commits.</li>
</ul>

<h4>Examples</h4>
<pre>
# Rebase current branch onto develop
git rebase develop

# Interactive rebase for last 5 commits
git rebase -i HEAD~5

# Rebase onto another branch with autosquash
git rebase --interactive --autosquash feature

# Abort rebase
git rebase --abort

# Continue after resolving conflicts
git rebase --continue

# Skip a commit during rebase
git rebase --skip
</pre>

<h4>Limitations</h4>
<ul>
<li>Rewriting history can be dangerous if branch is shared with others.</li>
<li>Conflicts may occur and require manual resolution.</li>
<li>Force push may be required after rebasing shared branches.</li>
</ul>

<h4>Options</h4>
<ul>
<li>-i, --interactive : Interactive rebase</li>
<li>--autosquash : Automatically squash fixup commits</li>
<li>--continue : Continue rebase after conflict</li>
<li>--abort : Abort the rebase</li>
<li>--skip : Skip current patch</li>
<li>--onto &lt;newbase&gt; : Rebase onto different base</li>
<li>-p, --preserve-merges : Try to preserve merge commits</li>
<li>--exec &lt;cmd&gt; : Run command on each commit</li>
<li>--root : Rebase all commits reachable from root</li>
</ul>";

    public string GuideHtmlFa => @"
<h3>استفاده</h3>
<pre>git rebase [گزینه‌ها] [<upstream>] [<branch>]</pre>

<h4>Rebase چیست؟</h4>
<p>Rebase کامیت‌های محلی را روی یک شاخه پایه دیگر اعمال می‌کند. برخلاف <code>merge</code> که commit جدید ایجاد می‌کند، rebase تاریخچه را خطی می‌کند.</p>

<h4>تفاوت با Merge</h4>
<ul>
<li><strong>Merge:</strong> تاریخچه‌ها را ترکیب می‌کند و merge commit ایجاد می‌کند.</li>
<li><strong>Rebase:</strong> کامیت‌ها را روی شاخه دیگر اعمال می‌کند؛ تاریخچه خطی؛ بدون merge commit.</li>
<li>Rebase تاریخچه را بازنویسی می‌کند، Merge نه.</li>
<li>Rebase قبل از push مفید است تا merge commitهای اضافی ایجاد نشود.</li>
</ul>

<h4>مثال‌ها</h4>
<pre>
# Rebase current branch onto develop
git rebase develop

# Interactive rebase for last 5 commits
git rebase -i HEAD~5

# Rebase onto another branch with autosquash
git rebase --interactive --autosquash feature

# Abort rebase
git rebase --abort

# Continue after resolving conflicts
git rebase --continue

# Skip a commit during rebase
git rebase --skip
</pre>

<h4>محدودیت‌ها</h4>
<ul>
<li>بازنویسی تاریخچه خطرناک است اگر شاخه با دیگران به اشتراک گذاشته شده باشد.</li>
<li>ممکن است conflict رخ دهد و نیاز به حل دستی باشد.</li>
<li>پس از rebase شاخه‌های مشترک ممکن است نیاز به force push باشد.</li>
</ul>

<h4>گزینه‌ها</h4>
<ul>
<li>-i, --interactive : بازپایه‌گذاری تعاملی</li>
<li>--autosquash : خودکار squash کامیت‌های fixup</li>
<li>--continue : ادامه rebase پس از conflict</li>
<li>--abort : لغو rebase</li>
<li>--skip : رد کردن کامیت فعلی</li>
<li>--onto &lt;newbase&gt; : بازپایه‌گذاری روی شاخه جدید</li>
<li>-p, --preserve-merges : تلاش برای حفظ merge commitها</li>
<li>--exec &lt;cmd&gt; : اجرای دستور روی هر کامیت</li>
<li>--root : بازپایه‌گذاری همه کامیت‌ها از ریشه</li>
</ul>";

    public List<GitField> Fields { get; set; } = new List<GitField>
    {
        new GitField{ Name="Upstream", LabelEn="Upstream Branch", LabelFa="شاخه پایه", Type="text", PlaceholderEn="develop", PlaceholderFa="develop" },
        new GitField{ Name="Branch", LabelEn="Branch to Rebase", LabelFa="شاخه برای بازپایه‌گذاری", Type="text", PlaceholderEn="feature", PlaceholderFa="feature" },
        new GitField{ Name="Interactive", LabelEn="Interactive (-i)", LabelFa="تعاملی (-i)", Type="checkbox" },
        new GitField{ Name="Autosquash", LabelEn="Autosquash (--autosquash)", LabelFa="ادغام خودکار (--autosquash)", Type="checkbox" },
        new GitField{ Name="Continue", LabelEn="Continue (--continue)", LabelFa="ادامه (--continue)", Type="checkbox" },
        new GitField{ Name="Abort", LabelEn="Abort (--abort)", LabelFa="لغو (--abort)", Type="checkbox" },
        new GitField{ Name="Skip", LabelEn="Skip (--skip)", LabelFa="رد کردن (--skip)", Type="checkbox" },
        new GitField{ Name="Onto", LabelEn="Onto (--onto)", LabelFa="روی شاخه (--onto)", Type="text", PlaceholderEn="newbase", PlaceholderFa="شاخه جدید" },
        new GitField{ Name="PreserveMerges", LabelEn="Preserve Merges (-p)", LabelFa="حفظ merge (-p)", Type="checkbox" },
        new GitField{ Name="Exec", LabelEn="Exec Command (--exec)", LabelFa="اجرای دستور (--exec)", Type="text", PlaceholderEn="npm test", PlaceholderFa="دستور برای اجرا" },
        new GitField{ Name="Root", LabelEn="Root (--root)", LabelFa="از ریشه (--root)", Type="checkbox" }
    };
}
