namespace Core;

public class GitCommitPageModel
{
    public string TitleEn => "Git — Commit Toolkit";
    public string TitleFa => "ابزار کامل Commit در Git";

    // Very long, deep guide content for Guide tab (EN)
    public string GuideHtmlEn { get; set; }

    // Very long, deep guide content for Guide tab (FA)
    public string GuideHtmlFa { get; set; }

    public GitCommitPageModel()
    {
        // populate deep guide content (trimmed here for brevity; full content provided in view for clarity)
        GuideHtmlEn = @"
<h2>Comprehensive Git Commit Guide (EN)</h2>
<p><strong>Overview:</strong> A commit records a snapshot of the working tree and metadata (author, date, message). This guide covers simple commits, complex history editing (amend, fixup, squash), undo & recovery (reset, revert, restore), metadata overrides, signing, and advanced cases (orphan commits, commit-tree).</p>

<h3>Basic commit</h3>
<p><code>git commit -m 'message'</code> creates a new commit from staged changes. Changes must be staged (git add) unless you use -a to auto-stage modifications.</p>

<h4>Options & semantics</h4>
<ul>
<li><code>-m</code>: message inline</li>
<li><code>-F &lt;file&gt;</code>: read message from file</li>
<li><code>-a</code>: automatically stage tracked, modified files</li>
<li><code>-p</code>: interactively select hunks to stage and commit</li>
<li><code>--allow-empty</code>: create a commit with no changes</li>
<li><code>--no-verify</code>: skip pre-commit hooks</li>
<li><code>--cleanup</code>: how to clean the message (strip, whitespace, scissors)</li>
</ul>

<h3>Amend</h3>
<p><code>git commit --amend</code> modifies the most recent commit (update message, include additional staged changes, or both). Use with caution: amending published commits rewrites history.</p>

<h3>Fixup & autosquash</h3>
<p>Create a fixup commit targeted at an earlier commit:</p>
<pre>
git commit --fixup &lt;commit-hash&gt;
git rebase -i --autosquash &lt;base&gt;
</pre>

<h3>Squash</h3>
<p>Squash combines commits into one with interactive rebase or <code>--squash</code> option.</p>

<h3>Revert</h3>
<p><code>git revert &lt;commit&gt;</code> creates a new commit that undoes a previous commit — safe for published history.</p>

<h3>Reset</h3>
<p><code>git reset --soft|--mixed|--hard &lt;commit&gt;</code> moves HEAD and optionally updates index and working tree. Dangerous for published history.</p>

<h3>Restore</h3>
<p><code>git restore</code> is used for restoring files to a state from another commit, and can operate on staged or working tree.</p>

<h3>Metadata</h3>
<ul>
<li><code>--author=&quot;Name &lt;email&gt;&quot;</code>: override author</li>
<li><code>GIT_AUTHOR_DATE</code> / <code>--date</code>: override date</li>
<li>GPG signing: <code>-S</code> and key management</li>
</ul>

<h3>Advanced</h3>
<ul>
<li>orphan commits (start history from scratch): <code>git checkout --orphan</code></li>
<li>commit tree: <code>git commit-tree</code> for plumbing</li>
<li>commit verification and CI integration</li>
</ul>

<h3>Limitations & Best Practices</h3>
<ul>
<li>Avoid rewriting published commits (amend/reset/rebase) unless all consumers agree.</li>
<li>Prefer revert for shared history.</li>
<li>Keep commit messages meaningful (Conventional Commits recommended).</li>
<li>Sign important releases.</li>
<li>Use CI checks to validate message format and commit policies.</li>
</ul>
";

        GuideHtmlFa = @"
<h2>راهنمای جامع Commit در گیت (فارسی)</h2>
<p><strong>نمای کلی:</strong> کامیت در گیت یک اسنپ‌شات از وضعیت کار است که متادیتا (نویسنده، تاریخ، پیام) را ثبت می‌کند. این راهنما شامل ساخت کامیت ساده، ویرایش تاریخچه (amend, fixup, squash)، بازگردانی و بازیابی، بازنویسی متادیتا، امضا و موارد پیشرفته است.</p>

<h3>کامیت ساده</h3>
<p><code>git commit -m 'message'</code> یک کامیت جدید از تغییرات آماده‌شده ایجاد می‌کند. تغییرات باید با git add آماده شده باشند مگر از -a استفاده کنید.</p>

<h4>گزینه‌ها و معنا</h4>
<ul>
<li><code>-m</code>: پیام در خط فرمان</li>
<li><code>-F &lt;file&gt;</code>: خواندن پیام از فایل</li>
<li><code>-a</code>: آماده‌سازی خودکار فایل‌های tracked</li>
<li><code>-p</code>: انتخاب تعاملی هانک‌ها برای اضافه شدن</li>
<li><code>--allow-empty</code>: ایجاد کامیت بدون تغییر</li>
<li><code>--no-verify</code>: نادیده گرفتن pre-commit hookها</li>
<li><code>--cleanup</code>: حالت پاکسازی پیام</li>
</ul>

<h3>Amend</h3>
<p><code>git commit --amend</code> آخرین کامیت را ویرایش می‌کند — محتاط باشید چون تاریخچه را بازنویسی می‌کند.</p>

<h3>Fixup & autosquash</h3>
<p>برای اصلاح کامیت قدیمی از fixup و سپس rebase --autosquash استفاده کنید.</p>

<h3>Squash</h3>
<p>ترکیب چند کامیت به یک با rebase یا گزینه‌های مرتبط.</p>

<h3>Revert</h3>
<p><code>git revert &lt;commit&gt;</code> یک کامیت معکوس‌کننده می‌سازد — امن برای تاریخچه منتشرشده.</p>

<h3>Reset</h3>
<p><code>git reset --soft|--mixed|--hard &lt;commit&gt;</code> HEAD را جابجا می‌کند و ممکن است index و working tree را تغییردهد — خطرناک برای تاریخچه منتشرشده.</p>

<h3>Restore</h3>
<p><code>git restore</code> برای بازگردانی فایل‌ها از یک کامیت استفاده می‌شود، جدا از reset.</p>

<h3>متادیتا</h3>
<ul>
<li><code>--author=&quot;Name &lt;email&gt;&quot;</code>: بازنویسی نویسنده</li>
<li><code>GIT_AUTHOR_DATE</code> / <code>--date</code>: بازنویسی تاریخ</li>
<li>امضای GPG: <code>-S</code> و مدیریت کلید</li>
</ul>

<h3>موارد پیشرفته</h3>
<ul>
<li>کامیت‌های orphan برای شروع تاریخچه جدید: <code>git checkout --orphan</code></li>
<li>plumbing: <code>git commit-tree</code></li>
<li>اعتبارسنجی کامیت‌ها در CI</li>
</ul>

<h3>محدودیت‌ها و بهترین روش‌ها</h3>
<ul>
<li>بازنویسی تاریخچهٔ منتشرشده را بدون هماهنگی انجام ندهید.</li>
<li>برای بازگرداندن تغییرات عمومی از revert استفاده کنید.</li>
<li>پیام‌ها را معنادار و سازگار نگه دارید (مثل Conventional Commits).</li>
<li>برای انتشارها تگ‌های امضا شده و کامیت‌های امضا شده استفاده کنید.</li>
</ul>
";
    }
}

