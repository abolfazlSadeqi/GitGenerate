namespace Core
{
    public class BranchCommandModel
    {
        public string TitleEn => "Branch Management";
        public string TitleFa => "مدیریت شاخه‌ها";

        public string GuideHtmlEn => @"
<h3>Usage</h3>
<pre>git branch [options] [branch-name]</pre>
<h4>Common Use Cases</h4>
<ul>
    <li>List local branches: <code>git branch</code></li>
    <li>Create a new branch: <code>git branch new-feature</code></li>
    <li>Delete a branch: <code>git branch -d old-feature</code></li>
    <li>Rename a branch: <code>git branch -m old-feature new-feature</code></li>
</ul>
<h4>Examples</h4>
<pre>
git branch               # List local branches
git branch -r            # List remote branches
git branch -a            # List all branches
git branch new-feature   # Create new branch
git branch -d old-feature # Delete local branch
git branch -D old-feature # Force delete local branch
git branch -m old new    # Rename branch
</pre>
<h4>What Does it Do?</h4>
<p>The <code>git branch</code> command allows you to create, list, delete, and rename branches in your Git repository. Additionally, it helps you track remote branches and inspect which branches have been merged or not merged into the current branch (HEAD). This is an essential tool for working with multiple branches in Git.</p>
<h4>Comparison between <code>git branch</code> and <code>git checkout</code></h4>
<h5>Feature Comparison</h5>
<table class='table table-bordered table-striped'>
    <thead>
        <tr>
            <th>Feature</th>
            <th><code>git branch</code></th>
            <th><code>git checkout</code></th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td><strong>Purpose</strong></td>
            <td>Manage branches (create, list, delete, rename, etc.)</td>
            <td>Switch between branches or restore working tree files</td>
        </tr>
        <tr>
            <td><strong>Create a branch</strong></td>
            <td><code>git branch new-branch</code></td>
            <td><code>git checkout -b new-branch</code></td>
        </tr>
        <tr>
            <td><strong>Switch branches</strong></td>
            <td>No direct command for switching branches</td>
            <td><code>git checkout branch-name</code></td>
        </tr>
        <tr>
            <td><strong>Delete a branch</strong></td>
            <td><code>git branch -d branch-name</code></td>
            <td>No direct command for deleting branches</td>
        </tr>
        <tr>
            <td><strong>Rename a branch</strong></td>
            <td><code>git branch -m old-name new-name</code></td>
            <td>No direct command for renaming branches</td>
        </tr>
        <tr>
            <td><strong>Track remote branches</strong></td>
            <td><code>git branch -r</code> (lists remote branches)</td>
            <td><code>git checkout branch-name</code> (if branch exists locally, or create a tracking branch)</td>
        </tr>
        <tr>
            <td><strong>Restore working directory files</strong></td>
            <td>No direct command for restoring files</td>
            <td><code>git checkout -- <file-name></code> (restore file)</td>
        </tr>
    </tbody>
</table>
<h4>Common Mistakes</h4>
<ul>
    <li>Trying to delete the current branch: You cannot delete the branch you are currently working on.</li>
    <li>Forgetting to commit or stash changes: Deleting or force-deleting branches without committing or stashing changes may lead to loss of uncommitted work.</li>
    <li>Incorrect branch names: Always double-check the branch name you are using to avoid errors.</li>
</ul>
<h2>Best Practices</h2>
<ul>
    <li>Always make sure to commit or stash your changes before deleting a branch to avoid losing any work.</li>
    <li>Use descriptive branch names that reflect the purpose of the branch (e.g., <code>feature/add-login</code>).</li>
    <li>Before force-deleting a branch, ensure that all changes are merged, backed up, or safely stored to avoid losing work.</li>
    <li>Use the <code>--merged</code> and <code>--no-merged</code> flags to check which branches are ready to be deleted or need merging.</li>
</ul>
<h2>Limitations</h2>
<ul>
    <li>You cannot delete the branch you are currently on. Switch to a different branch before deletion.</li>
    <li>Deleting a non-existent branch will cause an error.</li>
    <li>Force deleting a branch may cause you to lose unmerged changes if you have not committed or backed them up.</li>
</ul>
<h3>How to Use</h3>
<p>Use the <code>git branch</code> command with different options to list, delete, or rename branches as needed. Below are some of the most common use cases:</p>
<ul>
    <li><code>git branch -d <branch></code>: Deletes the specified branch, but only if it has been fully merged into the current branch.</li>
    <li><code>git branch -D <branch></code>: Force deletes the specified branch, even if it contains unmerged changes.</li>
    <li><code>git branch -m <old-name> <new-name></code>: Renames an existing branch to a new name.</li>
    <li><code>git branch -a</code>: Lists all branches, both local and remote, so you can see the entire repository structure.</li>
    <li><code>git branch -r</code>: Lists remote branches, helpful if you want to see branches hosted on remote repositories.</li>
</ul>
<h2>Overview</h2>
<p>The <code>git branch</code> command is essential for managing branches in a Git repository. Whether you're creating, deleting, or renaming branches, this command provides a comprehensive set of options to organize and structure your project efficiently.</p>";

        public string GuideHtmlFa => @"
<h3>استفاده</h3>
<pre>git branch [گزینه‌ها] [نام شاخه]</pre>
<h4>موارد کاربرد رایج</h4>
<ul>
    <li>نمایش شاخه‌های محلی: <code>git branch</code></li>
    <li>ایجاد شاخه جدید: <code>git branch new-feature</code></li>
    <li>حذف شاخه: <code>git branch -d old-feature</code></li>
    <li>تغییر نام شاخه: <code>git branch -m old-feature new-feature</code></li>
</ul>
<h4>مثال‌ها</h4>
<pre>
git branch               # List local branches
git branch -r            # List remote branches
git branch -a            # List all branches
git branch new-feature   # Create new branch
git branch -d old-feature # Delete local branch
git branch -D old-feature # Force delete local branch
git branch -m old new    # Rename branch
</pre>
<h4>دقیقا چه می‌کند؟</h4>
<p>دستور <code>git branch</code> برای مدیریت شاخه‌ها در گیت استفاده می‌شود. این دستور به شما اجازه می‌دهد شاخه‌های جدید ایجاد کنید، شاخه‌های موجود را حذف یا تغییر نام دهید، و همچنین می‌توانید شاخه‌های remote و merge شده را مشاهده کنید. این ابزار برای پروژه‌های چندشاخه‌ای در گیت بسیار ضروری است.</p>
<h4>مقایسه بین <code>git branch</code> و <code>git checkout</code></h4>
<h5>مقایسه ویژگی‌ها</h5>
<table class='table table-bordered table-striped'>
    <thead>
        <tr>
            <th>ویژگی</th>
            <th><code>git branch</code></th>
            <th><code>git checkout</code></th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td><strong>هدف</strong></td>
            <td>مدیریت شاخه‌ها (ایجاد، لیست، حذف، تغییر نام و ...)</td>
            <td>سوئیچ کردن بین شاخه‌ها یا بازگرداندن فایل‌های درخت کاری</td>
        </tr>
        <tr>
            <td><strong>ایجاد شاخه</strong></td>
            <td><code>git branch new-branch</code></td>
            <td><code>git checkout -b new-branch</code></td>
        </tr>
        <tr>
            <td><strong>انتقال به شاخه</strong></td>
            <td>ندارد</td>
            <td><code>git checkout branch-name</code></td>
        </tr>
        <tr>
            <td><strong>حذف شاخه</strong></td>
            <td><code>git branch -d branch-name</code></td>
            <td>ندارد</td>
        </tr>
        <tr>
            <td><strong>تغییر نام شاخه</strong></td>
            <td><code>git branch -m old-name new-name</code></td>
            <td>ندارد</td>
        </tr>
        <tr>
            <td><strong>ردیابی شاخه‌های remote</strong></td>
            <td><code>git branch -r</code> (نمایش شاخه‌های remote)</td>
            <td><code>git checkout branch-name</code> (اگر شاخه در حال حاضر در دسترس باشد یا ایجاد یک شاخه ردیابی)</td>
        </tr>
        <tr>
            <td><strong>بازگرداندن فایل‌ها</strong></td>
            <td>ندارد</td>
            <td><code>git checkout -- <file-name></code> (بازگرداندن فایل)</td>
        </tr>
    </tbody>
</table>
<h4>اشتباهات رایج</h4>
<ul>
    <li>سعی در حذف شاخه جاری: نمی‌توانید شاخه‌ای که در حال حاضر روی آن هستید را حذف کنید.</li>
    <li>فراموشی commit یا stash تغییرات: حذف یا force-deleting شاخه‌ها بدون ذخیره‌سازی تغییرات، ممکن است باعث از دست رفتن کارهای غیر commited شود.</li>
    <li>نام اشتباه شاخه‌ها: همیشه نام شاخه‌ای که می‌خواهید استفاده کنید را چک کنید تا از خطاها جلوگیری کنید.</li>
</ul>
<h2>بهترین شیوه‌ها</h2>
<ul>
    <li>قبل از حذف شاخه‌ها، اطمینان حاصل کنید که تغییرات خود را commit یا stash کرده‌اید تا از دست رفتن کار جلوگیری کنید.</li>
    <li>از نام‌های توصیفی برای شاخه‌ها استفاده کنید تا هدف آن‌ها مشخص باشد (مثلاً <code>feature/add-login</code>).</li>
    <li>قبل از force-deleting یک شاخه، مطمئن شوید که تمام تغییرات merge شده یا پشتیبان‌گیری شده‌اند تا از دست رفتن اطلاعات جلوگیری کنید.</li>
    <li>از پرچم‌های <code>--merged</code> و <code>--no-merged</code> برای بررسی شاخه‌های آماده حذف یا نیاز به ادغام استفاده کنید.</li>
</ul>
<h2>محدودیت‌ها</h2>
<ul>
    <li>نمی‌توانید شاخه‌ای که در حال حاضر روی آن هستید را حذف کنید. برای حذف شاخه باید به شاخه دیگری بروید.</li>
    <li>حذف شاخه غیر موجود باعث ایجاد خطا می‌شود.</li>
    <li>حذف اجباری یک شاخه ممکن است باعث از دست رفتن تغییرات غیر merge شده شود، اگر آن‌ها commit یا stash نشده باشند.</li>
</ul>
<h3>نحوه استفاده</h3>
<p>برای استفاده از دستور <code>git branch</code> و گزینه‌های مختلف آن برای ایجاد، حذف یا تغییر نام شاخه‌ها، از مثال‌های زیر استفاده کنید:</p>
<ul>
    <li><code>git branch -d <branch></code>: حذف شاخه مورد نظر، فقط در صورتی که به طور کامل در شاخه فعلی ادغام شده باشد.</li>
    <li><code>git branch -D <branch></code>: حذف اجباری شاخه، حتی اگر تغییرات merge نشده باشد.</li>
    <li><code>git branch -m <old-name> <new-name></code>: تغییر نام یک شاخه موجود به نام جدید.</li>
    <li><code>git branch -a</code>: نمایش تمامی شاخه‌ها، هم محلی و هم remote.</li>
    <li><code>git branch -r</code>: نمایش شاخه‌های remote، مفید برای مشاهده شاخه‌های موجود در مخازن دور.</li>
</ul>
<h2>نمای کلی</h2>
<p>دستور <code>git branch</code> یکی از ابزارهای اصلی در مدیریت شاخه‌ها در گیت است و امکانات متعددی برای ایجاد، حذف و تغییر نام شاخه‌ها به شما می‌دهد. با استفاده از این دستور می‌توانید روند کاری خود را با سازماندهی دقیق‌تری پیش ببرید.</p>";

        public List<GitField> Fields { get; set; } = new List<GitField>
        {
            new GitField { Name="BranchName", LabelEn="Branch Name", LabelFa="نام شاخه", Type="text", PlaceholderEn="new-feature", PlaceholderFa="نام شاخه", IsRequired=false },
            new GitField { Name="Delete", LabelEn="Delete Branch (-d)", LabelFa="حذف شاخه (-d)", Type="checkbox" },
            new GitField { Name="ForceDelete", LabelEn="Force Delete (-D)", LabelFa="حذف اجباری (-D)", Type="checkbox" },
            new GitField { Name="Rename", LabelEn="Rename Branch (-m)", LabelFa="تغییر نام شاخه (-m)", Type="checkbox" },
            new GitField { Name="RenameOld", LabelEn="Old Name", LabelFa="نام قدیمی", Type="text", PlaceholderEn="old-feature", PlaceholderFa="نام قدیمی" },
            new GitField { Name="RenameNew", LabelEn="New Name", LabelFa="نام جدید", Type="text", PlaceholderEn="new-feature", PlaceholderFa="نام جدید" },
            new GitField { Name="AllBranches", LabelEn="Show All (-a)", LabelFa="نمایش همه (-a)", Type="checkbox" },
            new GitField { Name="RemoteBranches", LabelEn="Show Remote (-r)", LabelFa="نمایش remote (-r)", Type="checkbox" },
            new GitField { Name="Verbose", LabelEn="Verbose (-v)", LabelFa="نمایش آخرین کامیت (-v)", Type="checkbox" },
            new GitField { Name="Merged", LabelEn="Show Merged (--merged)", LabelFa="نمایش merge شده (--merged)", Type="checkbox" },
            new GitField { Name="NoMerged", LabelEn="Show Not Merged (--no-merged)", LabelFa="نمایش merge نشده (--no-merged)", Type="checkbox" }
        };
    }
}
