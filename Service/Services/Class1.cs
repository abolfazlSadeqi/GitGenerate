using Core;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public enum GitConceptCategory
    {
        Basic,
        Intermediate,
        Advanced
    }

    public enum Language
    {
        En,
        Fa
    }

    public class GitConcept
    {
        public string Key { get; set; } = "";
        public GitConceptCategory Category { get; set; }
        public Dictionary<Language, string> Title { get; set; }
        public Dictionary<Language, string> Description { get; set; }
    }

    public class GitConceptService : IGitConceptService
    {
        private readonly List<GitConcept> _concepts;

        public GitConceptService()
        {
            _concepts = LoadConcepts();
        }

        public List<GitConcept> GetByCategory(GitConceptCategory category, Language lang)
        {
            // بازگرداندن تمام مفاهیم یک دسته‌بندی
            var concepts = _concepts.FindAll(c => c.Category == category);

            // اطمینان از وجود کلید زبان برای Title و Description
            foreach (var c in concepts)
            {
                if (!c.Title.ContainsKey(lang))
                    c.Title[lang] = c.Title[Language.En];

                if (!c.Description.ContainsKey(lang))
                    c.Description[lang] = c.Description[Language.En];
            }

            return concepts;
        }

        public GitConcept? GetConcept(string key, Language lang)
        {
            var concept = _concepts.Find(c => c.Key == key);
            if (concept == null) return null;

            // اطمینان از وجود کلید زبان
            if (!concept.Title.ContainsKey(lang))
                concept.Title[lang] = concept.Title[Language.En];

            if (!concept.Description.ContainsKey(lang))
                concept.Description[lang] = concept.Description[Language.En];

            return concept;
        }


        private List<GitConcept> LoadConcepts()
        {
            return new List<GitConcept>()
            {
                // -------------------------
                // BASIC (FOUNDATIONS)
                // -------------------------
              new GitConcept {
    Key = "git-directory",
    Category = GitConceptCategory.Basic,
    Title = new() { {Language.En, ".git Directory "}, {Language.Fa, "پوشه .git - ساختار داخلی"} },
    Description = new() {
        {Language.En,
@"<div style=""font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif; line-height: 1.6; color: #333; max-width: 800px; margin: 20px auto; padding: 20px; background-color: #f9f9f9; border-radius: 12px; box-shadow: 0 4px 10px rgba(0,0,0,0.1);"">
  <h2 style=""color: #2c3e50; margin-bottom: 10px;"">.git Directory</h2>
  <p style=""font-size: 16px;"">The <code>.git</code> folder is the heart of any Git repository. It contains all the metadata and object data required for version control.</p>
  <h3 style=""color: #34495e; margin-top: 20px;"">Detailed structure:</h3>
  <ul style=""list-style: none; padding: 0; margin: 0;"">
    <li style=""margin-bottom: 10px;""><code>config</code> : local repository settings (remote URLs, aliases, branches defaults, etc.)</li>
    <li style=""margin-bottom: 10px;""><code>description</code> : short repository description (used by GitWeb or GitLab)</li>
    <li style=""margin-bottom: 10px;""><code>HEAD</code> : current branch or commit pointer</li>
    <li style=""margin-bottom: 10px;""><code>index</code> : staging area cache (binary file)</li>
    <li style=""margin-bottom: 10px;""><code>packed-refs</code> : compressed references if refs grow large</li>
    <li style=""margin-bottom: 10px;""><code>shallow</code> : present in shallow clones</li>
    <li style=""margin-bottom: 10px;""><code>info/exclude</code> : local ignore rules (not committed)</li>
    <li style=""margin-bottom: 10px;""><code>hooks/</code> : client-side hooks (pre-commit, post-commit, pre-push, etc.)</li>
    <li style=""margin-bottom: 10px;""><code>logs/</code> : history of HEAD and refs updates</li>
    <li style=""margin-bottom: 10px;""><code>objects/</code> : stores all Git objects (blobs, trees, commits, tags) keyed by SHA hash</li>
    <li style=""margin-bottom: 10px;""><code>refs/</code> : references (heads, tags, remotes)</li>
  </ul>
</div>
"},
        {Language.Fa,
@"<div style=""font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif; line-height: 1.6; color: #333; max-width: 800px; margin: 20px auto; padding: 20px; background-color: #f4f9f9; border-radius: 12px; box-shadow: 0 4px 10px rgba(0,0,0,0.1); direction: rtl;"">
  <h2 style=""color: #2c3e50; margin-bottom: 10px;"">پوشه .git - ساختار داخلی</h2>
  <p style=""font-size: 16px;"">پوشه <code>.git</code> قلب هر مخزن گیت است و شامل تمام متادیتا و داده‌های لازم برای کنترل نسخه می‌باشد.</p>
  <h3 style=""color: #34495e; margin-top: 20px;"">ساختار دقیق:</h3>
  <ul style=""list-style: none; padding: 0; margin: 0;"">
    <li style=""margin-bottom: 10px;""><code>config</code> : تنظیمات محلی مخزن (آدرس ریموت، alias ها، شاخه‌های پیش‌فرض و ...)</li>
    <li style=""margin-bottom: 10px;""><code>description</code> : توضیح کوتاه ریپو (برای GitWeb یا GitLab)</li>
    <li style=""margin-bottom: 10px;""><code>HEAD</code> : اشاره‌گر شاخه یا کامیت فعلی</li>
    <li style=""margin-bottom: 10px;""><code>index</code> : کش Staging Area (فایل باینری)</li>
    <li style=""margin-bottom: 10px;""><code>packed-refs</code> : رفرنس‌های فشرده در صورت زیاد شدن</li>
    <li style=""margin-bottom: 10px;""><code>shallow</code> : در clone های shallow موجود است</li>
    <li style=""margin-bottom: 10px;""><code>info/exclude</code> : قوانین ignore محلی (کامیت نمی‌شوند)</li>
    <li style=""margin-bottom: 10px;""><code>hooks/</code> : هوک‌های سمت کلاینت (pre-commit, post-commit, pre-push و ...)</li>
    <li style=""margin-bottom: 10px;""><code>logs/</code> : تاریخچه حرکت HEAD و refs</li>
    <li style=""margin-bottom: 10px;""><code>objects/</code> : تمام اشیاء گیت (blob، tree، commit، tag) با کلید هش SHA</li>
    <li style=""margin-bottom: 10px;""><code>refs/</code> : اشاره‌گرها (heads, tags, remotes)</li>
  </ul>
</div>
"}}
},


               new GitConcept {
    Key = "git-objects",
    Category = GitConceptCategory.Basic,
    Title = new() { {Language.En, "Git Objects "}, {Language.Fa, "اشیاء Git - جزئیات"} },
    Description = new() {
        {Language.En,
@"<!-- Git Objects -->
<div style=""font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif; line-height:1.6; color:#333; max-width:800px; margin:20px auto; padding:20px; background-color:#f9f9f9; border-radius:12px; box-shadow:0 4px 10px rgba(0,0,0,0.1);"">
  <h2 style=""color:#2c3e50;"">Git Objects</h2>
  <p>Git has four main object types, and all repository content is made from them:</p>
  <ul>
    <li><strong>Blob</strong>: stores raw file content (no filename, path, permissions, or timestamps)</li>
    <li><strong>Tree</strong>: represents a directory, references blobs and other trees</li>
    <li><strong>Commit</strong>: records a snapshot of the repository, points to tree, contains metadata</li>
    <li><strong>Tag</strong>: named pointers to commits (lightweight or annotated)</li>
  </ul>
</div>
"},
        {Language.Fa,
@"<div style=""font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif; line-height:1.6; color:#333; max-width:800px; margin:20px auto; padding:20px; background-color:#f4f9f9; border-radius:12px; box-shadow:0 4px 10px rgba(0,0,0,0.1); direction:rtl;"">
  <h2 style=""color:#2c3e50;"">اشیاء Git - جزئیات</h2>
  <p>گیت چهار نوع شیء اصلی دارد که تمام محتوا از آنها ساخته شده است:</p>
  <ul>
    <li><strong>Blob</strong>: محتوای خام فایل را ذخیره می‌کند (نام فایل، مسیر، مجوز و زمان ذخیره نمی‌شود)</li>
    <li><strong>Tree</strong>: نماینده یک پوشه است، به blob ها و tree های دیگر اشاره می‌کند</li>
    <li><strong>Commit</strong>: اسنپ‌شاتی از مخزن ثبت می‌کند، به tree اشاره دارد و شامل متادیتا است</li>
    <li><strong>Tag</strong>: اشاره‌گر نام‌دار به کامیت‌ها (سبک یا Annotated)</li>
  </ul>
</div>
"}}
},


             new GitConcept {
    Key = "blob",
    Category = GitConceptCategory.Basic,
    Title = new() { {Language.En, "Blob Object - File Content"}, {Language.Fa, "شیء Blob - محتوای فایل"} },
    Description = new() {
        {Language.En,
@"-<div style=""font-family:'Segoe UI', Tahoma, Geneva, Verdana, sans-serif; line-height:1.6; color:#333; max-width:800px; margin:20px auto; padding:20px; background-color:#f9f9f9; border-radius:12px; box-shadow:0 4px 10px rgba(0,0,0,0.1);"">
  <h2 style=""color:#2c3e50;"">Blob Object - File Content</h2>
  <ul>
    <li>A Blob stores raw file data only (binary or text).</li>
    <li>No metadata is stored: filename, directory, permissions, timestamps are NOT included.</li>
    <li>Identical file contents share the same blob object, saving space.</li>
    <li>Content is addressed by SHA hash.</li>
  </ul>
  <p><strong>Example:</strong> File content: 'Hello World!'<br>SHA1(blob) = e59ff97941044f85df5297e1c302d260b6f8e12a</p>
</div>
"},
        {Language.Fa,
@"<div style=""font-family:'Segoe UI', Tahoma, Geneva, Verdana, sans-serif; line-height:1.6; color:#333; max-width:800px; margin:20px auto; padding:20px; background-color:#f4f9f9; border-radius:12px; box-shadow:0 4px 10px rgba(0,0,0,0.1); direction:rtl;"">
  <h2 style=""color:#2c3e50;"">شیء Blob - محتوای فایل</h2>
  <ul>
    <li>Blob فقط داده خام فایل را ذخیره می‌کند (متنی یا باینری).</li>
    <li>هیچ متادیتایی ذخیره نمی‌شود: نام فایل، مسیر، مجوزها و زمان.</li>
    <li>فایل‌های با محتوای یکسان از همان blob استفاده می‌کنند و فضای ذخیره صرفه‌جویی می‌شود.</li>
    <li>آدرس‌دهی blob با هش SHA انجام می‌شود.</li>
  </ul>
  <p><strong>مثال:</strong> محتوی فایل: 'Hello World!'<br>SHA1(blob) = e59ff97941044f85df5297e1c302d260b6f8e12a</p>
</div>
"}
    }
},


            new GitConcept {
    Key = "tree",
    Category = GitConceptCategory.Basic,
    Title = new() { {Language.En, "Tree Object - Directory Snapshot"}, {Language.Fa, "شیء Tree - اسنپ‌شات پوشه"} },
    Description = new() {
        {Language.En,
@"- <div style=""font-family:'Segoe UI', Tahoma, Geneva, Verdana, sans-serif; line-height:1.6; color:#333; max-width:800px; margin:20px auto; padding:20px; background-color:#f9f9f9; border-radius:12px; box-shadow:0 4px 10px rgba(0,0,0,0.1);"">
  <h2 style=""color:#2c3e50;"">Tree Object - Directory Snapshot</h2>
  <ul>
    <li>A Tree represents a directory in Git.</li>
    <li>Contains entries pointing to blobs (files) or other trees (subdirectories).</li>
    <li>Each entry has SHA hash, object type, name, and file permissions.</li>
    <li>Trees allow Git to reconstruct the complete directory structure for a commit.</li>
  </ul>
  <p><strong>Example:</strong><br>
  100644 blob e59ff97941044f85df5297e1c302d260b6f8e12a README.md<br>
  040000 tree 4b825dc642cb6eb9a060e54bf8d69288fbee4904 src/</p>
</div>
"},
        {Language.Fa,
@"<div style=""font-family:'Segoe UI', Tahoma, Geneva, Verdana, sans-serif; line-height:1.6; color:#333; max-width:800px; margin:20px auto; padding:20px; background-color:#f4f9f9; border-radius:12px; box-shadow:0 4px 10px rgba(0,0,0,0.1); direction:rtl;"">
  <h2 style=""color:#2c3e50;"">شیء Tree - اسنپ‌شات پوشه</h2>
  <ul>
    <li>Tree نماینده یک دایرکتوری است.</li>
    <li>شامل ورودی‌هایی است که به blob یا tree های دیگر اشاره می‌کنند.</li>
    <li>هر ورودی شامل هش SHA، نوع شیء، نام فایل یا پوشه و مجوزهای فایل است.</li>
    <li>Tree ها امکان بازسازی کامل ساختار پوشه‌ها را در هر commit فراهم می‌کنند.</li>
  </ul>
  <p><strong>مثال:</strong><br>
  100644 blob e59ff97941044f85df5297e1c302d260b6f8e12a README.md<br>
  040000 tree 4b825dc642cb6eb9a060e54bf8d69288fbee4904 src/</p>
</div>
"}}
},



new GitConcept {
    Key = "blob-tree-relationship",
    Category = GitConceptCategory.Basic,
    Title = new() { {Language.En, "Blob & Tree Relationship"}, {Language.Fa, "ارتباط Blob و Tree"} },
    Description = new() {
        {Language.En,
@"<ul>
<li>Trees point to blobs to represent files in directories</li>
<li>Trees themselves can point to other trees for subdirectories</li>
<li>Each commit references a single root tree</li>
<li>This design enables efficient storage: identical files share the same blob even in different trees</li>
</ul>
<p><strong>Example diagram:</strong><br/>
root_tree/<br/>
├─ README.md (blob: e59ff97941044f...)<br/>
└─ src/ (tree)<br/>
&nbsp;&nbsp;├─ main.cs (blob: 6f8e12a...)<br/>
&nbsp;&nbsp;└─ utils.cs (blob: 7b2c5f...)</p>"},
        {Language.Fa,
@"<ul>
<li>Tree ها به blob ها اشاره می‌کنند تا فایل‌ها را در پوشه‌ها نشان دهند</li>
<li>Tree ها می‌توانند به tree های دیگر برای زیرپوشه‌ها اشاره کنند</li>
<li>هر commit به یک tree ریشه اشاره دارد</li>
<li>این طراحی باعث ذخیره‌سازی بهینه می‌شود: فایل‌های یکسان حتی در tree های متفاوت یک blob مشترک دارند</li>
</ul>
<p><strong>مثال نموداری:</strong><br/>
root_tree/<br/>
├─ README.md (blob: e59ff97941044f...)<br/>
└─ src/ (tree)<br/>
&nbsp;&nbsp;├─ main.cs (blob: 6f8e12a...)<br/>
&nbsp;&nbsp;└─ utils.cs (blob: 7b2c5f...)</p>"}
} },


             new GitConcept {
    Key = "commit",
    Category = GitConceptCategory.Basic,
    Title = new() { {Language.En, "Commit Object"}, {Language.Fa, "شیء Commit"} },
    Description = new() {
        {Language.En,
@"<ul>
<li>A commit object records a snapshot of the repository</li>
<li>Points to a tree object representing the state of files and directories</li>
<li>Contains metadata: author, committer, date/time, message</li>
<li>May point to parent commits (for merges)</li>
<li>Commits form a Directed Acyclic Graph (DAG)</li>
</ul>
<p><strong>Example:</strong><br/>
Commit SHA: 1fb25c...<br/>
Tree: a3f7e2...<br/>
Parents: e59ff97...<br/>
Author: Alice &lt;alice@example.com&gt;<br/>
Message: 'Initial commit'</p>"},
        {Language.Fa,
@"<ul>
<li>یک commit اسنپ‌شاتی از مخزن ذخیره می‌کند</li>
<li>به یک شیء tree اشاره دارد که وضعیت فایل‌ها و پوشه‌ها را نشان می‌دهد</li>
<li>شامل متادیتا: نویسنده، ثبت‌کننده، تاریخ/زمان، پیام</li>
<li>ممکن است به commit والد اشاره کند (برای merge)</li>
<li>کامیت‌ها گراف جهت‌دار بدون حلقه (DAG) تشکیل می‌دهند</li>
</ul>
<p><strong>مثال:</strong><br/>
SHA کامیت: 1fb25c...<br/>
Tree: a3f7e2...<br/>
والد: e59ff97...<br/>
نویسنده: Alice &lt;alice@example.com&gt;<br/>
پیام: 'Initial commit'</p>"}}
},

new GitConcept {
    Key = "commit-dag",
    Category = GitConceptCategory.Basic,
    Title = new() { {Language.En, "Commit DAG"}, {Language.Fa, "گراف جهت‌دار کامیت‌ها"} },
    Description = new() {
        {Language.En,
@"<ul>
<li>Commits form a Directed Acyclic Graph (DAG)</li>
<li>Each node is a commit; edges point to parent commits</li>
<li>Enables efficient branching and merging</li>
</ul>
<p><strong>Example:</strong><br/>
A (root commit)<br/>
|<br/>
B (child of A)<br/>
|<br/>
C (child of B)<br/>
|\\<br/>
D  E (merge commit of C and F)<br/>
|<br/>
F (child of B on feature branch)</p>"},
        {Language.Fa,
@"<ul>
<li>کامیت‌ها یک گراف جهت‌دار بدون حلقه (DAG) تشکیل می‌دهند</li>
<li>هر گره یک commit است و یال‌ها به commit والد اشاره می‌کنند</li>
<li>امکان branching و merge بهینه را فراهم می‌کند</li>
</ul>
<p><strong>مثال:</strong><br/>
A (کامیت ریشه)<br/>
|<br/>
B (فرزند A)<br/>
|<br/>
C (فرزند B)<br/>
|\\<br/>
D  E (merge commit از C و F)<br/>
|<br/>
F (فرزند B در شاخه feature)</p>"}}
},

new GitConcept {
    Key = "commit-tree-blob-relationship",
    Category = GitConceptCategory.Basic,
    Title = new() { {Language.En, "Commit → Tree → Blob Relationship"}, {Language.Fa, "ارتباط Commit → Tree → Blob"} },
    Description = new() {
        {Language.En,
@"<ul>
<li>A commit points to a root tree which recursively references all files and directories</li>
<li>Trees reference blobs (files) or other trees (subdirectories)</li>
<li>Identical files share the same blob; unchanged directories share the same tree</li>
</ul>
<p><strong>Example:</strong><br/>
Commit SHA: 1fb25c...<br/>
Tree SHA: a3f7e2...<br/>
Files:<br/>
- README.md (blob e59ff97...)<br/>
- src/main.cs (blob 6f8e12...)</p>"},
        {Language.Fa,
@"<ul>
<li>هر commit به یک tree ریشه اشاره دارد که به صورت بازگشتی تمام فایل‌ها و پوشه‌ها را نشان می‌دهد</li>
<li>Tree ها به blob ها یا tree های دیگر اشاره می‌کنند</li>
<li>فایل‌های یکسان همان blob را دارند و پوشه‌های بدون تغییر همان tree را دارند</li>
</ul>
<p><strong>مثال:</strong><br/>
SHA کامیت: 1fb25c...<br/>
SHA tree: a3f7e2...<br/>
فایل‌ها:<br/>
- README.md (blob e59ff97...)<br/>
- src/main.cs (blob 6f8e12...)</p>"}}
},

new GitConcept {
    Key = "tag-objects",
    Category = GitConceptCategory.Basic,
    Title = new() { {Language.En, "Tag Objects"}, {Language.Fa, "شیء Tag"} },
    Description = new() {
        {Language.En,
@"<ul>
<li>Tags are named references to commits</li>
<li>Lightweight tag: simple reference to a commit</li>
<li>Annotated tag: full object, includes tagger info, date, message, optional GPG signature</li>
<li>Tags are immutable and useful for marking releases</li>
</ul>
<p><strong>Example:</strong><br/>
Tag: v1.0<br/>
Points to: Commit SHA 1fb25c...<br/>
Annotated tag message: 'Initial release'</p>"},
        {Language.Fa,
@"<ul>
<li>تگ‌ها اشاره‌گرهای نام‌دار به کامیت‌ها هستند</li>
<li>تگ سبک: اشاره‌گر ساده به یک کامیت</li>
<li>تگ Annotated: شیء کامل شامل اطلاعات تگ‌گذار، تاریخ، پیام و امضای GPG اختیاری</li>
<li>تگ‌ها غیرقابل تغییر و مناسب برای مشخص کردن نسخه‌ها هستند</li>
</ul>
<p><strong>مثال:</strong><br/>
تگ: v1.0<br/>
اشاره به: Commit SHA 1fb25c...<br/>
پیام تگ توضیح‌دار: 'نسخه اولیه'</p>"}}
},

new GitConcept {
    Key = "head-pointer",
    Category = GitConceptCategory.Basic,
    Title = new() { {Language.En, "HEAD Pointer"}, {Language.Fa, "اشاره‌گر HEAD"} },
    Description = new() {
        {Language.En,
@"<ul>
<li>HEAD points to the currently checked-out branch or commit</li>
<li>Normally points to a branch reference: refs/heads/main</li>
<li>Detached HEAD: points directly to a commit SHA</li>
<li>HEAD determines which tree is checked out in the working directory</li>
</ul>
<p><strong>Example:</strong> HEAD → refs/heads/feature/login</p>"},
        {Language.Fa,
@"<ul>
<li>HEAD به شاخه یا کامیت جاری اشاره می‌کند</li>
<li>معمولاً به رفرنس شاخه اشاره می‌کند: refs/heads/main</li>
<li>Detached HEAD: اشاره مستقیم به SHA یک کامیت</li>
<li>HEAD مشخص می‌کند کدام tree در Working Tree بارگذاری شود</li>
</ul>
<p><strong>مثال:</strong> HEAD → refs/heads/feature/login</p>"}}
},

new GitConcept {
    Key = "branches",
    Category = GitConceptCategory.Basic,
    Title = new() { {Language.En, "Branches"}, {Language.Fa, "شاخه‌ها"} },
    Description = new() {
        {Language.En,
@"<ul>
<li>Branches are movable pointers to commits</li>
<li>Stored under .git/refs/heads/</li>
<li>Default branch is usually 'main' or 'master'</li>
<li>Each branch has its own HEAD pointer</li>
<li>Allows parallel development</li>
</ul>
<p><strong>Example:</strong><br/>
main → Commit A → Commit B<br/>
feature/login → Commit A → Commit C → Commit D</p>"},
        {Language.Fa,
@"<ul>
<li>شاخه‌ها اشاره‌گرهای متحرک به کامیت‌ها هستند</li>
<li>در مسیر .git/refs/heads/ ذخیره می‌شوند</li>
<li>شاخه پیش‌فرض معمولاً 'main' یا 'master' است</li>
<li>هر شاخه HEAD مربوط به خودش را دارد</li>
<li>اجازه توسعه موازی را می‌دهد</li>
</ul>
<p><strong>مثال:</strong><br/>
main → Commit A → Commit B<br/>
feature/login → Commit A → Commit C → Commit D</p>"}}
},

new GitConcept {
    Key = "branch-head-relationship",
    Category = GitConceptCategory.Basic,
    Title = new() { {Language.En, "Branch ↔ HEAD Relationship"}, {Language.Fa, "ارتباط شاخه و HEAD"} },
    Description = new() {
        {Language.En,
@"<ul>
<li>HEAD points to the tip of the current branch</li>
<li>Moving HEAD to a new branch automatically updates the working tree</li>
</ul>
<p><strong>Example:</strong><br/>
Checkout feature/login:<br/>
HEAD → refs/heads/feature/login<br/>
Working Tree updated to latest commit of that branch</p>"},
        {Language.Fa,
@"<ul>
<li>HEAD به نوک شاخه جاری اشاره می‌کند</li>
<li>جابه‌جایی HEAD به شاخه جدید، Working Tree را با آخرین کامیت آن شاخه هماهنگ می‌کند</li>
</ul>
<p><strong>مثال:</strong><br/>
Checkout feature/login:<br/>
HEAD → refs/heads/feature/login<br/>
Working Tree با آخرین کامیت آن شاخه به‌روز می‌شود</p>"}}
},

new GitConcept {
    Key = "working-tree",
    Category = GitConceptCategory.Basic,
    Title = new() { {Language.En, "Working Tree / Working Directory"}, {Language.Fa, "Working Tree / دایرکتوری کاری"} },
    Description = new() {
        {Language.En,
@"<ul>
<li>The working tree is your checked-out copy of the repository</li>
<li>Contains files you can edit directly on disk</li>
<li>Changes are not part of Git until staged and committed</li>
<li>Commands like git status and git diff inspect the working tree</li>
</ul>
<p><strong>Example:</strong> Edit README.md in working tree → Git sees it as modified</p>"},
        {Language.Fa,
@"<ul>
<li>Working Tree نسخه چک‌اوت‌شده مخزن روی دیسک است</li>
<li>شامل فایل‌هایی است که می‌توانید مستقیماً ویرایش کنید</li>
<li>تغییرات تا وقتی staged و commit نشوند جزو Git نیستند</li>
<li>دستوراتی مثل git status و git diff وضعیت Working Tree را بررسی می‌کنند</li>
</ul>
<p><strong>مثال:</strong> شما README.md را در Working Tree ویرایش می‌کنید → Git آن را تغییر یافته شناسایی می‌کند</p>"}}
},

new GitConcept {
    Key = "index-staging",
    Category = GitConceptCategory.Basic,
    Title = new() { {Language.En, "Index / Staging Area"}, {Language.Fa, "Index / Staging Area"} },
    Description = new() {
        {Language.En,
@"<ul>
<li>The Index (Staging Area) is an intermediate structure between working tree and repository</li>
<li>Records which changes will go into the next commit</li>
<li>git add stages files; allows partial commits</li>
</ul>
<p>Commands: git add, git reset (unstage), git diff --cached</p>"},
        {Language.Fa,
@"<ul>
<li>ایندکس (Staging Area) یک ساختار میانی بین Working Tree و Repository است</li>
<li>مشخص می‌کند کدام تغییرات وارد کامیت بعدی شوند</li>
<li>با git add فایل‌ها را به ایندکس اضافه می‌کنید؛ امکان کامیت جزئی وجود دارد</li>
</ul>
<p>دستورات مرتبط: git add، git reset (برای unstage)، git diff --cached</p>"}}
},

new GitConcept {
    Key = "three-states",
    Category = GitConceptCategory.Basic,
    Title = new() { {Language.En, "Three States (Modified / Staged / Committed)"}, {Language.Fa, "سه حالت (تغییر، ایندکس شده، کامیت شده)"} },
    Description = new() {
        {Language.En,
@"<ul>
<li>Git tracks files in three states: Modified, Staged, Committed</li>
<li>Understanding this workflow is key to mastering Git</li>
</ul>
<p><strong>Example workflow:</strong> Edit file → git add → git commit</p>"},
        {Language.Fa,
@"<ul>
<li>گیت فایل‌ها را در سه حالت پیگیری می‌کند: تغییر یافته، ایندکس شده، کامیت شده</li>
<li>درک این جریان کاری برای تسلط بر گیت حیاتی است</li>
</ul>
<p><strong>مثال جریان کاری:</strong> ویرایش فایل → git add → git commit</p>"}}
},

new GitConcept {
    Key = "refs",
    Category = GitConceptCategory.Basic,
    Title = new() { {Language.En, "Refs (heads/tags/remotes)"}, {Language.Fa, "Refs (heads/tags/remotes)"} },
    Description = new() {
        {Language.En,
@"<ul>
<li>Refs are pointers to commits stored under .git/refs</li>
<li>Types: heads (branches), tags, remotes</li>
<li>Git uses refs to resolve symbolic names into commit hashes</li>
</ul>
<p>Commands: git show-ref, git update-ref</p>"},
        {Language.Fa,
@"<ul>
<li>Refs اشاره‌گرهایی به کامیت‌ها هستند که در .git/refs ذخیره می‌شوند</li>
<li>انواع: heads (شاخه‌ها)، tags، remotes</li>
<li>گیت از refs برای تبدیل نام‌های نمادین به هش کامیت استفاده می‌کند</li>
</ul>
<p>دستورات مرتبط: git show-ref، git update-ref</p>"}}
},

new GitConcept {
    Key = "head",
    Category = GitConceptCategory.Basic,
    Title = new() { {Language.En, "HEAD pointer"}, {Language.Fa, "اشاره‌گر HEAD"} },
    Description = new() {
        {Language.En,
@"<ul>
<li>HEAD points to the currently checked-out branch or commit</li>
<li>Normally: HEAD → refs/heads/main</li>
<li>Detached HEAD: points directly to a commit SHA</li>
<li>Determines what is in the working tree</li>
</ul>
<p>Commands: git checkout, git switch</p>"},
        {Language.Fa,
@"<ul>
<li>HEAD به شاخه یا کامیت جاری اشاره می‌کند</li>
<li>معمولاً: HEAD → refs/heads/main</li>
<li>Detached HEAD: اشاره مستقیم به SHA یک کامیت</li>
<li>HEAD مشخص می‌کند چه چیزی در Working Tree بارگذاری شود</li>
</ul>
<p>دستورات مرتبط: git checkout، git switch</p>"}}
},

new GitConcept {
    Key = "bare-repository",
    Category = GitConceptCategory.Basic,
    Title = new() { {Language.En, "Bare Repository"}, {Language.Fa, "ریپازیتوری bare"} },
    Description = new() {
        {Language.En,
@"<ul>
<li>Bare repository contains only the .git folder, no working tree</li>
<li>Used as a remote repository for sharing</li>
<li>Cannot edit files directly; only fetch/push</li>
<li>Useful for central repos and CI/CD pipelines</li>
</ul>"},
        {Language.Fa,
@"<ul>
<li>ریپازیتوری bare فقط شامل پوشه .git است و Working Tree ندارد</li>
<li>معمولاً به‌عنوان ریپازیتوری ریموت برای اشتراک‌گذاری استفاده می‌شود</li>
<li>امکان ویرایش مستقیم فایل‌ها وجود ندارد؛ فقط fetch/push</li>
<li>مناسب ریپازیتوری‌های مرکزی و CI/CD</li>
</ul>"}}
},

new GitConcept {
    Key = "gitignore",
    Category = GitConceptCategory.Basic,
    Title = new() { {Language.En, ".gitignore"}, {Language.Fa, ".gitignore"} },
    Description = new() {
        {Language.En,
@"<ul>
<li>.gitignore specifies patterns of files to exclude from tracking</li>
<li>Ignored files remain in working tree but are not staged or committed</li>
<li>Useful for build artifacts, logs, local configs</li>
</ul>
<p>Example patterns:<br/>*.log<br/>bin/<br/>obj/<br/>!important.txt</p>"},
        {Language.Fa,
@"<ul>
<li>.gitignore الگوهایی از فایل‌ها را مشخص می‌کند که نباید ردیابی شوند</li>
<li>فایل‌های نادیده گرفته شده در Working Tree هستند اما staged و commit نمی‌شوند</li>
<li>مناسب فایل‌های build، لاگ‌ها و تنظیمات محلی</li>
</ul>
<p>مثال الگوها:<br/>*.log<br/>bin/<br/>obj/<br/>!important.txt</p>"}}
},

new GitConcept {
    Key = "gitattributes",
    Category = GitConceptCategory.Basic,
    Title = new() { {Language.En, ".gitattributes"}, {Language.Fa, ".gitattributes"} },
    Description = new() {
        {Language.En,
@"<ul>
<li>.gitattributes controls repository behavior for specific paths</li>
<li>Supports end-of-line normalization, custom diff/merge drivers, export settings, GitHub Linguist overrides</li>
</ul>
<p>Example:<br/>*.md text diff=markdown</p>"},
        {Language.Fa,
@"<ul>
<li>.gitattributes رفتار مخزن را برای مسیرهای خاص کنترل می‌کند</li>
<li>قابلیت‌ها: نرمال‌سازی انتهای خط، درایور diff/merge سفارشی، تنظیمات export، تنظیمات Linguist در GitHub</li>
</ul>
<p>مثال:<br/>*.md text diff=markdown</p>"}}
},
new GitConcept {
    Key = "branch",
    Category = GitConceptCategory.Intermediate,
    Title = new() { {Language.En, "Branch (refs/heads/)"}, {Language.Fa, "شاخه (refs/heads/)"} },
    Description = new() {
        {Language.En,
@"<ul>
<li>A branch is a movable ref pointing to a commit.</li>
<li>Represents a line of development; HEAD points to the currently checked-out branch.</li>
<li>Creating a branch (`git branch &lt;name&gt;`) creates a new ref under `refs/heads/`.</li>
<li>Deleting (`git branch -d`) removes the ref.</li>
<li>Example: main → feature/login → bugfix/xyz</li>
<li>Branches allow parallel development without interfering with each other.</li>
</ul>"},
        {Language.Fa,
@"<ul>
<li>شاخه یک ref متحرک است که به یک کامیت اشاره می‌کند.</li>
<li>نماینده یک خط توسعه است؛ HEAD به شاخه جاری اشاره دارد.</li>
<li>ایجاد شاخه (`git branch &lt;name&gt;`) ref جدیدی در `refs/heads/` می‌سازد.</li>
<li>حذف شاخه (`git branch -d`) ref را پاک می‌کند.</li>
<li>مثال: main → feature/login → bugfix/xyz</li>
<li>شاخه‌ها امکان توسعه موازی بدون تداخل با سایر شاخه‌ها را فراهم می‌کنند.</li>
</ul>"}
    }
},

new GitConcept {
    Key = "merge",
    Category = GitConceptCategory.Intermediate,
    Title = new() { {Language.En, "Merge (merge commit / fast-forward)"}, {Language.Fa, "Merge (کامیت ادغام / fast-forward)"} },
    Description = new() {
        {Language.En,
@"<ul>
<li>Merge combines histories of branches.</li>
<li>Fast-forward occurs when the target branch has no divergent commits: branch pointer moves forward.</li>
<li>Otherwise, Git creates a merge commit with multiple parents.</li>
<li>Commands: `git merge &lt;branch&gt;`, `git merge --no-ff`.</li>
<li>Conflicts may arise when changes overlap, requiring manual resolution.</li>
</ul>"},
        {Language.Fa,
@"<ul>
<li>Merge تاریخچه شاخه‌ها را ترکیب می‌کند.</li>
<li>Fast-forward وقتی شاخه هدف تغییر متفاوتی نداشته باشد رخ می‌دهد: اشاره‌گر شاخه فقط جلو می‌رود.</li>
<li>در غیر این صورت، Git یک merge commit با چند والد می‌سازد.</li>
<li>دستورات: `git merge &lt;branch&gt;`، `git merge --no-ff`.</li>
<li>در صورت همپوشانی تغییرات، Conflict رخ می‌دهد که نیاز به حل دستی دارد.</li>
</ul>"}
    }
},

new GitConcept {
    Key = "rebase",
    Category = GitConceptCategory.Intermediate,
    Title = new() { {Language.En, "Rebase (rewrite history)"}, {Language.Fa, "Rebase (بازنویسی تاریخچه)"} },
    Description = new() {
        {Language.En,
@"<ul>
<li>Rebase reapplies commits on top of another base, rewriting history.</li>
<li>Produces a linear history, making logs cleaner.</li>
<li>Command: `git rebase &lt;branch&gt;` moves current branch commits onto the target branch.</li>
<li>Warning: Rebasing shared branches can rewrite history and cause conflicts.</li>
<li>Useful for integrating changes without merge commits.</li>
</ul>"},
        {Language.Fa,
@"<ul>
<li>Rebase کامیت‌ها را روی یک بیس دیگر اعمال می‌کند و تاریخچه را بازنویسی می‌کند.</li>
<li>تاریخچه خطی تولید می‌کند و log تمیزتری ایجاد می‌شود.</li>
<li>دستور: `git rebase &lt;branch&gt;` کامیت‌های شاخه جاری را روی شاخه هدف اعمال می‌کند.</li>
<li>هشدار: Rebase شاخه‌های مشترک تاریخچه را بازنویسی کرده و ممکن است Conflict ایجاد کند.</li>
<li>مفید برای ادغام تغییرات بدون ایجاد merge commit.</li>
</ul>"}
    }
},

new GitConcept {
    Key = "cherry-pick",
    Category = GitConceptCategory.Intermediate,
    Title = new() { {Language.En, "Cherry-pick"}, {Language.Fa, "Cherry-pick"} },
    Description = new() {
        {Language.En,
@"<ul>
<li>Apply the changes introduced by an existing commit onto the current branch as a new commit.</li>
<li>Command: `git cherry-pick &lt;commit&gt;`</li>
<li>Useful for selectively applying bug fixes or features from another branch.</li>
<li>Resolves conflicts similarly to merge if overlapping changes exist.</li>
</ul>"},
        {Language.Fa,
@"<ul>
<li>اعمال تغییرات یک کامیت موجود به شاخه جاری به‌صورت یک کامیت جدید.</li>
<li>دستور: `git cherry-pick &lt;commit&gt;`</li>
<li>مفید برای اعمال انتخابی bug fix یا ویژگی‌ها از شاخه دیگر.</li>
<li>در صورت همپوشانی تغییرات، Conflict مانند merge رخ می‌دهد.</li>
</ul>"}
    }
},

new GitConcept {
    Key = "stash",
    Category = GitConceptCategory.Intermediate,
    Title = new() { {Language.En, "Stash (temporary save)"}, {Language.Fa, "Stash (ذخیره موقت)"} },
    Description = new() {
        {Language.En,
@"<ul>
<li>Stash temporarily shelves changes in a stack for later retrieval.</li>
<li>Command: `git stash` saves changes, `git stash pop` restores them.</li>
<li>Can stash tracked, untracked, and ignored files (with options).</li>
<li>Useful when switching branches without committing incomplete work.</li>
</ul>"},
        {Language.Fa,
@"<ul>
<li>Stash تغییرات را موقتاً در یک پشته ذخیره می‌کند تا بعداً بازیابی شوند.</li>
<li>دستورات: `git stash` ذخیره، `git stash pop` بازیابی.</li>
<li>می‌تواند فایل‌های tracked، untracked و ignored را ذخیره کند (با گزینه‌ها).</li>
<li>مفید هنگام سوئیچ شاخه بدون commit کار ناقص.</li>
</ul>"}
    }
},
new GitConcept {
    Key = "remote",
    Category = GitConceptCategory.Intermediate,
    Title = new() { {Language.En, "Remote (origin, upstream)"}, {Language.Fa, "Remote (origin, upstream)"} },
    Description = new() {
        {Language.En,
@"<ul>
<li>A remote is a named URL pointing to another repository.</li>
<li>Common names: <code>origin</code> (your fork), <code>upstream</code> (original repo).</li>
<li>Commands: <code>git remote -v</code>, <code>git fetch</code>, <code>git push</code>.</li>
<li>Remotes facilitate collaboration and code synchronization.</li>
</ul>"},
        {Language.Fa,
@"<ul>
<li>ریموت نامی است که به URL یک مخزن دیگر اشاره می‌کند.</li>
<li>نام‌های رایج: <code>origin</code> (فورک شما)، <code>upstream</code> (مخزن اصلی).</li>
<li>دستورات: <code>git remote -v</code>، <code>git fetch</code>، <code>git push</code>.</li>
<li>ریموت‌ها برای همکاری و همگام‌سازی کد استفاده می‌شوند.</li>
</ul>"}
    }
},

new GitConcept {
    Key = "tracking-branch",
    Category = GitConceptCategory.Intermediate,
    Title = new() { {Language.En, "Tracking Branch / upstream"}, {Language.Fa, "شاخه ردیابی / upstream"} },
    Description = new() {
        {Language.En,
@"<ul>
<li>A local branch can track a remote branch.</li>
<li>Default upstream branch is used for <code>git pull</code> and <code>git push</code>.</li>
<li>Shows the relationship between local and remote branches.</li>
<li>Commands: <code>git branch -u &lt;remote&gt;/&lt;branch&gt;</code>.</li>
</ul>"},
        {Language.Fa,
@"<ul>
<li>یک شاخه محلی می‌تواند شاخه ریموت را دنبال کند.</li>
<li>شاخه upstream پیش‌فرض برای <code>git pull</code> و <code>git push</code> استفاده می‌شود.</li>
<li>رابطه شاخه محلی و ریموت را نشان می‌دهد.</li>
<li>دستور: <code>git branch -u &lt;remote&gt;/&lt;branch&gt;</code>.</li>
</ul>"}
    }
},

new GitConcept {
    Key = "fetch-vs-pull",
    Category = GitConceptCategory.Intermediate,
    Title = new() { {Language.En, "Fetch vs Pull"}, {Language.Fa, "Fetch در مقابل Pull"} },
    Description = new() {
        {Language.En,
@"<ul>
<li><code>git fetch</code>: downloads commits/objects from remote, does not modify working tree.</li>
<li><code>git pull</code>: fetch + merge (or rebase if configured).</li>
<li>Use fetch to inspect changes before merging.</li>
<li>Use pull for quick integration with remote.</li>
</ul>"},
        {Language.Fa,
@"<ul>
<li><code>git fetch</code>: کامیت‌ها/اشیا را از ریموت دانلود می‌کند، Working Tree تغییر نمی‌کند.</li>
<li><code>git pull</code>: fetch + merge (یا rebase اگر تنظیم شده باشد).</li>
<li>از fetch برای بررسی تغییرات قبل از ادغام استفاده کنید.</li>
<li>از pull برای ادغام سریع با ریموت استفاده کنید.</li>
</ul>"}
    }
},

new GitConcept {
    Key = "push",
    Category = GitConceptCategory.Intermediate,
    Title = new() { {Language.En, "Push (send refs)"}, {Language.Fa, "Push (ارسال رفرنس‌ها)"} },
    Description = new() {
        {Language.En,
@"<ul>
<li>Push sends local branch refs to a remote.</li>
<li>Server-side hooks and permissions may reject pushes.</li>
<li><code>git push --force</code> overwrites remote history (use cautiously).</li>
<li>Commands: <code>git push</code>, <code>git push --set-upstream</code>.</li>
</ul>"},
        {Language.Fa,
@"<ul>
<li>Push رفرنس‌های شاخه محلی را به ریموت می‌فرستد.</li>
<li>هوک‌ها و مجوزهای سرور ممکن است push را رد کنند.</li>
<li><code>git push --force</code> تاریخچه ریموت را بازنویسی می‌کند (با احتیاط استفاده شود).</li>
<li>دستورات: <code>git push</code>، <code>git push --set-upstream</code>.</li>
</ul>"}
    }
},

new GitConcept {
    Key = "merge-conflict",
    Category = GitConceptCategory.Intermediate,
    Title = new() { {Language.En, "Merge Conflict"}, {Language.Fa, "Conflict در هنگام Merge"} },
    Description = new() {
        {Language.En,
@"<ul>
<li>Conflict occurs when Git cannot automatically reconcile changes to the same part of a file.</li>
<li>Requires manual resolution, then <code>git add</code> and <code>git commit</code>.</li>
<li>Use <code>git status</code> and diff tools to inspect conflicting areas.</li>
<li>Common in merges, rebases, or cherry-picks.</li>
</ul>"},
        {Language.Fa,
@"<ul>
<li>Conflict زمانی رخ می‌دهد که Git نتواند تغییرات روی یک ناحیه فایل را به‌صورت خودکار ترکیب کند.</li>
<li>نیاز به حل دستی و سپس <code>git add</code> و <code>git commit</code> دارد.</li>
<li>از <code>git status</code> و ابزارهای diff برای بررسی استفاده کنید.</li>
<li>معمولاً در merge، rebase یا cherry-pick اتفاق می‌افتد.</li>
</ul>"}
    }
},

new GitConcept {
    Key = "reflog",
    Category = GitConceptCategory.Intermediate,
    Title = new() { {Language.En, "Reflog (local history)"}, {Language.Fa, "Reflog (تاریخچه محلی)"} },
    Description = new() {
        {Language.En,
@"<ul>
<li>Reflog records changes to refs locally (HEAD, branches).</li>
<li>Allows recovery of lost commits.</li>
<li>Command: <code>git reflog</code> shows recent movements of refs.</li>
<li>Works even if branch pointers were updated or deleted.</li>
</ul>"},
        {Language.Fa,
@"<ul>
<li>Reflog تغییرات رفرنس‌ها را به‌صورت محلی ثبت می‌کند (HEAD و شاخه‌ها).</li>
<li>امکان بازیابی کامیت‌های از دست رفته را می‌دهد.</li>
<li>دستور: <code>git reflog</code> حرکت‌های اخیر refs را نشان می‌دهد.</li>
<li>حتی اگر شاخه‌ها آپدیت یا حذف شده باشند، مفید است.</li>
</ul>"}
    }
},

new GitConcept {
    Key = "git-sequencer",
    Category = GitConceptCategory.Intermediate,
    Title = new() { {Language.En, "Sequencer (merge/rebase state)"}, {Language.Fa, "Sequencer (حالت merge/rebase)"} },
    Description = new() {
        {Language.En,
@"<ul>
<li>Git uses sequencer state files (<code>MERGE_HEAD</code>, <code>REBASE_HEAD</code>, <code>CHERRY_PICK_HEAD</code>) to track ongoing operations.</li>
<li>Helps recover, continue, or abort in-progress merges or rebases.</li>
<li>Users rarely interact directly; internal mechanism ensures consistency.</li>
</ul>"},
        {Language.Fa,
@"<ul>
<li>Git از فایل‌های حالت sequencer (<code>MERGE_HEAD</code>، <code>REBASE_HEAD</code>، <code>CHERRY_PICK_HEAD</code>) برای ردیابی عملیات در جریان استفاده می‌کند.</li>
<li>امکان ادامه، لغو یا بازیابی merge/rebase را فراهم می‌کند.</li>
<li>کاربران معمولاً مستقیم با آن‌ها کار نمی‌کنند؛ این مکانیزم داخلی اطمینان از سازگاری را تضمین می‌کند.</li>
</ul>"}
    }
},

new GitConcept {
    Key = "bisect",
    Category = GitConceptCategory.Intermediate,
    Title = new() { {Language.En, "Bisect (binary search in history)"}, {Language.Fa, "Bisect (جستجوی دودویی در تاریخچه)"} },
    Description = new() {
        {Language.En,
@"<ul>
<li>Bisect helps find the commit that introduced a bug using binary search.</li>
<li>Commands: <code>git bisect start</code>, <code>git bisect good</code>, <code>git bisect bad</code>.</li>
<li>Git checks out intermediate commits to isolate the problem quickly.</li>
</ul>"},
        {Language.Fa,
@"<ul>
<li>Bisect کمک می‌کند کامیتی که باگ ایجاد کرده را با جستجوی دودویی پیدا کنید.</li>
<li>دستورات: <code>git bisect start</code>، <code>git bisect good</code>، <code>git bisect bad</code>.</li>
<li>Git به‌صورت خودکار کامیت‌های میانی را چک‌اوت می‌کند تا مشکل سریع شناسایی شود.</li>
</ul>"}
    }
},

new GitConcept {
    Key = "blame-annotate",
    Category = GitConceptCategory.Intermediate,
    Title = new() { {Language.En, "Blame / Annotate"}, {Language.Fa, "Blame / Annotate"} },
    Description = new() {
        {Language.En,
@"<ul>
<li><code>git blame</code> shows who last modified each line of a file.</li>
<li>Useful to understand origin of changes or find when a bug was introduced.</li>
<li>Can annotate multiple files, output in various formats.</li>
<li>Command: <code>git blame &lt;file&gt;</code>.</li>
</ul>"},
        {Language.Fa,
@"<ul>
<li><code>git blame</code> هر خط فایل را به کامیتی که آخرین بار تغییر داده نسبت می‌دهد.</li>
<li>برای پیگیری منشأ تغییرات یا زمان ایجاد باگ مفید است.</li>
<li>می‌تواند چند فایل را annotate کند و خروجی‌های مختلف داشته باشد.</li>
<li>دستور: <code>git blame &lt;file&gt;</code>.</li>
</ul>"}
    }
},

new GitConcept {
    Key = "submodule",
    Category = GitConceptCategory.Intermediate,
    Title = new() { {Language.En, "Submodule"}, {Language.Fa, "Submodule"} },
    Description = new() {
        {Language.En,
@"<ul>
<li>Submodules embed another Git repository at a specific commit reference.</li>
<li>Requires explicit update/checkout to move the submodule pointer.</li>
<li>Commands: <code>git submodule add &lt;repo&gt;</code>, <code>git submodule update</code>.</li>
<li>Useful for including libraries or shared components without merging history.</li>
</ul>"},
        {Language.Fa,
@"<ul>
<li>Submodule یک مخزن گیت دیگر را در یک کامیت مشخص قرار می‌دهد.</li>
<li>برای تغییر pointer ساب‌ماژول نیاز به update/checkout جداگانه است.</li>
<li>دستورات: <code>git submodule add &lt;repo&gt;</code>، <code>git submodule update</code>.</li>
<li>برای درج کتابخانه‌ها یا کامپوننت‌های مشترک بدون ادغام تاریخچه مفید است.</li>
</ul>"}
    }
},

new GitConcept {
    Key = "worktree",
    Category = GitConceptCategory.Intermediate,
    Title = new() { {Language.En, "Git Worktree (multiple checkouts)"}, {Language.Fa, "Git Worktree (چند check-out)"} },
    Description = new() {
        {Language.En,
@"<ul>
<li>Worktrees allow multiple working directories attached to the same repository.</li>
<li>Each worktree can check out a different branch.</li>
<li>Useful for parallel development, testing, or building different versions.</li>
<li>Commands: <code>git worktree add &lt;path&gt; &lt;branch&gt;</code>, <code>git worktree list</code>.</li>
</ul>"},
        {Language.Fa,
@"<ul>
<li>Worktree امکان چند دایرکتوری کاری متصل به یک مخزن را می‌دهد.</li>
<li>هر worktree می‌تواند یک شاخه متفاوت چک‌اوت کند.</li>
<li>برای توسعه موازی، تست یا ساخت نسخه‌های مختلف مفید است.</li>
<li>دستورات: <code>git worktree add &lt;path&gt; &lt;branch&gt;</code>، <code>git worktree list</code>.</li>
</ul>"}
    }
},

new GitConcept {
    Key = "sparse-checkout",
    Category = GitConceptCategory.Intermediate,
    Title = new() { {Language.En, "Sparse Checkout"}, {Language.Fa, "Sparse Checkout"} },
    Description = new() {
        {Language.En,
@"<ul>
<li>Sparse-checkout allows the working tree to include only a subset of paths.</li>
<li>Useful for large monorepos to avoid checking out unnecessary files.</li>
<li>Commands: <code>git sparse-checkout init</code>, <code>git sparse-checkout set &lt;folders&gt;</code>.</li>
</ul>"},
        {Language.Fa,
@"<ul>
<li>Sparse-checkout کاری می‌کند که فقط زیرمجموعه‌ای از مسیرها در Working Tree قرار گیرند.</li>
<li>برای monorepo های بزرگ مفید است تا فایل‌های غیرضروری چک‌اوت نشوند.</li>
<li>دستورات: <code>git sparse-checkout init</code>، <code>git sparse-checkout set &lt;folders&gt;</code>.</li>
</ul>"}
    }
},

new GitConcept {
    Key = "loose-objects",
    Category = GitConceptCategory.Intermediate,
    Title = new() { {Language.En, "Loose Objects"}, {Language.Fa, "Loose Objects"} },
    Description = new() {
        {Language.En,
@"<ul>
<li>Loose objects are individual files in <code>.git/objects/</code>, stored compressed and named by SHA-1/256 hash.</li>
<li>Organized by first 2 chars of hash as directory, remaining as filename (e.g., objects/1d/ab...).</li>
<li>Easy to inspect and manipulate manually.</li>
<li>Commonly created during normal commits, merges, or cherry-picks.</li>
<li>Over time, many loose objects may be repacked into packfiles for efficiency.</li>
</ul>"},
        {Language.Fa,
@"<ul>
<li>Loose objects فایل‌های جداگانه در <code>.git/objects/</code> هستند که فشرده شده و با هش SHA-1/256 نام‌گذاری می‌شوند.</li>
<li>بر اساس دو حرف اول هش به‌عنوان دایرکتوری و بقیه هش به‌عنوان نام فایل ذخیره می‌شوند (مثلاً objects/1d/ab...).</li>
<li>می‌توان آن‌ها را دستی بررسی یا تغییر داد.</li>
<li>معمولاً هنگام commit، merge یا cherry-pick ایجاد می‌شوند.</li>
<li>با گذشت زمان، loose object ها به packfile تبدیل می‌شوند تا کارایی افزایش یابد.</li>
</ul>"}
    }
},

new GitConcept {
    Key = "packfile",
    Category = GitConceptCategory.Intermediate,
    Title = new() { {Language.En, "Packfile (pack/.pack)"}, {Language.Fa, "Packfile (pack/.pack)"} },
    Description = new() {
        {Language.En,
@"<ul>
<li>Packfiles store many objects together in a compressed, delta-encoded format.</li>
<li>Saves disk space and speeds up network transfer.</li>
<li>Typically accompanied by <code>.idx</code> index file for fast lookup.</li>
<li>Created automatically by Git during <code>git gc</code> or <code>git repack</code>.</li>
<li>Deltas encode objects relative to similar objects, reducing redundancy.</li>
</ul>"},
        {Language.Fa,
@"<ul>
<li>Packfile بسیاری از اشیا را به‌صورت فشرده و مبتنی بر دلتا ذخیره می‌کند.</li>
<li>باعث صرفه‌جویی در فضای دیسک و سرعت بالاتر انتقال می‌شود.</li>
<li>معمولاً با فایل <code>.idx</code> همراه است برای جستجوی سریع.</li>
<li>به‌صورت خودکار توسط Git هنگام <code>git gc</code> یا <code>git repack</code> ایجاد می‌شود.</li>
<li>دلتاها اشیا را نسبت به اشیای مشابه کدگذاری می‌کنند تا تکرار کاهش یابد.</li>
</ul>"}
    }
},
new GitConcept {
    Key = "remote",
    Category = GitConceptCategory.Intermediate,
    Title = new() { {Language.En, "Remote (origin, upstream)"}, {Language.Fa, "Remote (origin, upstream)"} },
    Description = new() {
        {Language.En,
@"<ul>
<li>A remote is a named URL pointing to another repository.</li>
<li>Common names: <code>origin</code> (your fork), <code>upstream</code> (original repo).</li>
<li>Commands: <code>git remote -v</code>, <code>git fetch</code>, <code>git push</code>.</li>
<li>Remotes facilitate collaboration and code synchronization.</li>
</ul>"},
        {Language.Fa,
@"<ul>
<li>ریموت نامی است که به URL یک مخزن دیگر اشاره می‌کند.</li>
<li>نام‌های رایج: <code>origin</code> (فورک شما)، <code>upstream</code> (مخزن اصلی).</li>
<li>دستورات: <code>git remote -v</code>، <code>git fetch</code>، <code>git push</code>.</li>
<li>ریموت‌ها برای همکاری و همگام‌سازی کد استفاده می‌شوند.</li>
</ul>"}
    }
},

new GitConcept {
    Key = "tracking-branch",
    Category = GitConceptCategory.Intermediate,
    Title = new() { {Language.En, "Tracking Branch / upstream"}, {Language.Fa, "شاخه ردیابی / upstream"} },
    Description = new() {
        {Language.En,
@"<ul>
<li>A local branch can track a remote branch.</li>
<li>Default upstream branch is used for <code>git pull</code> and <code>git push</code>.</li>
<li>Shows the relationship between local and remote branches.</li>
<li>Commands: <code>git branch -u &lt;remote&gt;/&lt;branch&gt;</code>.</li>
</ul>"},
        {Language.Fa,
@"<ul>
<li>یک شاخه محلی می‌تواند شاخه ریموت را دنبال کند.</li>
<li>شاخه upstream پیش‌فرض برای <code>git pull</code> و <code>git push</code> استفاده می‌شود.</li>
<li>رابطه شاخه محلی و ریموت را نشان می‌دهد.</li>
<li>دستور: <code>git branch -u &lt;remote&gt;/&lt;branch&gt;</code>.</li>
</ul>"}
    }
},

new GitConcept {
    Key = "fetch-vs-pull",
    Category = GitConceptCategory.Intermediate,
    Title = new() { {Language.En, "Fetch vs Pull"}, {Language.Fa, "Fetch در مقابل Pull"} },
    Description = new() {
        {Language.En,
@"<ul>
<li><code>git fetch</code>: downloads commits/objects from remote, does not modify working tree.</li>
<li><code>git pull</code>: fetch + merge (or rebase if configured).</li>
<li>Use fetch to inspect changes before merging.</li>
<li>Use pull for quick integration with remote.</li>
</ul>"},
        {Language.Fa,
@"<ul>
<li><code>git fetch</code>: کامیت‌ها/اشیا را از ریموت دانلود می‌کند، Working Tree تغییر نمی‌کند.</li>
<li><code>git pull</code>: fetch + merge (یا rebase اگر تنظیم شده باشد).</li>
<li>از fetch برای بررسی تغییرات قبل از ادغام استفاده کنید.</li>
<li>از pull برای ادغام سریع با ریموت استفاده کنید.</li>
</ul>"}
    }
},

new GitConcept {
    Key = "push",
    Category = GitConceptCategory.Intermediate,
    Title = new() { {Language.En, "Push (send refs)"}, {Language.Fa, "Push (ارسال رفرنس‌ها)"} },
    Description = new() {
        {Language.En,
@"<ul>
<li>Push sends local branch refs to a remote.</li>
<li>Server-side hooks and permissions may reject pushes.</li>
<li><code>git push --force</code> overwrites remote history (use cautiously).</li>
<li>Commands: <code>git push</code>, <code>git push --set-upstream</code>.</li>
</ul>"},
        {Language.Fa,
@"<ul>
<li>Push رفرنس‌های شاخه محلی را به ریموت می‌فرستد.</li>
<li>هوک‌ها و مجوزهای سرور ممکن است push را رد کنند.</li>
<li><code>git push --force</code> تاریخچه ریموت را بازنویسی می‌کند (با احتیاط استفاده شود).</li>
<li>دستورات: <code>git push</code>، <code>git push --set-upstream</code>.</li>
</ul>"}
    }
},

new GitConcept {
    Key = "merge-conflict",
    Category = GitConceptCategory.Intermediate,
    Title = new() { {Language.En, "Merge Conflict"}, {Language.Fa, "Conflict در هنگام Merge"} },
    Description = new() {
        {Language.En,
@"<ul>
<li>Conflict occurs when Git cannot automatically reconcile changes to the same part of a file.</li>
<li>Requires manual resolution, then <code>git add</code> and <code>git commit</code>.</li>
<li>Use <code>git status</code> and diff tools to inspect conflicting areas.</li>
<li>Common in merges, rebases, or cherry-picks.</li>
</ul>"},
        {Language.Fa,
@"<ul>
<li>Conflict زمانی رخ می‌دهد که Git نتواند تغییرات روی یک ناحیه فایل را به‌صورت خودکار ترکیب کند.</li>
<li>نیاز به حل دستی و سپس <code>git add</code> و <code>git commit</code> دارد.</li>
<li>از <code>git status</code> و ابزارهای diff برای بررسی استفاده کنید.</li>
<li>معمولاً در merge، rebase یا cherry-pick اتفاق می‌افتد.</li>
</ul>"}
    }
},

new GitConcept {
    Key = "reflog",
    Category = GitConceptCategory.Intermediate,
    Title = new() { {Language.En, "Reflog (local history)"}, {Language.Fa, "Reflog (تاریخچه محلی)"} },
    Description = new() {
        {Language.En,
@"<ul>
<li>Reflog records changes to refs locally (HEAD, branches).</li>
<li>Allows recovery of lost commits.</li>
<li>Command: <code>git reflog</code> shows recent movements of refs.</li>
<li>Works even if branch pointers were updated or deleted.</li>
</ul>"},
        {Language.Fa,
@"<ul>
<li>Reflog تغییرات رفرنس‌ها را به‌صورت محلی ثبت می‌کند (HEAD و شاخه‌ها).</li>
<li>امکان بازیابی کامیت‌های از دست رفته را می‌دهد.</li>
<li>دستور: <code>git reflog</code> حرکت‌های اخیر refs را نشان می‌دهد.</li>
<li>حتی اگر شاخه‌ها آپدیت یا حذف شده باشند، مفید است.</li>
</ul>"}
    }
},

new GitConcept {
    Key = "git-sequencer",
    Category = GitConceptCategory.Intermediate,
    Title = new() { {Language.En, "Sequencer (merge/rebase state)"}, {Language.Fa, "Sequencer (حالت merge/rebase)"} },
    Description = new() {
        {Language.En,
@"<ul>
<li>Git uses sequencer state files (<code>MERGE_HEAD</code>, <code>REBASE_HEAD</code>, <code>CHERRY_PICK_HEAD</code>) to track ongoing operations.</li>
<li>Helps recover, continue, or abort in-progress merges or rebases.</li>
<li>Users rarely interact directly; internal mechanism ensures consistency.</li>
</ul>"},
        {Language.Fa,
@"<ul>
<li>Git از فایل‌های حالت sequencer (<code>MERGE_HEAD</code>، <code>REBASE_HEAD</code>، <code>CHERRY_PICK_HEAD</code>) برای ردیابی عملیات در جریان استفاده می‌کند.</li>
<li>امکان ادامه، لغو یا بازیابی merge/rebase را فراهم می‌کند.</li>
<li>کاربران معمولاً مستقیم با آن‌ها کار نمی‌کنند؛ این مکانیزم داخلی اطمینان از سازگاری را تضمین می‌کند.</li>
</ul>"}
    }
},

new GitConcept {
    Key = "bisect",
    Category = GitConceptCategory.Intermediate,
    Title = new() { {Language.En, "Bisect (binary search in history)"}, {Language.Fa, "Bisect (جستجوی دودویی در تاریخچه)"} },
    Description = new() {
        {Language.En,
@"<ul>
<li>Bisect helps find the commit that introduced a bug using binary search.</li>
<li>Commands: <code>git bisect start</code>, <code>git bisect good</code>, <code>git bisect bad</code>.</li>
<li>Git checks out intermediate commits to isolate the problem quickly.</li>
</ul>"},
        {Language.Fa,
@"<ul>
<li>Bisect کمک می‌کند کامیتی که باگ ایجاد کرده را با جستجوی دودویی پیدا کنید.</li>
<li>دستورات: <code>git bisect start</code>، <code>git bisect good</code>، <code>git bisect bad</code>.</li>
<li>Git به‌صورت خودکار کامیت‌های میانی را چک‌اوت می‌کند تا مشکل سریع شناسایی شود.</li>
</ul>"}
    }
},

new GitConcept {
    Key = "blame-annotate",
    Category = GitConceptCategory.Intermediate,
    Title = new() { {Language.En, "Blame / Annotate"}, {Language.Fa, "Blame / Annotate"} },
    Description = new() {
        {Language.En,
@"<ul>
<li><code>git blame</code> shows who last modified each line of a file.</li>
<li>Useful to understand origin of changes or find when a bug was introduced.</li>
<li>Can annotate multiple files, output in various formats.</li>
<li>Command: <code>git blame &lt;file&gt;</code>.</li>
</ul>"},
        {Language.Fa,
@"<ul>
<li><code>git blame</code> هر خط فایل را به کامیتی که آخرین بار تغییر داده نسبت می‌دهد.</li>
<li>برای پیگیری منشأ تغییرات یا زمان ایجاد باگ مفید است.</li>
<li>می‌تواند چند فایل را annotate کند و خروجی‌های مختلف داشته باشد.</li>
<li>دستور: <code>git blame &lt;file&gt;</code>.</li>
</ul>"}
    }
},

new GitConcept {
    Key = "submodule",
    Category = GitConceptCategory.Intermediate,
    Title = new() { {Language.En, "Submodule"}, {Language.Fa, "Submodule"} },
    Description = new() {
        {Language.En,
@"<ul>
<li>Submodules embed another Git repository at a specific commit reference.</li>
<li>Requires explicit update/checkout to move the submodule pointer.</li>
<li>Commands: <code>git submodule add &lt;repo&gt;</code>, <code>git submodule update</code>.</li>
<li>Useful for including libraries or shared components without merging history.</li>
</ul>"},
        {Language.Fa,
@"<ul>
<li>Submodule یک مخزن گیت دیگر را در یک کامیت مشخص قرار می‌دهد.</li>
<li>برای تغییر pointer ساب‌ماژول نیاز به update/checkout جداگانه است.</li>
<li>دستورات: <code>git submodule add &lt;repo&gt;</code>، <code>git submodule update</code>.</li>
<li>برای درج کتابخانه‌ها یا کامپوننت‌های مشترک بدون ادغام تاریخچه مفید است.</li>
</ul>"}
    }
},

new GitConcept {
    Key = "worktree",
    Category = GitConceptCategory.Intermediate,
    Title = new() { {Language.En, "Git Worktree (multiple checkouts)"}, {Language.Fa, "Git Worktree (چند check-out)"} },
    Description = new() {
        {Language.En,
@"<ul>
<li>Worktrees allow multiple working directories attached to the same repository.</li>
<li>Each worktree can check out a different branch.</li>
<li>Useful for parallel development, testing, or building different versions.</li>
<li>Commands: <code>git worktree add &lt;path&gt; &lt;branch&gt;</code>, <code>git worktree list</code>.</li>
</ul>"},
        {Language.Fa,
@"<ul>
<li>Worktree امکان چند دایرکتوری کاری متصل به یک مخزن را می‌دهد.</li>
<li>هر worktree می‌تواند یک شاخه متفاوت چک‌اوت کند.</li>
<li>برای توسعه موازی، تست یا ساخت نسخه‌های مختلف مفید است.</li>
<li>دستورات: <code>git worktree add &lt;path&gt; &lt;branch&gt;</code>، <code>git worktree list</code>.</li>
</ul>"}
    }
},

new GitConcept {
    Key = "sparse-checkout",
    Category = GitConceptCategory.Intermediate,
    Title = new() { {Language.En, "Sparse Checkout"}, {Language.Fa, "Sparse Checkout"} },
    Description = new() {
        {Language.En,
@"<ul>
<li>Sparse-checkout allows the working tree to include only a subset of paths.</li>
<li>Useful for large monorepos to avoid checking out unnecessary files.</li>
<li>Commands: <code>git sparse-checkout init</code>, <code>git sparse-checkout set &lt;folders&gt;</code>.</li>
</ul>"},
        {Language.Fa,
@"<ul>
<li>Sparse-checkout کاری می‌کند که فقط زیرمجموعه‌ای از مسیرها در Working Tree قرار گیرند.</li>
<li>برای monorepo های بزرگ مفید است تا فایل‌های غیرضروری چک‌اوت نشوند.</li>
<li>دستورات: <code>git sparse-checkout init</code>، <code>git sparse-checkout set &lt;folders&gt;</code>.</li>
</ul>"}
    }
},

new GitConcept {
    Key = "loose-objects",
    Category = GitConceptCategory.Intermediate,
    Title = new() { {Language.En, "Loose Objects"}, {Language.Fa, "Loose Objects"} },
    Description = new() {
        {Language.En,
@"<ul>
<li>Loose objects are individual files in <code>.git/objects/</code>, stored compressed and named by SHA-1/256 hash.</li>
<li>Organized by first 2 chars of hash as directory, remaining as filename (e.g., objects/1d/ab...).</li>
<li>Easy to inspect and manipulate manually.</li>
<li>Commonly created during normal commits, merges, or cherry-picks.</li>
<li>Over time, many loose objects may be repacked into packfiles for efficiency.</li>
</ul>"},
        {Language.Fa,
@"<ul>
<li>Loose objects فایل‌های جداگانه در <code>.git/objects/</code> هستند که فشرده شده و با هش SHA-1/256 نام‌گذاری می‌شوند.</li>
<li>بر اساس دو حرف اول هش به‌عنوان دایرکتوری و بقیه هش به‌عنوان نام فایل ذخیره می‌شوند (مثلاً objects/1d/ab...).</li>
<li>می‌توان آن‌ها را دستی بررسی یا تغییر داد.</li>
<li>معمولاً هنگام commit، merge یا cherry-pick ایجاد می‌شوند.</li>
<li>با گذشت زمان، loose object ها به packfile تبدیل می‌شوند تا کارایی افزایش یابد.</li>
</ul>"}
    }
},

new GitConcept {
    Key = "packfile",
    Category = GitConceptCategory.Intermediate,
    Title = new() { {Language.En, "Packfile (pack/.pack)"}, {Language.Fa, "Packfile (pack/.pack)"} },
    Description = new() {
        {Language.En,
@"<ul>
<li>Packfiles store many objects together in a compressed, delta-encoded format.</li>
<li>Saves disk space and speeds up network transfer.</li>
<li>Typically accompanied by <code>.idx</code> index file for fast lookup.</li>
<li>Created automatically by Git during <code>git gc</code> or <code>git repack</code>.</li>
<li>Deltas encode objects relative to similar objects, reducing redundancy.</li>
</ul>"},
        {Language.Fa,
@"<ul>
<li>Packfile بسیاری از اشیا را به‌صورت فشرده و مبتنی بر دلتا ذخیره می‌کند.</li>
<li>باعث صرفه‌جویی در فضای دیسک و سرعت بالاتر انتقال می‌شود.</li>
<li>معمولاً با فایل <code>.idx</code> همراه است برای جستجوی سریع.</li>
<li>به‌صورت خودکار توسط Git هنگام <code>git gc</code> یا <code>git repack</code> ایجاد می‌شود.</li>
<li>دلتاها اشیا را نسبت به اشیای مشابه کدگذاری می‌کنند تا تکرار کاهش یابد.</li>
</ul>"}
    }
},

new GitConcept {
    Key = "multi-pack-index",
    Category = GitConceptCategory.Intermediate,
    Title = new() { {Language.En, "Multi-Pack-Index"}, {Language.Fa, "Multi-Pack-Index"} },
    Description = new() {
        {Language.En,
@"<ul>
<li>Multi-Pack-Index (MIDX) is a global index across multiple packfiles.</li>
<li>Accelerates object lookup without scanning all packfiles.</li>
<li>Especially useful for very large repositories with many packfiles.</li>
<li>Git commands like <code>git fsck</code> or <code>git log</code> benefit from MIDX performance.</li>
</ul>"},
        {Language.Fa,
@"<ul>
<li>Multi-Pack-Index (MIDX) ایندکس سراسری روی چند packfile است.</li>
<li>جستجوی اشیا بدون نیاز به اسکن همه packfile ها را سریع می‌کند.</li>
<li>برای مخازن بسیار بزرگ با packfile های متعدد بسیار مفید است.</li>
<li>دستورات Git مثل <code>git fsck</code> یا <code>git log</code> از سرعت آن بهره می‌برند.</li>
</ul>"}
    }
},

new GitConcept {
    Key = "delta-compression",
    Category = GitConceptCategory.Intermediate,
    Title = new() { {Language.En, "Delta Compression"}, {Language.Fa, "Delta Compression"} },
    Description = new() {
        {Language.En,
@"<ul>
<li>Delta compression stores objects as differences (deltas) relative to similar objects.</li>
<li>Reduces repository size significantly.</li>
<li>Common during <code>git repack</code> or fetch/pull of many similar files.</li>
<li>Commands: <code>git repack -a -d --delta</code> can force delta recomputation.</li>
</ul>"},
        {Language.Fa,
@"<ul>
<li>Delta Compression اشیا را به‌صورت تفاوت نسبت به اشیای مشابه ذخیره می‌کند.</li>
<li>حجم مخزن را به‌طور قابل توجهی کاهش می‌دهد.</li>
<li>معمولاً هنگام <code>git repack</code> یا fetch/pull فایل‌های مشابه رخ می‌دهد.</li>
<li>دستور: <code>git repack -a -d --delta</code> می‌تواند بازمحاسبه دلتاها را انجام دهد.</li>
</ul>"}
    }
},

new GitConcept {
    Key = "repack-prune",
    Category = GitConceptCategory.Intermediate,
    Title = new() { {Language.En, "Repack & Prune (git gc)"}, {Language.Fa, "Repack و Prune (git gc)"} },
    Description = new() {
        {Language.En,
@"<ul>
<li><code>git gc</code> performs garbage collection: repacks loose objects into packfiles and prunes unreachable objects.</li>
<li>Reduces disk usage and improves performance.</li>
<li>Can be run manually (<code>git gc --aggressive</code>) for maximum optimization.</li>
<li>Essential for large repositories or frequent commits.</li>
</ul>"},
        {Language.Fa,
@"<ul>
<li><code>git gc</code> عملیات garbage collection را انجام می‌دهد: loose object ها را به packfile تبدیل و اشیاء غیرقابل دسترس را حذف می‌کند.</li>
<li>استفاده از دیسک را کاهش داده و عملکرد را بهبود می‌بخشد.</li>
<li>می‌توان به‌صورت دستی با <code>git gc --aggressive</code> اجرا کرد.</li>
<li>برای مخازن بزرگ یا commit های مکرر ضروری است.</li>
</ul>"}
    }
},

new GitConcept {
    Key = "alternates",
    Category = GitConceptCategory.Intermediate,
    Title = new() { {Language.En, "Alternates (shared object DB)"}, {Language.Fa, "Alternates (پایگاه اشیاء مشترک)"} },
    Description = new() {
        {Language.En,
@"<ul>
<li>Alternates allow a repository to reference objects from another repository.</li>
<li>Saves disk space by sharing object databases (common in clones or CI pipelines).</li>
<li>Configured in <code>.git/objects/info/alternates</code>.</li>
<li>Useful for multiple clones of the same large repository.</li>
</ul>"},
        {Language.Fa,
@"<ul>
<li>Alternates اجازه می‌دهد یک مخزن به اشیا مخزن دیگری اشاره کند.</li>
<li>صرفه‌جویی در فضا با اشتراک پایگاه اشیاء (معمول در clone ها یا CI).</li>
<li>در <code>.git/objects/info/alternates</code> تنظیم می‌شود.</li>
<li>برای چند clone از یک مخزن بزرگ مفید است.</li>
</ul>"}
    }
},

new GitConcept {
    Key = "commit-graph",
    Category = GitConceptCategory.Intermediate,
    Title = new() { {Language.En, "Commit-Graph (accelerates history)"}, {Language.Fa, "Commit-Graph (سرعت‌بخش تاریخچه)"} },
    Description = new() {
        {Language.En,
@"<ul>
<li>Commit-graph files precompute parent/ancestor relationships between commits.</li>
<li>Speeds up operations like <code>git log</code>, <code>git merge-base</code>, and reachability queries.</li>
<li>Generated automatically via <code>git commit-graph write</code> or <code>git gc --write-commit-graph</code>.</li>
<li>Especially helpful in repositories with deep or large commit histories.</li>
</ul>"},
        {Language.Fa,
@"<ul>
<li>فایل‌های commit-graph روابط والد/جد را بین کامیت‌ها پیش‌محاسبه می‌کنند.</li>
<li>عملیات‌هایی مثل <code>git log</code>، <code>git merge-base</code> و پرس‌وجوهای reachability سریع‌تر انجام می‌شوند.</li>
<li>با <code>git commit-graph write</code> یا <code>git gc --write-commit-graph</code> تولید می‌شوند.</li>
<li>در مخازن با تاریخچه عمیق یا زیاد بسیار مفید است.</li>
</ul>"}
    }
},

new GitConcept {
    Key = "index-file-format",
    Category = GitConceptCategory.Intermediate,
    Title = new() { {Language.En, "Index File Format (dircache)"}, {Language.Fa, "قالب فایل ایندکس (dircache)"} },
    Description = new() {
        {Language.En,
@"<ul>
<li>The index (dircache) is a binary file tracking the staging area.</li>
<li>Contains entries, stages (for conflict resolution), timestamps, and optional extensions.</li>
<li>Commands like <code>git update-index</code> manipulate this file.</li>
<li>Understanding the format is helpful for low-level Git operations or debugging index corruption.</li>
</ul>"},
        {Language.Fa,
@"<ul>
<li>ایندکس (dircache) فایل باینری است که Staging Area را دنبال می‌کند.</li>
<li>شامل ورودی‌ها، stage ها (برای حل تعارض)، timestamp و اکستنشن‌های اختیاری است.</li>
<li>دستورات مثل <code>git update-index</code> این فایل را تغییر می‌دهند.</li>
<li>آشنایی با فرمت برای عملیات سطح پایین Git یا اشکال‌زدایی مفید است.</li>
</ul>"}
    }
},

// -------------------------
// ADVANCED (PLUMBING, PROTOCOLS, SECURITY)
// -------------------------
new GitConcept {
    Key = "plumbing-porcelain",
    Category = GitConceptCategory.Advanced,
    Title = new() {
        {Language.En, "Plumbing vs Porcelain"},
        {Language.Fa, "Plumbing در مقابل Porcelain"}
    },
    Description = new() {
        {Language.En,
@"<div><strong>Git provides two layers of commands:</strong></div>
<ul>
<li><strong>Porcelain</strong>: user-friendly high-level commands such as <code>git commit</code>, <code>git push</code>.</li>
<li><strong>Plumbing</strong>: low-level internal commands like <code>git cat-file</code>, <code>git update-index</code> used for scripting and automation.</li>
</ul>"
        },
        {Language.Fa,
@"<div><strong>گیت دو سطح دستور ارائه می‌کند:</strong></div>
<ul>
<li><strong>Porcelain</strong>: دستورات سطح بالا و کاربرپسند مثل <code>git commit</code> و <code>git push</code>.</li>
<li><strong>Plumbing</strong>: دستورات سطح پایین مثل <code>git cat-file</code> و <code>git update-index</code> برای ابزارسازی و اسکریپت‌نویسی.</li>
</ul>"
        }
    }
},
new GitConcept {
    Key = "git-protocols",
    Category = GitConceptCategory.Advanced,
    Title = new() {
        {Language.En, "Transport Protocols (SSH / HTTP / Git)"},
        {Language.Fa, "پروتکل‌های انتقال (SSH / HTTP / Git)"}
    },
    Description = new() {
        {Language.En,
@"<div><strong>Git supports several communication protocols:</strong></div>
<ul>
<li><strong>SSH</strong>: secure, widely used for authenticated push/pull.</li>
<li><strong>HTTPS</strong>: firewall-friendly, supports smart-http negotiation.</li>
<li><strong>Git protocol</strong>: fast but unauthenticated and rarely used publicly.</li>
</ul>"
        },
        {Language.Fa,
@"<div><strong>گیت از چند پروتکل ارتباطی پشتیبانی می‌کند:</strong></div>
<ul>
<li><strong>SSH</strong>: امن و پرکاربرد برای عملیات push/pull.</li>
<li><strong>HTTPS</strong>: سازگار با فایروال و پشتیبان smart-http.</li>
<li><strong>Git protocol</strong>: بسیار سریع اما بدون احراز هویت.</li>
</ul>"
        }
    }
},
new GitConcept {
    Key = "smart-http",
    Category = GitConceptCategory.Advanced,
    Title = new() {
        {Language.En, "Smart HTTP"},
        {Language.Fa, "Smart HTTP"}
    },
    Description = new() {
        {Language.En,
@"<div><strong>Smart HTTP is Git’s optimized HTTP transport layer:</strong></div>
<ul>
<li>Supports negotiation and delta/packfile transfer.</li>
<li>Works behind proxies and CDNs.</li>
<li>Supports authenticated push and pull.</li>
</ul>"
        },
        {Language.Fa,
@"<div><strong>Smart HTTP لایه HTTP بهینه‌شده در گیت است:</strong></div>
<ul>
<li>از negotiation و انتقال packfile پشتیبانی می‌کند.</li>
<li>با پروکسی‌ها و CDN ها سازگار است.</li>
<li>امکان push و pull احراز هویت شده دارد.</li>
</ul>"
        }
    }
},
new GitConcept {
    Key = "git-daemon",
    Category = GitConceptCategory.Advanced,
    Title = new() {
        {Language.En, "git-daemon / upload-pack / receive-pack"},
        {Language.Fa, "git-daemon / upload-pack / receive-pack"}
    },
    Description = new() {
        {Language.En,
@"<div><strong>Git server processes:</strong></div>
<ul>
<li><strong>git-upload-pack</strong>: serves fetch and clone requests.</li>
<li><strong>git-receive-pack</strong>: handles push operations.</li>
<li><strong>git-daemon</strong>: provides unauthenticated <code>git://</code> access.</li>
</ul>"
        },
        {Language.Fa,
@"<div><strong>پردازش‌های سرور گیت:</strong></div>
<ul>
<li><strong>git-upload-pack</strong>: ارائه پاسخ برای fetch و clone.</li>
<li><strong>git-receive-pack</strong>: مدیریت عملیات push.</li>
<li><strong>git-daemon</strong>: ارائه دسترسی بدون احراز هویت با پروتکل <code>git://</code>.</li>
</ul>"
        }
    }
},
new GitConcept {
    Key = "git-lfs",
    Category = GitConceptCategory.Advanced,
    Title = new() {
        {Language.En, "Git LFS (Large File Storage)"},
        {Language.Fa, "Git LFS (ذخیره فایل‌های بزرگ)"}
    },
    Description = new() {
        {Language.En,
@"<div><strong>Git LFS improves handling of large binary files:</strong></div>
<ul>
<li>Stores lightweight pointers inside Git.</li>
<li>Actual file content stored in a separate LFS server.</li>
<li>Prevents repository size bloat.</li>
</ul>"
        },
        {Language.Fa,
@"<div><strong>Git LFS مدیریت فایل‌های باینری بزرگ را بهبود می‌دهد:</strong></div>
<ul>
<li>در گیت فقط یک اشاره‌گر سبک ذخیره می‌شود.</li>
<li>محل ذخیره واقعی فایل در LFS است.</li>
<li>از حجیم شدن مخزن جلوگیری می‌کند.</li>
</ul>"
        }
    }
},
new GitConcept {
    Key = "signed-commits",
    Category = GitConceptCategory.Advanced,
    Title = new() {
        {Language.En, "Signed Commits (GPG/SSH)"},
        {Language.Fa, "کامیت‌های امضا شده (GPG/SSH)"}
    },
    Description = new() {
        {Language.En,
@"<div><strong>Signed commits provide cryptographic trust:</strong></div>
<ul>
<li>Verifies author identity.</li>
<li>Ensures commit integrity.</li>
<li>Supports both GPG and SSH-based signatures.</li>
</ul>"
        },
        {Language.Fa,
@"<div><strong>کامیت‌های امضا شده اعتماد رمزنگاری‌شده فراهم می‌کنند:</strong></div>
<ul>
<li>هویت نویسنده قابل تأیید است.</li>
<li>صحت محتوای کامیت تضمین می‌شود.</li>
<li>از امضاهای GPG و SSH پشتیبانی می‌کند.</li>
</ul>"
        }
    }
},
new GitConcept {
    Key = "signed-tags",
    Category = GitConceptCategory.Advanced,
    Title = new() {
        {Language.En, "Signed Tags"},
        {Language.Fa, "تگ‌های امضا شده"}
    },
    Description = new() {
        {Language.En,
@"<div><strong>Annotated tags can be cryptographically signed:</strong></div>
<ul>
<li>Ensures authenticity of releases.</li>
<li>Guarantees integrity of historical points.</li>
</ul>"
        },
        {Language.Fa,
@"<div><strong>تگ‌های Annotated را می‌توان رمزنگاری کرد:</strong></div>
<ul>
<li>اعتبار نسخه‌های رسمی تضمین می‌شود.</li>
<li>صحت نقاط تاریخچه قابل تأیید است.</li>
</ul>"
        }
    }
},
new GitConcept {
    Key = "fsck",
    Category = GitConceptCategory.Advanced,
    Title = new() {
        {Language.En, "git fsck (integrity check)"},
        {Language.Fa, "git fsck (بررسی یکپارچگی)"}
    },
    Description = new() {
        {Language.En,
@"<div><strong>git fsck validates repository integrity:</strong></div>
<ul>
<li>Checks object connectivity.</li>
<li>Detects corrupted or missing objects.</li>
<li>Useful for repository repair.</li>
</ul>"
        },
        {Language.Fa,
@"<div><strong>git fsck یکپارچگی مخزن را بررسی می‌کند:</strong></div>
<ul>
<li>اتصال اشیا را بررسی می‌کند.</li>
<li>خرابی یا اشیای گم‌شده را تشخیص می‌دهد.</li>
<li>برای تعمیر مخزن مفید است.</li>
</ul>"
        }
    }
},
new GitConcept {
    Key = "gc-auto",
    Category = GitConceptCategory.Advanced,
    Title = new() {
        {Language.En, "Auto GC & maintenance"},
        {Language.Fa, "GC خودکار و نگهداری"}
    },
    Description = new() {
        {Language.En,
@"<div><strong>Git performs background maintenance:</strong></div>
<ul>
<li>Automatic repack and prune.</li>
<li>Commit-graph optimizations.</li>
<li>Manual <code>git gc</code> enables deeper cleanup.</li>
</ul>"
        },
        {Language.Fa,
@"<div><strong>گیت به‌صورت پشت‌صحنه عملیات نگهداری انجام می‌دهد:</strong></div>
<ul>
<li>اجرای خودکار repack و prune.</li>
<li>بهینه‌سازی commit-graph.</li>
<li><code>git gc</code> دستی پاکسازی عمیق‌تر انجام می‌دهد.</li>
</ul>"
        }
    }
},
new GitConcept {
    Key = "object-format",
    Category = GitConceptCategory.Advanced,
    Title = new() {
        {Language.En, "Object Format & zlib compression"},
        {Language.Fa, "فرمت اشیاء و فشرده‌سازی zlib"}
    },
    Description = new() {
        {Language.En,
@"<div><strong>Git object structure:</strong></div>
<ul>
<li>Objects contain a header (type + size).</li>
<li>Body compressed using <strong>zlib</strong>.</li>
<li>Used for blobs, trees, commits, and tags.</li>
</ul>"
        },
        {Language.Fa,
@"<div><strong>ساختار اشیای گیت:</strong></div>
<ul>
<li>دارای هدر شامل نوع و اندازه است.</li>
<li>بدنه با <strong>zlib</strong> فشرده می‌شود.</li>
<li>برای blob، tree، commit و tag استفاده می‌شود.</li>
</ul>"
        }
    }
},
new GitConcept {
    Key = "sha1-sha256",
    Category = GitConceptCategory.Advanced,
    Title = new() {
        {Language.En, "Hashing: SHA-1 vs SHA-256"},
        {Language.Fa, "هش: SHA-1 در مقابل SHA-256"}
    },
    Description = new() {
        {Language.En,
@"<div><strong>Git hash algorithm evolution:</strong></div>
<ul>
<li>Historically used SHA-1 for object naming.</li>
<li>Modern Git supports SHA-256 for stronger security.</li>
<li>Reduces hash collision risks.</li>
</ul>"
        },
        {Language.Fa,
@"<div><strong>تکامل الگوریتم هش در گیت:</strong></div>
<ul>
<li>در ابتدا از SHA-1 برای نامگذاری اشیا استفاده می‌شد.</li>
<li>نسخه‌های جدید از SHA-256 پشتیبانی می‌کنند.</li>
<li>خطر برخورد هش کاهش می‌یابد.</li>
</ul>"
        }
    }
},
new GitConcept {
    Key = "hooks",
    Category = GitConceptCategory.Advanced,
    Title = new() {
        {Language.En, "Hooks (pre-commit, pre-push, receive)"},
        {Language.Fa, "هوک‌ها (pre-commit, pre-push, receive)"}
    },
    Description = new() {
        {Language.En,
@"<div><strong>Hooks automate workflows:</strong></div>
<ul>
<li>Run scripts before commit or push.</li>
<li>Enforce quality policies.</li>
<li>Integrate with CI/CD pipelines.</li>
</ul>"
        },
        {Language.Fa,
@"<div><strong>هوک‌ها فرایندها را خودکار می‌کنند:</strong></div>
<ul>
<li>اسکریپت‌ها قبل از commit و push اجرا می‌شوند.</li>
<li>قوانین کیفیت اعمال می‌شوند.</li>
<li>با CI/CD یکپارچه می‌شوند.</li>
</ul>"
        }
    }
},
new GitConcept {
    Key = "receive-hooks",
    Category = GitConceptCategory.Advanced,
    Title = new() {
        {Language.En, "Server-side hooks & access control"},
        {Language.Fa, "هوک‌های سمت سرور و کنترل دسترسی"}
    },
    Description = new() {
        {Language.En,
@"<div><strong>Server-side validation:</strong></div>
<ul>
<li>pre-receive: validates incoming pushes.</li>
<li>update: checks branch updates.</li>
<li>post-receive: triggers deployments and automation.</li>
</ul>"
        },
        {Language.Fa,
@"<div><strong>اعتبارسنجی سمت سرور:</strong></div>
<ul>
<li>pre-receive: بررسی push های ورودی.</li>
<li>update: کنترل بروزرسانی شاخه‌ها.</li>
<li>post-receive: اجرای استقرار و اتوماسیون.</li>
</ul>"
        }
    }
},
new GitConcept {
    Key = "mailmap",
    Category = GitConceptCategory.Advanced,
    Title = new() {
        {Language.En, "Mailmap"},
        {Language.Fa, "Mailmap"}
    },
    Description = new() {
        {Language.En,
@"<div><strong>Mailmap ensures clean author attribution:</strong></div>
<ul>
<li>Unifies duplicate emails.</li>
<li>Normalizes author/committer names.</li>
<li>Improves output of tools like <code>git shortlog</code>.</li>
</ul>"
        },
        {Language.Fa,
@"<div><strong>Mailmap باعث یکپارچگی نام و ایمیل نویسندگان می‌شود:</strong></div>
<ul>
<li>ایمیل‌های تکراری را یکی می‌کند.</li>
<li>نام و ایمیل نویسنده/ثبت‌کننده را اصلاح می‌کند.</li>
<li>خروجی ابزارهایی مثل <code>git shortlog</code> را بهبود می‌دهد.</li>
</ul>"
        }
    }
},

                // --- Add any other items you'd like to expand on later ---
            };
        }
    }
}
