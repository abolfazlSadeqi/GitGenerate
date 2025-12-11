namespace Core;

public class GitInternalsModel
{
    public string TitleEn => "Git Internals: How Git Really Works (Deep Dive)";
    public string TitleFa => "داخلی‌های Git: Git چگونه واقعاً کار می‌کند (تحلیل عمیق)";

    public List<GitTab> Tabs { get; set; } = new List<GitTab>
    {
        new GitTab
        {
            Id = "architecture",
            TitleEn = "Architecture",
            TitleFa = "معماری Git",
            ContentEn = @"
<h3>Working Directory (WD)</h3>
<p>The Working Directory contains your project's files as you currently see them. Changes here are untracked or modified until staged.</p>
<ul>
<li>Untracked files vs Modified files detection</li>
<li>Filesystem metadata (permissions, timestamps, symlinks) affects change detection</li>
<li><code>git status</code> inspects WD vs Index vs HEAD</li>
</ul>

<h3>Staging Area (Index)</h3>
<p>The Index is a binary file (.git/index) acting as an intermediate stage between WD and repository. It records:</p>
<ul>
<li>Path</li>
<li>SHA-1 blob hash</li>
<li>File mode</li>
<li>Stage numbers (for merge conflicts)</li>
<li>Partial staging capability (<code>git add -p</code>)</li>
</ul>

<h3>Repository (.git)</h3>
<p>The repository stores all historical data:</p>
<ul>
<li>Object database (blobs, trees, commits, tags)</li>
<li>References: branches, tags, remotes</li>
<li>HEAD pointer</li>
<li>Hooks: pre-commit, post-commit, pre-push, etc.</li>
<li>Logs: reflog, HEAD movement tracking</li>
</ul>
",
            ContentFa = @"
<h3>Working Directory (WD)</h3>
<p>محل کاری پروژه که تغییرات فعلی شما در آن است. تغییرات تا زمان Stage شدن ثبت نمی‌شوند.</p>
<ul>
<li>تشخیص فایل‌های جدید و تغییر یافته</li>
<li>متادیتای فایل‌ها (مجوزها، زمان‌ها، لینک‌های سمبولیک) بر تشخیص تغییرات اثر می‌گذارد</li>
<li><code>git status</code> مقایسه WD با Index و HEAD را انجام می‌دهد</li>
</ul>

<h3>Staging Area (Index)</h3>
<p>Index یک فایل باینری (.git/index) است که به عنوان لایه میانی بین WD و repository عمل می‌کند:</p>
<ul>
<li>مسیر فایل‌ها</li>
<li>SHA-1 blob hash</li>
<li>حالت فایل</li>
<li>شماره stage برای conflictها</li>
<li>امکان Stage جزئی با <code>git add -p</code></li>
</ul>

<h3>Repository (.git)</h3>
<p>شامل تمامی داده‌های تاریخی پروژه است:</p>
<ul>
<li>Database objectها (blob, tree, commit, tag)</li>
<li>References: branchها، tagها، remoteها</li>
<li>HEAD pointer</li>
<li>Hooks: pre-commit، post-commit، pre-push و غیره</li>
<li>Logs: reflog، پیگیری حرکت HEAD</li>
</ul>"
        },
        new GitTab
        {
            Id = "objects",
            TitleEn = "Git Objects",
            TitleFa = "Objectهای Git",
            ContentEn = @"
<h3>Blob</h3>
<p>Stores raw file content. Identified by SHA-1. Deduplicated across commits.</p>

<h3>Tree</h3>
<p>Represents directories. Maps path → mode → SHA-1 of blob or sub-tree. Enables hierarchical project snapshots.</p>

<h3>Commit</h3>
<p>Captures a snapshot of the project:</p>
<ul>
<li>Tree hash</li>
<li>Parent commit(s)</li>
<li>Author and committer info</li>
<li>Commit message</li>
<li>GPG signature (optional)</li>
</ul>

<h3>Tag</h3>
<p>Human-readable reference to a commit. Can be lightweight or annotated with metadata and signatures.</p>

<h3>Refs & HEAD</h3>
<ul>
<li>HEAD points to current branch or commit</li>
<li>Branches in .git/refs/heads</li>
<li>Remote-tracking branches in .git/refs/remotes</li>
<li>Symbolic vs direct refs</li>
</ul>
",
            ContentFa = @"
<h3>Blob</h3>
<p>ذخیره محتوای فایل‌ها بدون نام و مسیر. با SHA-1 شناسایی می‌شود و در commitهای مختلف تکراری ذخیره نمی‌شود.</p>

<h3>Tree</h3>
<p>نماینده دایرکتوری است. مسیر → حالت → SHA-1 blob یا sub-tree را نگه می‌دارد و امکان snapshot سلسله‌مراتبی پروژه را فراهم می‌کند.</p>

<h3>Commit</h3>
<p>Snapshot پروژه شامل:</p>
<ul>
<li>Tree hash</li>
<li>Parent commit(s)</li>
<li>اطلاعات نویسنده و committer</li>
<li>پیام commit</li>
<li>امضای GPG (اختیاری)</li>
</ul>

<h3>Tag</h3>
<p>اشاره‌گر انسانی به commit. می‌تواند lightweight یا annotated با metadata و امضا باشد.</p>

<h3>Refs & HEAD</h3>
<ul>
<li>HEAD اشاره‌گر branch یا commit فعلی است</li>
<li>Branchها در .git/refs/heads ذخیره می‌شوند</li>
<li>Remote-tracking branchها در .git/refs/remotes</li>
<li>Symbolic vs direct refs</li>
</ul>"
        },
        new GitTab
        {
            Id = "storage",
            TitleEn = "Storage & Hashing",
            TitleFa = "ذخیره‌سازی و هش",
            ContentEn = @"
<h3>Content-Addressable Storage</h3>
<p>Every object identified by SHA-1 (SHA-256 in future). Ensures integrity and avoids duplication.</p>

<h3>Loose Objects</h3>
<p>Individual objects stored under .git/objects/<code>xx/yyyy...</code>, zlib compressed.</p>

<h3>Packfiles & Delta Compression</h3>
<p>Aggregates similar objects, compresses deltas, reduces disk usage, and optimizes network transfer.</p>

<h3>Integrity Checks</h3>
<p>SHA ensures that any modification alters object ID. Verified via <code>git fsck</code>.</p>

<h3>Advanced Storage Concepts</h3>
<ul>
<li>Object reuse across commits</li>
<li>Delta chains in packfiles for efficient storage</li>
<li>Shallow clone implications on missing objects</li>
</ul>
",
            ContentFa = @"
<h3>ذخیره‌سازی بر اساس محتوا</h3>
<p>هر object با SHA-1 (در آینده SHA-256) شناسایی می‌شود. صحت داده‌ها تضمین می‌شود و تکرار جلوگیری می‌شود.</p>

<h3>Loose Objects</h3>
<p>Objectها به صورت منفرد در .git/objects/<code>xx/yyyy</code> ذخیره می‌شوند و zlib compressed هستند.</p>

<h3>Packfiles و Delta Compression</h3>
<p>Objectهای مشابه در packfileها جمع شده، با delta فشرده می‌شوند، فضای دیسک کاهش می‌یابد و انتقال شبکه بهینه می‌شود.</p>

<h3>بررسی صحت (Integrity)</h3>
<p>SHA تضمین می‌کند که کوچکترین تغییر باعث تغییر ID object می‌شود. با <code>git fsck</code> بررسی می‌شود.</p>

<h3>مفاهیم پیشرفته ذخیره‌سازی</h3>
<ul>
<li>بازاستفاده از objectها در commitهای مختلف</li>
<li>Delta chains در packfileها برای ذخیره بهینه</li>
<li>Shallow clone و اثر آن بر objectهای گمشده</li>
</ul>"
        },
        new GitTab
        {
            Id = "commit",
            TitleEn = "Commit & DAG",
            TitleFa = "Commit و DAG",
            ContentEn = @"
<h3>Commit Construction</h3>
<p>Stage → Blob → Tree → Commit → Branch update. Includes metadata and parent references.</p>

<h3>Directed Acyclic Graph (DAG)</h3>
<p>Commits form a DAG. Merge commits have multiple parents. Branch pointers move with new commits.</p>

<h3>Example Commit Object</h3>
<pre>
Commit = {
  tree: SHA-1(TreeRoot),
  parents: [SHA-1(Parent1), SHA-1(Parent2)],
  author: 'Abolfazl',
  committer: 'Abolfazl',
  message: 'Add new feature',
  gpgsig: 'optional'
}
</pre>

<h3>Rebase & History Rewrite</h3>
<p>Linearizes commit history. Be cautious: rewriting shared history may break collaboration.</p>

<h3>Reflog & Recovery</h3>
<p>Tracks branch movements, allows rollback, stash recovery, orphan commit recovery.</p>
",
            ContentFa = @"
<h3>ساخت Commit</h3>
<p>Stage → Blob → Tree → Commit → بروزرسانی branch pointer. شامل metadata و والدین commit.</p>

<h3>DAG (Commit Graph)</h3>
<p>Commitها یک DAG تشکیل می‌دهند. Merge commit دارای چند والد است. اشاره‌گر branch با commit جدید حرکت می‌کند.</p>

<h3>مثال Commit Object</h3>
<pre>
Commit = {
  tree: SHA-1(TreeRoot),
  parents: [SHA-1(Parent1), SHA-1(Parent2)],
  author: 'Abolfazl',
  committer: 'Abolfazl',
  message: 'Add new feature',
  gpgsig: 'اختیاری'
}
</pre>

<h3>Rebase و بازنویسی تاریخچه</h3>
<p>برای خطی کردن تاریخچه commit استفاده می‌شود. توجه کنید: بازنویسی تاریخچه مشترک ممکن است collaboration را خراب کند.</p>

<h3>Reflog و بازیابی</h3>
<p>حرکت branchها را ثبت می‌کند، امکان rollback و recovery commitهای orphan یا stash وجود دارد.</p>"
        },
        new GitTab
        {
            Id = "advanced",
            TitleEn = "Advanced Features & Best Practices",
            TitleFa = "ویژگی‌های پیشرفته و بهترین شیوه‌ها",
            ContentEn = @"
<h3>Hooks & Automation</h3>
<p>Integrate pre-commit, post-commit, pre-push scripts to enforce quality, run tests, and automate workflows.</p>

<h3>Large File Handling (Git LFS)</h3>
<p>Store large files externally, replace with pointers, reduce repo size, optimize network transfer.</p>

<h3>Integrity & Repair</h3>
<p>Use <code>git fsck</code> to verify object integrity. Recover objects by hash, restore corrupted repository.</p>

<h3>Professional Recommendations</h3>
<ul>
<li>Atomic, logically grouped commits</li>
<li>Branch-based workflows for features, releases</li>
<li>Annotated tags for releases</li>
<li>Small, incremental commits for traceability</li>
<li>Back up before rebase or force push</li>
<li>Use shallow clone for large repos</li>
</ul>

<h3>Performance Insights</h3>
<p>Delta compression, packfile optimization, shallow/sparse clone, partial checkout for large repos.</p>
",
            ContentFa = @"
<h3>Hooks و اتوماسیون</h3>
<p>استفاده از pre-commit، post-commit، pre-push برای اعمال قوانین کیفیت، اجرای تست‌ها و اتوماسیون workflow.</p>

<h3>مدیریت فایل‌های بزرگ (Git LFS)</h3>
<p>فایل‌های بزرگ در خارج از repository ذخیره می‌شوند و در repo با pointer جایگزین می‌شوند. اندازه repo کاهش یافته و انتقال شبکه بهینه می‌شود.</p>

<h3>Integrity و بازیابی</h3>
<p>با <code>git fsck</code> صحت objectها بررسی می‌شود. بازسازی repository از object hash ممکن است.</p>

<h3>توصیه‌های حرفه‌ای</h3>
<ul>
<li>Commitهای اتمیک و منطقی</li>
<li>Workflow شاخه‌ای برای ویژگی‌ها و releaseها</li>
<li>Tagهای annotated برای releaseها</li>
<li>Commitهای کوچک و incremental برای traceability</li>
<li>پشتیبان‌گیری قبل از rebase یا force push</li>
<li>Shallow clone برای repoهای بزرگ</li>
</ul>

<h3>نکات عملکردی</h3>
<p>Delta compression، بهینه‌سازی packfile، shallow/sparse clone و partial checkout برای repoهای بزرگ.</p>"
        }
    };
}
