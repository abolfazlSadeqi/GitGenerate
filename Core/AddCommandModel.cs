using System;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.Text.RegularExpressions;
using System.Threading.Channels;
using System.Xml;

namespace Core;

public class AddCommandModel
{
    public string TitleEn => "Add Files";
    public string TitleFa => "اضافه کردن فایل‌ها";

    public string GuideHtmlEn => @"
<h2>Overview</h2>
<p>
The <code>git add</code> command is one of the most fundamental commands in Git. It allows you to move changes from the 
<strong>working directory</strong> to the <strong>staging area</strong>, essentially allowing you to decide what will be 
included in the next commit. This step is crucial in a project where you need precise control over the changes you want to commit.
</p>

<h3>What git add Actually Does</h3>
<ul>
<li>Starts tracking newly created files that weren't previously tracked by Git</li>
<li>Stages modifications made to files that are already tracked</li>
<li>Stages deletions of files that were previously tracked by Git</li>
<li>Lets you selectively choose which changes will be included in the next commit</li>
<li>Supports partial staging of changes using interactive mode (<code>-p</code>)</li>
</ul>

<h3>How to Use git add</h3>
<pre>git add [options] [file...]</pre>

<h3>Common Use Cases</h3>
<ul>
<li><strong>Stage specific files</strong> for commit without adding everything (example: <code>git add file1.txt</code>)</li>
<li><strong>Prepare the entire codebase</strong> for commit using <code>-A</code> or <code>.</code></li>
<li><strong>Check what will be added</strong> using dry-run (<code>-n</code>)</li>
<li><strong>Mark a file to be added later without including its content</strong> using <code>--intent-to-add</code></li>
<li><strong>Stage partial changes in a file</strong> using <code>git add -p</code></li>
</ul>

<h3>Examples</h3>
<pre>
# Add a single file
git add file1.txt

# Add multiple files
git add file1.txt file2.txt

# Add all changes (new, modified, deletions)
git add -A

# Add all changes in the current directory
git add .

# Interactive staging (choose hunks)
git add -p

# Show what would be added (dry run)
git add -n

# Add file but don't stage content (just the intent)
git add --intent-to-add bigFile.zip
</pre>

<h3>Advanced Examples</h3>
<pre>
# Add all C# files in a folder
git add src/**/*.cs

# Force add an ignored file (dangerous!)
git add -f logs/debug.log

# Add modified files, ignoring deletions
git add --ignore-removal .

# Handle files with spaces in their names
git add ""My File.txt""
</pre>

<h2>Comparison: git add vs git commit</h2>
  <table border = '1' cellpadding= '6' style= 'border-collapse:collapse;width:100%;'>
  < tr>
  < th> Feature </ th>< th> git add</th><th>git commit</th>
</tr>
<tr>
<td>Purpose</td>
  <td>Moves changes to staging area</td>
  <td>Saves staged changes to history</td>
  </tr>
<tr>
<td>Modifies Working Directory?</td>
<td>No</td>
  <td>No</td>
  </tr>
<tr>
<td>Modifies Staging Area?</td>
<td>Yes</td>
  <td>No</td>
  </tr>
<tr>
<td>Creates a snapshot?</td>
<td>No</td>
  <td>Yes</td>
  </tr>
<tr>
<td>Selective control?</td>
<td>Very high (add only what you want)</td>
<td>Commits everything staged</td>
</tr>
</table>

<h3>In Simple Terms:</h3>
<p>
<code>git add</code> decides<strong> what</strong> will be committed, while <code>git commit</code> decides<strong> when</strong> it is saved.
</p>

<h2>Common Mistakes</h2>
<ul>
<li><strong>Using git add -A without checking</strong> — may stage unwanted deletions</li>
<li><strong>Forgetting to stage new files</strong> — Git commits only staged items</li>
<li><strong>Assuming git add commits automatically</strong> — it does not</li>
<li><strong>Force adding ignored files</strong> — without understanding why they were ignored</li>
<li><strong>Staging large binary files</strong> — use<code> git add -n</code> first to preview changes</li>
<li><strong>Using git add.</strong> in the wrong directory — staging unwanted files</li>
</ul>

<h2>Best Practices</h2>
<ul>
<li>Use<code> git add -p</code> to stage specific changes (fine-grained control)</li>
<li>Group logically related changes in the same commit</li>
<li>Avoid committing build files, generated content, and sensitive files</li>
<li>Always review what is staged before committing using <code>git status</code></li>
<li>Use<code>.gitignore</code> to prevent unnecessary files from being staged</li>
<li>Make small, meaningful commits to improve traceability</li>
</ul>

<h2>Limitations</h2>
<ul>
<li>Ignored files need<code>-f</code> to be staged</li>
<li>Dry-run (<code>-n</code>) does not modify the staging area</li>
<li><code>--intent-to-add</code> only records the intent to add the file later</li>
<li>Files must exist in the working directory (unless using <code>--intent-to-add</code>)</li>
</ul>
";


   public string GuideHtmlFa => @"
<h2>نمای کلی</h2>
<p>
دستور <code>git add</code> یکی از مهم‌ترین بخش‌های گردش کار Git است. این دستور تغییرات را از 
<strong>working directory</strong> به <strong>staging area</strong> منتقل می‌کند و به شما اجازه می‌دهد 
دقیقاً مشخص کنید چه چیز باید در commit بعدی ذخیره شود. این کار باعث ایجاد یک تاریخچه تمیز، قابل فهم و قابل نگهداری می‌شود.
</p>

<h3>git add دقیقاً چه می‌کند؟</h3>
<ul>
<li>فایل‌های جدید را به حالت ردیابی (track) اضافه می‌کند</li>
<li>تغییرات فایل‌های اصلاح‌شده را stage می‌کند</li>
<li>حذف فایل‌ها را stage می‌کند</li>
<li>امکان انتخاب دقیق تغییرات برای commit را فراهم می‌کند</li>
<li>قابلیت stage کردن تکه‌ای تغییرات با <code>-p</code></li>
</ul>

<h3>نحوه استفاده</h3>
<pre dir=""rtl"">

git add [گزینه‌ها] [فایل...]<</pre>


<h3>موارد کاربرد رایج</h3>
<ul>
<li>Stage کردن فایل‌های خاص برای ساخت commit‌های تمیز</li>
<li>Stage کردن تمام پروژه با استفاده از <code>-A</code> یا <code>.</code></li>
<li>بررسی قبل از Stage با استفاده از <code>-n</code></li>
<li>ثبت قصد اضافه کردن بدون Stage کردن محتوا</li>
<li>Stage کردن تکه‌به‌تکه تغییرات (برای کنترل بهتر)</li>
</ul>

<h3>مثال‌های پایه</h3>

<pre>
# Add a single file
git add file1.txt

# Add multiple files
git add file1.txt file2.txt

# Add all changes (new, modified, deletions)
git add -A

# Add all changes in the current directory
git add .

# Interactive staging (choose hunks)
git add -p

# Show what would be added (dry run)
git add -n

# Add file but don't stage content (just the intent)
git add --intent-to-add bigFile.zip
</pre>


<h3>مثال‌های پیشرفته</h3>
<pre>
# Add all C# files in a folder
git add src/**/*.cs

# Force add an ignored file (dangerous!)
git add -f logs/debug.log

# Add modified files, ignoring deletions
git add --ignore-removal .

# Handle files with spaces in their names
git add ""My File.txt""
</pre>

<h2>مقایسه git add و git commit</h2>
<table border = '1' cellpadding= '6' style= 'border-collapse:collapse;width:100%;'>
<tr>
<th> ویژگی </th><th> git add</th><th>git commit</th>
</tr>
<tr>
<td>هدف</td>
  <td>انتقال تغییرات به staging</td>
<td>ذخیره تغییرات staged در تاریخچه</td>
  </tr>
<tr>
<td>تغییر Working Directory؟</td>
<td>خیر</td>
  <td>خیر</td>
  </tr>
<tr>
<td>تغییر Staging Area؟</td>
<td>بله</td>
  <td>خیر</td>
  </tr>
<tr>
<td>ساخت snapshot؟</td>
<td>خیر</td>
  <td>بله</td>
  </tr>
<tr>
<td>میزان کنترل</td>
<td>بسیار بالا (انتخابی)</td>
<td>تمام چیزهایی که Stage شده</td>
  </tr>
</table>

<h3>به زبان ساده:</h3>
<p>
<code>git add</code> مشخص می‌کند <strong>چه چیزی</strong> commit شود.  
<code>git commit</code> مشخص می‌کند <strong>کی</strong> ذخیره شود.
  </p>

<h2>اشتباهات رایج</h2>
<ul>
<li><strong>استفاده از git add -A بدون بررسی</strong> که باعث Stage شدن حذف‌های ناخواسته می‌شود.</li>
<li><strong>فراموشی Stage کردن فایل‌های جدید</strong> و انتظار commit شدن آن‌ها.</li>
<li><strong>تصور اشتباه اینکه git add خودش commit می‌کند</strong>.</li>
<li><strong>Force کردن فایل‌های Ignored</strong> بدون دلیل منطقی.</li>
<li><strong>Stage کردن فایل‌های حجیم</strong> بدون اینکه بفهمید حجم commit را خراب می‌کند.</li>
<li><strong>استفاده از git add .</strong> در مسیر اشتباه و Stage شدن فایل‌های ناخواسته.</li>
</ul>

<h2>بهترین شیوه‌ها (Best Practices)</h2>
<ul>
<li>از<code> git add -p</code> برای کنترل دقیق استفاده کنید.</li>
<li>تغییرات مرتبط را در یک commit قرار دهید.</li>
<li>از Stage کردن فایل‌های تولیدشده (build outputs) خودداری کنید.</li>
<li>قبل از commit، خروجی<code> git status</code> را بررسی کنید.</li>
<li><code>.gitignore</code> را به‌درستی مدیریت کنید.</li>
<li>Commitهای کوچک و شفاف بسازید تا تاریخچه قابل‌پیگیری باشد.</li>
</ul>

<h2>محدودیت‌ها</h2>
  <ul>
<li>فایل‌های Ignored بدون<code>-f</code> اضافه نمی‌شوند</li>
  <li><code>-n</code> هیچ چیزی را Stage نمی‌کند</li>
<li><code>intent-to-add</code> فقط قصد افزودن را ثبت می‌کند</li>
  <li>فایل باید در سیستم وجود داشته باشد (به‌جز intent-to-add)</li>
</ul>
";



public List<GitField> Fields { get; set; } = new List<GitField>
    {
        new GitField { Name="Files", LabelEn="Files to Add", LabelFa="فایل‌های اضافه‌شده", Type="text", PlaceholderEn="file1.txt file2.txt", PlaceholderFa="مثال: file1.txt file2.txt", IsRequired=true },
        new GitField { Name="All", LabelEn="Add All Changes (-A)", LabelFa="اضافه کردن همه تغییرات (-A)", Type="checkbox" },
        new GitField { Name="Force", LabelEn="Force Add Ignored (-f)", LabelFa="اضافه کردن فایل‌های نادیده گرفته شده (-f)", Type="checkbox" },
        new GitField { Name="DryRun", LabelEn="Dry Run (-n)", LabelFa="شبیه‌سازی (-n)", Type="checkbox" },
        new GitField { Name="Verbose", LabelEn="Verbose (-v)", LabelFa="نمایش فایل‌ها (-v)", Type="checkbox" },
        new GitField { Name="IntentToAdd", LabelEn="Intent To Add (--intent-to-add)", LabelFa="ثبت قصد اضافه کردن (--intent-to-add)", Type="checkbox" },
        new GitField { Name="IgnoreRemoval", LabelEn="Ignore Removed (--ignore-removal)", LabelFa="نادیده گرفتن فایل‌های حذف شده (--ignore-removal)", Type="checkbox" }
    };
}
