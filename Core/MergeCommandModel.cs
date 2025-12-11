namespace Core
{
    public class MergeCommandModel
    {
        public string TitleEn => "Merge Branches";
        public string TitleFa => "ادغام شاخه‌ها";

        public string GuideHtmlEn => @"
<h3>Usage</h3>
<pre>git merge [options] &lt;branch&gt;</pre>
<h4>Common Use Cases</h4>
<ul>
    <li>Merge another branch into the current branch: <code>git merge feature</code></li>
    <li>Force a merge commit even if fast-forward is possible: <code>git merge --no-ff feature</code></li>
    <li>Squash commits from another branch without committing: <code>git merge --squash feature</code></li>
    <li>Abort a merge operation: <code>git merge --abort</code></li>
</ul>
<h4>Examples</h4>
<pre>
git merge feature        # Merge 'feature' into current branch
git merge --no-ff feature # Create merge commit even if fast-forward
git merge --squash feature # Combine commits without committing
git merge --abort        # Abort an ongoing merge
git merge --commit       # Perform commit (default)
git merge --no-commit    # Merge but do not commit
git merge --strategy=recursive -X theirs feature # Use 'theirs' option with recursive strategy
</pre>
<h4>Limitations</h4>
<ul>
    <li>Cannot merge if there are uncommitted changes that conflict</li>
    <li>Merge conflicts must be resolved manually</li>
    <li>Fast-forward merge may not create a merge commit unless --no-ff is used</li>
</ul>
<h4>Options</h4>
<ul>
    <li>--no-ff : Create a merge commit even if fast-forward possible</li>
    <li>--ff : Allow fast-forward merge (default)</li>
    <li>--ff-only : Merge only if fast-forward possible</li>
    <li>--squash : Combine commits from branch without committing</li>
    <li>--commit / --no-commit : Control automatic commit</li>
    <li>--abort : Abort ongoing merge</li>
    <li>--edit / -e : Edit merge commit message</li>
    <li>--strategy &lt;strategy&gt; : Specify merge strategy</li>
    <li>-X &lt;option&gt; : Pass option to merge strategy (e.g., ours, theirs)</li>
    <li>--no-verify : Skip pre-merge hooks</li>
    <li>--quiet / -q : Suppress output</li>
</ul>
<h4>What Does it Do?</h4>
<p>The <code>git merge</code> command is used to integrate changes from one branch into another. It's commonly used to bring together feature branches into a main or development branch. Merge commits help preserve the history of both branches, making it easier to track and understand changes.</p>
<h4>Comparison with <code>git rebase</code></h4>
<h5>Feature Comparison</h5>
<table class='table table-bordered table-striped'>
    <thead>
        <tr>
            <th>Feature</th>
            <th><code>git merge</code></th>
            <th><code>git rebase</code></th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td><strong>Purpose</strong></td>
            <td>Integrates changes from one branch into another, preserving history.</td>
            <td>Moves or combines commits from one branch onto another, rewriting history.</td>
        </tr>
        <tr>
            <td><strong>Preserve commit history</strong></td>
            <td>Yes, creates a merge commit.</td>
            <td>No, commits are replayed and history is rewritten.</td>
        </tr>
        <tr>
            <td><strong>Handling conflicts</strong></td>
            <td>Merge conflicts must be resolved manually and create a merge commit.</td>
            <td>Rebase conflicts must be resolved manually, no merge commit is created.</td>
        </tr>
        <tr>
            <td><strong>Use case</strong></td>
            <td>When you want to preserve the full history of branches and see how they diverged.</td>
            <td>When you want to create a linear history and avoid merge commits.</td>
        </tr>
    </tbody>
</table>
<h4>Common Mistakes</h4>
<ul>
    <li>Forgetting to commit or stash changes before merging, leading to conflicts.</li>
    <li>Not resolving merge conflicts properly, resulting in lost work.</li>
    <li>Using fast-forward merge when you need a merge commit to preserve the history of the branch.</li>
</ul>
<h2>Best Practices</h2>
<ul>
    <li>Always commit or stash your changes before performing a merge to avoid conflicts.</li>
    <li>If you want to preserve the history of both branches, avoid using <code>--ff-only</code>.</li>
    <li>Use <code>--no-ff</code> to ensure a merge commit is created, even in cases where a fast-forward merge is possible.</li>
    <li>After resolving merge conflicts, carefully review your changes before committing.</li>
</ul>
<h2>Limitations</h2>
<ul>
    <li>You cannot merge if there are uncommitted changes that conflict with the branch you want to merge.</li>
    <li>Merge conflicts must be resolved manually, which can sometimes be difficult in large projects.</li>
    <li>Using <code>--ff</code> will allow fast-forward merges, but you may lose the distinct merge commit that can be helpful for future reference.</li>
</ul>
<h3>How to Use</h3>
<p>The <code>git merge</code> command is used to bring the changes from one branch into the current branch. Use the <code>--no-ff</code> option to force a merge commit and preserve the history of both branches.</p>
<ul>
    <li><code>git merge <branch></code>: Merge the specified branch into the current branch.</li>
    <li><code>git merge --no-ff <branch></code>: Force a merge commit even if the merge could be fast-forwarded.</li>
    <li><code>git merge --squash <branch></code>: Combine commits from the branch without committing the changes.</li>
    <li><code>git merge --abort</code>: Abort the merge if conflicts occur or if the merge process is interrupted.</li>
</ul>
<h2>Overview</h2>
<p>Use <code>git merge</code> to integrate changes from one branch into another. It helps you manage the history of your project and resolve conflicts manually. Whether you're working in a team or handling your own branches, <code>git merge</code> is essential for keeping your repository up-to-date.</p>";

        public string GuideHtmlFa => @"
<h3>استفاده</h3>
<pre>git merge [گزینه‌ها] &lt;شاخه&gt;</pre>
<h4>موارد کاربرد رایج</h4>
<ul>
    <li>ادغام یک شاخه دیگر به شاخه جاری: <code>git merge feature</code></li>
    <li>ایجاد commit ادغام حتی اگر fast-forward ممکن باشد: <code>git merge --no-ff feature</code></li>
    <li>ترکیب کامیت‌ها بدون انجام commit: <code>git merge --squash feature</code></li>
    <li>لغو عملیات merge: <code>git merge --abort</code></li>
</ul>
<h4>مثال‌ها</h4>
<pre>
git merge feature        # Merge 'feature' into current branch
git merge --no-ff feature # Create merge commit even if fast-forward
git merge --squash feature # Combine commits without committing
git merge --abort        # Abort an ongoing merge
git merge --commit       # Perform commit (default)
git merge --no-commit    # Merge but do not commit
git merge --strategy=recursive -X theirs feature # Use 'theirs' option with recursive strategy
</pre>
<h4>محدودیت‌ها</h4>
<ul>
    <li>نمی‌توان merge انجام داد اگر تغییرات ذخیره‌نشده وجود داشته باشد که با شاخه مورد نظر تضاد داشته باشد</li>
    <li>تضادهای merge باید دستی حل شوند</li>
    <li>merge fast-forward ممکن است commit ایجاد نکند مگر --no-ff استفاده شود</li>
</ul>
<h4>گزینه‌ها</h4>
<ul>
    <li>--no-ff : ایجاد commit ادغام حتی اگر fast-forward ممکن باشد</li>
    <li>--ff : اجازه fast-forward merge (پیش‌فرض)</li>
    <li>--ff-only : فقط اگر fast-forward ممکن باشد ادغام انجام شود</li>
    <li>--squash : ترکیب کامیت‌ها بدون commit</li>
    <li>--commit / --no-commit : کنترل commit خودکار</li>
    <li>--abort : لغو merge در حال اجرا</li>
    <li>--edit / -e : ویرایش پیام commit ادغام</li>
    <li>--strategy &lt;strategy&gt; : مشخص کردن استراتژی merge</li>
    <li>-X &lt;option&gt; : ارسال گزینه به استراتژی merge (مثلاً ours, theirs)</li>
    <li>--no-verify : رد کردن pre-merge hookها</li>
    <li>--quiet / -q : کاهش خروجی</li>
</ul>
<h4>دقیقا چه می‌کند؟</h4>
<p>دستور <code>git merge</code> برای ادغام تغییرات از یک شاخه به شاخه دیگر استفاده می‌شود. این دستور به‌طور معمول برای ترکیب شاخه‌های ویژگی به شاخه‌های اصلی یا توسعه استفاده می‌شود. commitهای merge به حفظ تاریخچه هر دو شاخه کمک می‌کنند و امکان دنبال کردن تغییرات را فراهم می‌کنند.</p>
<h4>مقایسه با <code>git rebase</code></h4>
<h5>مقایسه ویژگی‌ها</h5>
<table class='table table-bordered table-striped'>
    <thead>
        <tr>
            <th>ویژگی</th>
            <th><code>git merge</code></th>
            <th><code>git rebase</code></th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td><strong>هدف</strong></td>
            <td>ادغام تغییرات از یک شاخه به شاخه دیگر، حفظ تاریخچه</td>
            <td>انتقال یا ترکیب commitها از یک شاخه به شاخه دیگر، بازنویسی تاریخچه</td>
        </tr>
        <tr>
            <td><strong>حفظ تاریخچه commit</strong></td>
            <td>بله، ایجاد commit ادغام</td>
            <td>خیر، commitها دوباره اجرا می‌شوند و تاریخچه بازنویسی می‌شود</td>
        </tr>
        <tr>
            <td><strong>مدیریت تضادها</strong></td>
            <td>تضادهای merge باید به‌صورت دستی حل شوند و commit ادغام ایجاد می‌شود</td>
            <td>تضادهای rebase باید به‌صورت دستی حل شوند، هیچ commit ادغامی ایجاد نمی‌شود</td>
        </tr>
        <tr>
            <td><strong>موارد استفاده</strong></td>
            <td>وقتی می‌خواهید تاریخچه کامل شاخه‌ها را حفظ کنید و ببینید که چگونه از هم جدا شده‌اند</td>
            <td>وقتی می‌خواهید تاریخچه خطی ایجاد کنید و از commitهای merge جلوگیری کنید</td>
        </tr>
    </tbody>
</table>
<h4>اشتباهات رایج</h4>
<ul>
    <li>فراموش کردن commit یا stash تغییرات قبل از merge، که ممکن است منجر به تضاد شود.</li>
    <li>حل نکردن صحیح تضادهای merge، که ممکن است باعث از دست رفتن کار شود.</li>
    <li>استفاده از fast-forward merge زمانی که به یک commit ادغام نیاز دارید تا تاریخچه شاخه‌ها حفظ شود.</li>
</ul>
<h2>بهترین شیوه‌ها</h2>
<ul>
    <li>همیشه قبل از انجام merge تغییرات خود را commit یا stash کنید تا از تضاد جلوگیری شود.</li>
    <li>اگر می‌خواهید تاریخچه هر دو شاخه را حفظ کنید، از <code>--ff-only</code> استفاده نکنید.</li>
    <li>برای اطمینان از ایجاد commit ادغام حتی در مواقعی که merge fast-forward امکان‌پذیر است، از <code>--no-ff</code> استفاده کنید.</li>
    <li>بعد از حل تضادهای merge، تغییرات خود را با دقت بازبینی کنید قبل از انجام commit.</li>
</ul>
<h2>محدودیت‌ها</h2>
<ul>
    <li>شما نمی‌توانید merge انجام دهید اگر تغییرات ذخیره‌نشده‌ای وجود داشته باشد که با شاخه مورد نظر تضاد داشته باشد.</li>
    <li>تضادهای merge باید به‌صورت دستی حل شوند که ممکن است گاهی در پروژه‌های بزرگ دشوار باشد.</li>
    <li>استفاده از <code>--ff</code> اجازه می‌دهد که merge سریع انجام شود، اما ممکن است commit ادغام که برای مرجع در آینده مفید باشد را از دست بدهید.</li>
</ul>
<h3>نحوه استفاده</h3>
<p>برای ادغام تغییرات از یک شاخه به شاخه دیگر از دستور <code>git merge</code> استفاده کنید. اگر می‌خواهید history شاخه‌ها را حفظ کنید و از commit ادغام اطمینان حاصل کنید، از <code>--no-ff</code> استفاده کنید.</p>
<ul>
    <li><code>git merge <branch></code>: ادغام شاخه مشخص‌شده به شاخه جاری</li>
    <li><code>git merge --no-ff <branch></code>: اصرار به ایجاد commit ادغام حتی اگر merge امکان‌پذیر باشد</li>
    <li><code>git merge --squash <branch></code>: ترکیب کامیت‌ها از شاخه بدون انجام commit</li>
    <li><code>git merge --abort</code>: لغو عملیات merge در صورت بروز تضاد یا وقفه در عملیات</li>
</ul>
<h2>نمای کلی</h2>
<p>از <code>git merge</code> برای ادغام تغییرات از یک شاخه به شاخه دیگر استفاده می‌شود. این دستور به شما کمک می‌کند تا تاریخچه پروژه خود را مدیریت کرده و تضادها را دستی حل کنید. چه در یک تیم کار کنید یا با شاخه‌های خود سروکار داشته باشید، <code>git merge</code> ابزار اصلی برای به‌روز نگه‌داشتن مخزن شما است.</p>";

        public List<GitField> Fields { get; set; } = new List<GitField>
        {
            new GitField { Name="BranchName", LabelEn="Branch to Merge", LabelFa="شاخه برای ادغام", Type="text", PlaceholderEn="feature", PlaceholderFa="نام شاخه", IsRequired=true },
            new GitField { Name="NoFF", LabelEn="No Fast-Forward (--no-ff)", LabelFa="عدم Fast-Forward (--no-ff)", Type="checkbox" },
            new GitField { Name="FFOnly", LabelEn="Fast-Forward Only (--ff-only)", LabelFa="فقط Fast-Forward (--ff-only)", Type="checkbox" },
            new GitField { Name="Squash", LabelEn="Squash (--squash)", LabelFa="ترکیب کامیت‌ها (--squash)", Type="checkbox" },
            new GitField { Name="Commit", LabelEn="Commit (--commit)", LabelFa="انجام commit (--commit)", Type="checkbox" },
            new GitField { Name="NoCommit", LabelEn="No Commit (--no-commit)", LabelFa="ادغام بدون commit (--no-commit)", Type="checkbox" },
            new GitField { Name="Abort", LabelEn="Abort (--abort)", LabelFa="لغو merge (--abort)", Type="checkbox" },
            new GitField { Name="Edit", LabelEn="Edit (-e/--edit)", LabelFa="ویرایش پیام commit (-e/--edit)", Type="checkbox" },
            new GitField { Name="Strategy", LabelEn="Strategy (--strategy)", LabelFa="استراتژی (--strategy)", Type="text", PlaceholderEn="recursive", PlaceholderFa="recursive" },
            new GitField { Name="StrategyOption", LabelEn="Strategy Option (-X)", LabelFa="گزینه استراتژی (-X)", Type="text", PlaceholderEn="theirs", PlaceholderFa="theirs" },
            new GitField { Name="NoVerify", LabelEn="No Verify (--no-verify)", LabelFa="نادیده گرفتن hookها (--no-verify)", Type="checkbox" },
            new GitField { Name="Quiet", LabelEn="Quiet (-q)", LabelFa="خروجی کم (-q)", Type="checkbox" }
        };
    }
}
